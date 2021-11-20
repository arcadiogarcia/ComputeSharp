// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("9EDDE9E7-8DEE-47EA-99DF-E6FAF2ED44BF")]
    [NativeTypeName("struct IWICBitmapDecoder : IUnknown")]
    [NativeInheritance("IUnknown")]
    internal unsafe partial struct IWICBitmapDecoder : IWICBitmapDecoder.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint>)(lpVtbl[1]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint>)(lpVtbl[2]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryCapability(IStream* pIStream, [NativeTypeName("DWORD *")] uint* pdwCapability)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IStream*, uint*, int>)(lpVtbl[3]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, pdwCapability);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Initialize(IStream* pIStream, WICDecodeOptions cacheOptions)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IStream*, WICDecodeOptions, int>)(lpVtbl[4]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIStream, cacheOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, Guid*, int>)(lpVtbl[5]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pguidContainerFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapDecoderInfo**, int>)(lpVtbl[6]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIDecoderInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CopyPalette(IWICPalette* pIPalette)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICPalette*, int>)(lpVtbl[7]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pIPalette);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICMetadataQueryReader**, int>)(lpVtbl[8]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryReader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetPreview(IWICBitmapSource** ppIBitmapSource)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)(lpVtbl[9]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIBitmapSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICColorContext**, uint*, int>)(lpVtbl[10]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), cCount, ppIColorContexts, pcActualCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetThumbnail(IWICBitmapSource** ppIThumbnail)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, IWICBitmapSource**, int>)(lpVtbl[11]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), ppIThumbnail);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetFrameCount(uint* pCount)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint*, int>)(lpVtbl[12]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetFrame(uint index, IWICBitmapFrameDecode** ppIBitmapFrame)
        {
            return ((delegate* unmanaged[Stdcall]<IWICBitmapDecoder*, uint, IWICBitmapFrameDecode**, int>)(lpVtbl[13]))((IWICBitmapDecoder*)Unsafe.AsPointer(ref this), index, ppIBitmapFrame);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT QueryCapability(IStream* pIStream, [NativeTypeName("DWORD *")] uint* pdwCapability);

            [VtblIndex(4)]
            HRESULT Initialize(IStream* pIStream, WICDecodeOptions cacheOptions);

            [VtblIndex(5)]
            HRESULT GetContainerFormat(Guid* pguidContainerFormat);

            [VtblIndex(6)]
            HRESULT GetDecoderInfo(IWICBitmapDecoderInfo** ppIDecoderInfo);

            [VtblIndex(7)]
            HRESULT CopyPalette(IWICPalette* pIPalette);

            [VtblIndex(8)]
            HRESULT GetMetadataQueryReader(IWICMetadataQueryReader** ppIMetadataQueryReader);

            [VtblIndex(9)]
            HRESULT GetPreview(IWICBitmapSource** ppIBitmapSource);

            [VtblIndex(10)]
            HRESULT GetColorContexts(uint cCount, IWICColorContext** ppIColorContexts, uint* pcActualCount);

            [VtblIndex(11)]
            HRESULT GetThumbnail(IWICBitmapSource** ppIThumbnail);

            [VtblIndex(12)]
            HRESULT GetFrameCount(uint* pCount);

            [VtblIndex(13)]
            HRESULT GetFrame(uint index, IWICBitmapFrameDecode** ppIBitmapFrame);
        }
    }
}
