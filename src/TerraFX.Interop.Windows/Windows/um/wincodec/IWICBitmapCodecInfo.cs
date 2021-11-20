// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("E87A44C4-B76E-4C47-8B09-298EB12A2714")]
    [NativeTypeName("struct IWICBitmapCodecInfo : IWICComponentInfo")]
    [NativeInheritance("IWICComponentInfo")]
    internal unsafe partial struct IWICBitmapCodecInfo : IWICBitmapCodecInfo.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint>)(lpVtbl[1]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint>)(lpVtbl[2]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetComponentType(WICComponentType* pType)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)(lpVtbl[4]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint*, int>)(lpVtbl[5]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetVendorGUID(Guid* pguidVendor)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)(lpVtbl[7]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, Guid*, int>)(lpVtbl[11]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetColorManagementVersion(uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] ushort* wzColorManagementVersion, uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[14]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[15]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetMimeTypes(uint cchMimeTypes, [NativeTypeName("WCHAR *")] ushort* wzMimeTypes, uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[16]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetFileExtensions(uint cchFileExtensions, [NativeTypeName("WCHAR *")] ushort* wzFileExtensions, uint* pcchActual)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, uint, ushort*, uint*, int>)(lpVtbl[17]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT DoesSupportAnimation(BOOL* pfSupportAnimation)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, BOOL*, int>)(lpVtbl[18]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT DoesSupportChromakey(BOOL* pfSupportChromakey)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, BOOL*, int>)(lpVtbl[19]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT DoesSupportLossless(BOOL* pfSupportLossless)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, BOOL*, int>)(lpVtbl[20]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT DoesSupportMultiframe(BOOL* pfSupportMultiframe)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, BOOL*, int>)(lpVtbl[21]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT MatchesMimeType([NativeTypeName("LPCWSTR")] ushort* wzMimeType, BOOL* pfMatches)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapCodecInfo*, ushort*, BOOL*, int>)(lpVtbl[22]))((IWICBitmapCodecInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
        }

        public interface Interface : IWICComponentInfo.Interface
        {
            [VtblIndex(11)]
            HRESULT GetContainerFormat(Guid* pguidContainerFormat);

            [VtblIndex(12)]
            HRESULT GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual);

            [VtblIndex(13)]
            HRESULT GetColorManagementVersion(uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] ushort* wzColorManagementVersion, uint* pcchActual);

            [VtblIndex(14)]
            HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] ushort* wzDeviceManufacturer, uint* pcchActual);

            [VtblIndex(15)]
            HRESULT GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] ushort* wzDeviceModels, uint* pcchActual);

            [VtblIndex(16)]
            HRESULT GetMimeTypes(uint cchMimeTypes, [NativeTypeName("WCHAR *")] ushort* wzMimeTypes, uint* pcchActual);

            [VtblIndex(17)]
            HRESULT GetFileExtensions(uint cchFileExtensions, [NativeTypeName("WCHAR *")] ushort* wzFileExtensions, uint* pcchActual);

            [VtblIndex(18)]
            HRESULT DoesSupportAnimation(BOOL* pfSupportAnimation);

            [VtblIndex(19)]
            HRESULT DoesSupportChromakey(BOOL* pfSupportChromakey);

            [VtblIndex(20)]
            HRESULT DoesSupportLossless(BOOL* pfSupportLossless);

            [VtblIndex(21)]
            HRESULT DoesSupportMultiframe(BOOL* pfSupportMultiframe);

            [VtblIndex(22)]
            HRESULT MatchesMimeType([NativeTypeName("LPCWSTR")] ushort* wzMimeType, BOOL* pfMatches);
        }
    }
}
