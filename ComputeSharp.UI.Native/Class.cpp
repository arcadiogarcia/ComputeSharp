#include "pch.h"
#include "Class.h"
#include "Class.g.cpp"

#include <d3d11.h>
#include <

namespace winrt::ComputeSharp_UI_Native::implementation
{
    Class::Class()
    {
    }


    //Based on https://docs.microsoft.com/en-us/windows/win32/comp_swapchain/comp-swapchain-examples#example-4binding-a-presentation-surface-to-a-directcomposition-visual


    bool TryCreatePresentationManager(
        _In_ bool requestDirectPresentation,
        _Out_ ID3D11Device** ppD3DDevice,
        _Outptr_opt_result_maybenull_ IPresentationManager** ppPresentationManager)
    {
        // Null the presentation manager and Direct3D device initially
        *ppD3DDevice = nullptr;
        *ppPresentationManager = nullptr;

        // Direct3D device creation flags. The composition swapchain API requires that applications disable internal
        // driver threading optimizations, as these optimizations are incompatible with the
        // composition swapchain API. If this flag is not present, then the API will fail the call to create the
        // presentation factory.
        UINT deviceCreationFlags =
            D3D11_CREATE_DEVICE_BGRA_SUPPORT |
            D3D11_CREATE_DEVICE_SINGLETHREADED |
            D3D11_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS;

        // Create the Direct3D device.
        com_ptr_failfast<ID3D11DeviceContext> d3dDeviceContext;
        FAIL_FAST_IF_FAILED(D3D11CreateDevice(
            nullptr,                   // No adapter
            D3D_DRIVER_TYPE_HARDWARE,  // Hardware device
            nullptr,                   // No module
            deviceCreationFlags,       // Device creation flags
            nullptr, 0,                // Highest available feature level
            D3D11_SDK_VERSION,         // API version
            ppD3DDevice,               // Resulting interface pointer
            nullptr,                   // Actual feature level
            &d3dDeviceContext));       // Device context

        // Call the composition swapchain API export to create the presentation factory.
        com_ptr_failfast<IPresentationFactory> presentationFactory;
        FAIL_FAST_IF_FAILED(CreatePresentationFactory(
            (*ppD3DDevice),
            IID_PPV_ARGS(&presentationFactory)));

        // Determine whether the system is capable of supporting the composition swapchain API based
        // on the capability that's reported by the presentation factory. If your application
        // wants direct presentation (that is, presentation without the need for DWM to
        // compose, using MPO or iflip), then we query for direct presentation support.
        bool isSupportedOnSystem;
        if (requestDirectPresentation)
        {
            isSupportedOnSystem = presentationFactory->IsPresentationSupportedWithIndependentFlip();
        }
        else
        {
            isSupportedOnSystem = presentationFactory->IsPresentationSupported();
        }

        // Create the presentation manager if it is supported on the current system.
        if (isSupportedOnSystem)
        {
            FAIL_FAST_IF_FAILED(presentationFactory->CreatePresentationManager(ppPresentationManager));
        }

        return isSupportedOnSystem;
    }

    int32_t Class::MyProperty()
    {
        throw hresult_not_implemented();
    }

    void Class::MyProperty(int32_t /* value */)
    {
        throw hresult_not_implemented();
    }
}
