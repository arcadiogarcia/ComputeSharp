// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("47DD575D-AC05-4CDD-8049-9B02CD16F44C")]
    [NativeTypeName("struct ID2D1Device : ID2D1Resource")]
    [NativeInheritance("ID2D1Resource")]
    internal unsafe partial struct ID2D1Device
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Device*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Device*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Device*, uint>)(lpVtbl[1]))((ID2D1Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Device*, uint>)(lpVtbl[2]))((ID2D1Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Device*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Device*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext** deviceContext)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Device*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext**, int>)(lpVtbl[4]))((ID2D1Device*)Unsafe.AsPointer(ref this), options, deviceContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [NativeTypeName("const D2D1_PRINT_CONTROL_PROPERTIES *")] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, ID2D1PrintControl** printControl)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, D2D1_PRINT_CONTROL_PROPERTIES*, ID2D1PrintControl**, int>)(lpVtbl[5]))((ID2D1Device*)Unsafe.AsPointer(ref this), wicFactory, documentTarget, printControlProperties, printControl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void SetMaximumTextureMemory([NativeTypeName("UINT64")] ulong maximumInBytes)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Device*, ulong, void>)(lpVtbl[6]))((ID2D1Device*)Unsafe.AsPointer(ref this), maximumInBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumTextureMemory()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1Device*, ulong>)(lpVtbl[7]))((ID2D1Device*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1Device*, uint, void>)(lpVtbl[8]))((ID2D1Device*)Unsafe.AsPointer(ref this), millisecondsSinceUse);
        }
    }
}
