// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("B84E2C09-78C9-4AC4-8BD3-524AE1663A2F")]
    [NativeTypeName("struct IWICFastMetadataEncoder : IUnknown")]
    [NativeInheritance("IUnknown")]
    internal unsafe partial struct IWICFastMetadataEncoder : IWICFastMetadataEncoder.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICFastMetadataEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICFastMetadataEncoder*, uint>)(lpVtbl[1]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICFastMetadataEncoder*, uint>)(lpVtbl[2]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Commit()
        {
            return ((delegate* unmanaged[Stdcall]<IWICFastMetadataEncoder*, int>)(lpVtbl[3]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter)
        {
            return ((delegate* unmanaged[Stdcall]<IWICFastMetadataEncoder*, IWICMetadataQueryWriter**, int>)(lpVtbl[4]))((IWICFastMetadataEncoder*)Unsafe.AsPointer(ref this), ppIMetadataQueryWriter);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Commit();

            [VtblIndex(4)]
            HRESULT GetMetadataQueryWriter(IWICMetadataQueryWriter** ppIMetadataQueryWriter);
        }
    }
}
