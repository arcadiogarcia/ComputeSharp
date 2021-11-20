// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("ACD16696-8C14-4F5D-877E-FE3FC1D32737")]
    [NativeTypeName("struct IDWriteFont : IUnknown")]
    [NativeInheritance("IUnknown")]
    internal unsafe partial struct IDWriteFont : IDWriteFont.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFont*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, uint>)(lpVtbl[1]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, uint>)(lpVtbl[2]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetFontFamily(IDWriteFontFamily** fontFamily)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, IDWriteFontFamily**, int>)(lpVtbl[3]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontFamily);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public DWRITE_FONT_WEIGHT GetWeight()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, DWRITE_FONT_WEIGHT>)(lpVtbl[4]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public DWRITE_FONT_STRETCH GetStretch()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, DWRITE_FONT_STRETCH>)(lpVtbl[5]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public DWRITE_FONT_STYLE GetStyle()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, DWRITE_FONT_STYLE>)(lpVtbl[6]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public BOOL IsSymbolFont()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, int>)(lpVtbl[7]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetFaceNames(IDWriteLocalizedStrings** names)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, IDWriteLocalizedStrings**, int>)(lpVtbl[8]))((IDWriteFont*)Unsafe.AsPointer(ref this), names);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, DWRITE_INFORMATIONAL_STRING_ID, IDWriteLocalizedStrings**, BOOL*, int>)(lpVtbl[9]))((IDWriteFont*)Unsafe.AsPointer(ref this), informationalStringID, informationalStrings, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public DWRITE_FONT_SIMULATIONS GetSimulations()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, DWRITE_FONT_SIMULATIONS>)(lpVtbl[10]))((IDWriteFont*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public void GetMetrics(DWRITE_FONT_METRICS* fontMetrics)
        {
            ((delegate* unmanaged[Stdcall]<IDWriteFont*, DWRITE_FONT_METRICS*, void>)(lpVtbl[11]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, BOOL* exists)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, uint, BOOL*, int>)(lpVtbl[12]))((IDWriteFont*)Unsafe.AsPointer(ref this), unicodeValue, exists);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CreateFontFace(IDWriteFontFace** fontFace)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteFont*, IDWriteFontFace**, int>)(lpVtbl[13]))((IDWriteFont*)Unsafe.AsPointer(ref this), fontFace);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetFontFamily(IDWriteFontFamily** fontFamily);

            [VtblIndex(4)]
            DWRITE_FONT_WEIGHT GetWeight();

            [VtblIndex(5)]
            DWRITE_FONT_STRETCH GetStretch();

            [VtblIndex(6)]
            DWRITE_FONT_STYLE GetStyle();

            [VtblIndex(7)]
            BOOL IsSymbolFont();

            [VtblIndex(8)]
            HRESULT GetFaceNames(IDWriteLocalizedStrings** names);

            [VtblIndex(9)]
            HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, IDWriteLocalizedStrings** informationalStrings, BOOL* exists);

            [VtblIndex(10)]
            DWRITE_FONT_SIMULATIONS GetSimulations();

            [VtblIndex(11)]
            void GetMetrics(DWRITE_FONT_METRICS* fontMetrics);

            [VtblIndex(12)]
            HRESULT HasCharacter([NativeTypeName("UINT32")] uint unicodeValue, BOOL* exists);

            [VtblIndex(13)]
            HRESULT CreateFontFace(IDWriteFontFace** fontFace);
        }
    }
}
