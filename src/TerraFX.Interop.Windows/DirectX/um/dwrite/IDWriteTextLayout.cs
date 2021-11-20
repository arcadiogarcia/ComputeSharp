// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("53737037-6D14-410B-9BFE-0B182BB70961")]
    [NativeTypeName("struct IDWriteTextLayout : IDWriteTextFormat")]
    [NativeInheritance("IDWriteTextFormat")]
    internal unsafe partial struct IDWriteTextLayout : IDWriteTextLayout.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint>)(lpVtbl[1]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint>)(lpVtbl[2]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetIncrementalTabStop(float incrementalTabStop)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, int>)(lpVtbl[8]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public float GetIncrementalTabStop()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)(lpVtbl[16]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, float* lineSpacing, float* baseline)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint>)(lpVtbl[20]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public float GetFontSize()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)(lpVtbl[25]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint>)(lpVtbl[26]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT SetMaxWidth(float maxWidth)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, int>)(lpVtbl[28]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), maxWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT SetMaxHeight(float maxHeight)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, int>)(lpVtbl[29]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), maxHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT SetFontCollection(IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteFontCollection*, DWRITE_TEXT_RANGE, int>)(lpVtbl[30]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontCollection, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT SetFontFamilyName([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ushort*, DWRITE_TEXT_RANGE, int>)(lpVtbl[31]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontFamilyName, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE, int>)(lpVtbl[32]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontWeight, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE, int>)(lpVtbl[33]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontStyle, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE, int>)(lpVtbl[34]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontStretch, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT SetFontSize(float fontSize, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, DWRITE_TEXT_RANGE, int>)(lpVtbl[35]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), fontSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT SetUnderline(BOOL hasUnderline, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, BOOL, DWRITE_TEXT_RANGE, int>)(lpVtbl[36]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), hasUnderline, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT SetStrikethrough(BOOL hasStrikethrough, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, BOOL, DWRITE_TEXT_RANGE, int>)(lpVtbl[37]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), hasStrikethrough, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT SetDrawingEffect(IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IUnknown*, DWRITE_TEXT_RANGE, int>)(lpVtbl[38]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), drawingEffect, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT SetInlineObject(IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteInlineObject*, DWRITE_TEXT_RANGE, int>)(lpVtbl[39]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), inlineObject, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT SetTypography(IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, IDWriteTypography*, DWRITE_TEXT_RANGE, int>)(lpVtbl[40]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), typography, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT SetLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, ushort*, DWRITE_TEXT_RANGE, int>)(lpVtbl[41]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), localeName, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public float GetMaxWidth()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)(lpVtbl[42]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public float GetMaxHeight()
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float>)(lpVtbl[43]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT GetFontCollection([NativeTypeName("UINT32")] uint currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteFontCollection**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[44]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontCollection, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT GetFontFamilyNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, uint*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[45]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT GetFontFamilyName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[46]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontFamilyName, nameSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT GetFontWeight([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, DWRITE_FONT_WEIGHT*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[47]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontWeight, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT GetFontStyle([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, DWRITE_FONT_STYLE*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[48]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontStyle, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT GetFontStretch([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, DWRITE_FONT_STRETCH*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[49]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontStretch, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT GetFontSize([NativeTypeName("UINT32")] uint currentPosition, float* fontSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, float*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[50]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, fontSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT GetUnderline([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasUnderline, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, BOOL*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[51]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, hasUnderline, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public HRESULT GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasStrikethrough, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, BOOL*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[52]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, hasStrikethrough, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        public HRESULT GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IUnknown**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[53]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, drawingEffect, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        public HRESULT GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteInlineObject**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[54]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, inlineObject, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        public HRESULT GetTypography([NativeTypeName("UINT32")] uint currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, IDWriteTypography**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[55]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, typography, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public HRESULT GetLocaleNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, uint*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[56]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT GetLocaleName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[57]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), currentPosition, localeName, nameSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, void*, IDWriteTextRenderer*, float, float, int>)(lpVtbl[58]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT GetLineMetrics(DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_LINE_METRICS*, uint, uint*, int>)(lpVtbl[59]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT GetMetrics(DWRITE_TEXT_METRICS* textMetrics)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_TEXT_METRICS*, int>)(lpVtbl[60]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_OVERHANG_METRICS*, int>)(lpVtbl[61]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), overhangs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT GetClusterMetrics(DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, DWRITE_CLUSTER_METRICS*, uint, uint*, int>)(lpVtbl[62]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), clusterMetrics, maxClusterCount, actualClusterCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT DetermineMinWidth(float* minWidth)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float*, int>)(lpVtbl[63]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), minWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT HitTestPoint(float pointX, float pointY, BOOL* isTrailingHit, BOOL* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, float, float, BOOL*, BOOL*, DWRITE_HIT_TEST_METRICS*, int>)(lpVtbl[64]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, BOOL isTrailingHit, float* pointX, float* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, BOOL, float*, float*, DWRITE_HIT_TEST_METRICS*, int>)(lpVtbl[65]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, float originX, float originY, DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount)
        {
            return ((delegate* unmanaged[Stdcall]<IDWriteTextLayout*, uint, uint, float, float, DWRITE_HIT_TEST_METRICS*, uint, uint*, int>)(lpVtbl[66]))((IDWriteTextLayout*)Unsafe.AsPointer(ref this), textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
        }

        public interface Interface : IDWriteTextFormat.Interface
        {
            [VtblIndex(28)]
            HRESULT SetMaxWidth(float maxWidth);

            [VtblIndex(29)]
            HRESULT SetMaxHeight(float maxHeight);

            [VtblIndex(30)]
            HRESULT SetFontCollection(IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(31)]
            HRESULT SetFontFamilyName([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(32)]
            HRESULT SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(33)]
            HRESULT SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(34)]
            HRESULT SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(35)]
            HRESULT SetFontSize(float fontSize, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(36)]
            HRESULT SetUnderline(BOOL hasUnderline, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(37)]
            HRESULT SetStrikethrough(BOOL hasStrikethrough, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(38)]
            HRESULT SetDrawingEffect(IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(39)]
            HRESULT SetInlineObject(IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(40)]
            HRESULT SetTypography(IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(41)]
            HRESULT SetLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange);

            [VtblIndex(42)]
            float GetMaxWidth();

            [VtblIndex(43)]
            float GetMaxHeight();

            [VtblIndex(44)]
            HRESULT GetFontCollection([NativeTypeName("UINT32")] uint currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(45)]
            HRESULT GetFontFamilyNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(46)]
            HRESULT GetFontFamilyName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(47)]
            HRESULT GetFontWeight([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(48)]
            HRESULT GetFontStyle([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(49)]
            HRESULT GetFontStretch([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(50)]
            HRESULT GetFontSize([NativeTypeName("UINT32")] uint currentPosition, float* fontSize, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(51)]
            HRESULT GetUnderline([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasUnderline, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(52)]
            HRESULT GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasStrikethrough, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(53)]
            HRESULT GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(54)]
            HRESULT GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(55)]
            HRESULT GetTypography([NativeTypeName("UINT32")] uint currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(56)]
            HRESULT GetLocaleNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(57)]
            HRESULT GetLocaleName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null);

            [VtblIndex(58)]
            HRESULT Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, float originX, float originY);

            [VtblIndex(59)]
            HRESULT GetLineMetrics(DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount);

            [VtblIndex(60)]
            HRESULT GetMetrics(DWRITE_TEXT_METRICS* textMetrics);

            [VtblIndex(61)]
            HRESULT GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs);

            [VtblIndex(62)]
            HRESULT GetClusterMetrics(DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount);

            [VtblIndex(63)]
            HRESULT DetermineMinWidth(float* minWidth);

            [VtblIndex(64)]
            HRESULT HitTestPoint(float pointX, float pointY, BOOL* isTrailingHit, BOOL* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics);

            [VtblIndex(65)]
            HRESULT HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, BOOL isTrailingHit, float* pointX, float* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics);

            [VtblIndex(66)]
            HRESULT HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, float originX, float originY, DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount);
        }
    }
}
