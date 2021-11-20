// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.DirectX.D2D1_BITMAP_INTERPOLATION_MODE;
using static TerraFX.Interop.DirectX.D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS;
using static TerraFX.Interop.DirectX.D2D1_COMPOSITE_MODE;
using static TerraFX.Interop.DirectX.D2D1_DRAW_TEXT_OPTIONS;
using static TerraFX.Interop.DirectX.D2D1_EXTEND_MODE;
using static TerraFX.Interop.DirectX.D2D1_GAMMA;
using static TerraFX.Interop.DirectX.D2D1_INTERPOLATION_MODE;
using static TerraFX.Interop.DirectX.DWRITE_MEASURING_MODE;

namespace TerraFX.Interop.DirectX
{
    [Guid("E8F7FE7A-191C-466D-AD95-975678BDA998")]
    [NativeTypeName("struct ID2D1DeviceContext : ID2D1RenderTarget")]
    [NativeInheritance("ID2D1RenderTarget")]
    internal unsafe partial struct ID2D1DeviceContext
    {
        public void** lpVtbl;

        public HRESULT CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const D2D1_BITMAP_PROPERTIES &")] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            return CreateBitmap(size, null, 0, bitmapProperties, bitmap);
        }

        public HRESULT CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, ID2D1Bitmap** bitmap)
        {
            return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
        }

        public HRESULT CreateBitmapBrush(ID2D1Bitmap* bitmap, ID2D1BitmapBrush** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
        }

        public HRESULT CreateBitmapBrush(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES &")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
        }

        public HRESULT CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F &")] DXGI_RGBA* color, ID2D1SolidColorBrush** solidColorBrush)
        {
            return CreateSolidColorBrush(color, null, solidColorBrush);
        }

        public HRESULT CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, ID2D1GradientStopCollection** gradientStopCollection)
        {
            return CreateGradientStopCollection(gradientStops, gradientStopsCount, D2D1_GAMMA_2_2, D2D1_EXTEND_MODE_CLAMP, gradientStopCollection);
        }

        public HRESULT CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES &")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            return CreateLinearGradientBrush(linearGradientBrushProperties, null, gradientStopCollection, linearGradientBrush);
        }

        public HRESULT CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES &")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            return CreateRadialGradientBrush(radialGradientBrushProperties, null, gradientStopCollection, radialGradientBrush);
        }

        public HRESULT CreateCompatibleRenderTarget(ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(null, null, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        public HRESULT CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, null, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        public HRESULT CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, null, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        public HRESULT CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, D2D1_PIXEL_FORMAT desiredFormat, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE, bitmapRenderTarget);
        }

        public HRESULT CreateCompatibleRenderTarget([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F desiredSize, [NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U desiredPixelSize, D2D1_PIXEL_FORMAT desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return CreateCompatibleRenderTarget(&desiredSize, &desiredPixelSize, &desiredFormat, options, bitmapRenderTarget);
        }

        public HRESULT CreateLayer([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F size, ID2D1Layer** layer)
        {
            return CreateLayer(&size, layer);
        }

        public HRESULT CreateLayer(ID2D1Layer** layer)
        {
            return CreateLayer(null, layer);
        }

        public HRESULT CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, ID2D1Bitmap1** bitmap)
        {
            return CreateBitmapFromWicBitmap(wicBitmapSource, null, bitmap);
        }

        public HRESULT CreateImageBrush(ID2D1Image* image, [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES &")] D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, ID2D1ImageBrush** imageBrush)
        {
            return CreateImageBrush(image, imageBrushProperties, null, imageBrush);
        }

        public HRESULT CreateBitmapBrush(ID2D1Bitmap* bitmap, ID2D1BitmapBrush1** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, null, null, bitmapBrush);
        }

        public HRESULT CreateBitmapBrush(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 &")] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, ID2D1BitmapBrush1** bitmapBrush)
        {
            return CreateBitmapBrush(bitmap, bitmapBrushProperties, null, bitmapBrush);
        }

        public void DrawImage(ID2D1Effect* effect, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            ID2D1Image* output = null;

            effect->GetOutput(&output);
            DrawImage(output, targetOffset, imageRectangle, interpolationMode, compositeMode);
            output->Release();
        }

        public void DrawImage(ID2D1Image* image, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, null, null, interpolationMode, compositeMode);
        }

        public void DrawImage(ID2D1Effect* effect, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, null, null, interpolationMode, compositeMode);
        }

        public void DrawImage(ID2D1Image* image, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, &targetOffset, null, interpolationMode, compositeMode);
        }

        public void DrawImage(ID2D1Effect* effect, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, &targetOffset, null, interpolationMode, compositeMode);
        }

        public void DrawImage(ID2D1Image* image, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, [NativeTypeName("const D2D1_RECT_F &")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(image, &targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        public void DrawImage(ID2D1Effect* effect, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset, [NativeTypeName("const D2D1_RECT_F &")] D2D_RECT_F* imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            DrawImage(effect, &targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        public void DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F targetOffset)
        {
            DrawGdiMetafile(gdiMetafile, &targetOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, uint>)(lpVtbl[1]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, uint>)(lpVtbl[2]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_SIZE_U, void*, uint, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int>)(lpVtbl[4]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), size, srcData, pitch, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IWICBitmapSource*, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int>)(lpVtbl[5]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateSharedBitmap([NativeTypeName("const IID &")] Guid* riid, void* data, [NativeTypeName("const D2D1_BITMAP_PROPERTIES *")] D2D1_BITMAP_PROPERTIES* bitmapProperties, ID2D1Bitmap** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, void*, D2D1_BITMAP_PROPERTIES*, ID2D1Bitmap**, int>)(lpVtbl[6]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), riid, data, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CreateBitmapBrush(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES *")] D2D1_BITMAP_BRUSH_PROPERTIES* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush** bitmapBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, D2D1_BITMAP_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1BitmapBrush**, int>)(lpVtbl[7]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT CreateSolidColorBrush([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1SolidColorBrush** solidColorBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, DXGI_RGBA*, D2D1_BRUSH_PROPERTIES*, ID2D1SolidColorBrush**, int>)(lpVtbl[8]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), color, brushProperties, solidColorBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* gradientStops, [NativeTypeName("UINT32")] uint gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, ID2D1GradientStopCollection** gradientStopCollection)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_GRADIENT_STOP*, uint, D2D1_GAMMA, D2D1_EXTEND_MODE, ID2D1GradientStopCollection**, int>)(lpVtbl[9]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), gradientStops, gradientStopsCount, colorInterpolationGamma, extendMode, gradientStopCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT CreateLinearGradientBrush([NativeTypeName("const D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES *")] D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES* linearGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1LinearGradientBrush** linearGradientBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection*, ID2D1LinearGradientBrush**, int>)(lpVtbl[10]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), linearGradientBrushProperties, brushProperties, gradientStopCollection, linearGradientBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateRadialGradientBrush([NativeTypeName("const D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES *")] D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES* radialGradientBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1GradientStopCollection* gradientStopCollection, ID2D1RadialGradientBrush** radialGradientBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1GradientStopCollection*, ID2D1RadialGradientBrush**, int>)(lpVtbl[11]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), radialGradientBrushProperties, brushProperties, gradientStopCollection, radialGradientBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CreateCompatibleRenderTarget([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* desiredSize, [NativeTypeName("const D2D1_SIZE_U *")] D2D_SIZE_U* desiredPixelSize, [NativeTypeName("const D2D1_PIXEL_FORMAT *")] D2D1_PIXEL_FORMAT* desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, ID2D1BitmapRenderTarget** bitmapRenderTarget)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_SIZE_F*, D2D_SIZE_U*, D2D1_PIXEL_FORMAT*, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS, ID2D1BitmapRenderTarget**, int>)(lpVtbl[12]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), desiredSize, desiredPixelSize, desiredFormat, options, bitmapRenderTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT CreateLayer([NativeTypeName("const D2D1_SIZE_F *")] D2D_SIZE_F* size, ID2D1Layer** layer)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_SIZE_F*, ID2D1Layer**, int>)(lpVtbl[13]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), size, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT CreateMesh(ID2D1Mesh** mesh)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Mesh**, int>)(lpVtbl[14]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), mesh);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public void DrawLine([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point0, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F point1, ID2D1Brush* brush, float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_POINT_2F, D2D_POINT_2F, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[15]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), point0, point1, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public void DrawRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, ID2D1Brush* brush, float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_RECT_F*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[16]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), rect, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void FillRectangle([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* rect, ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_RECT_F*, ID2D1Brush*, void>)(lpVtbl[17]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), rect, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public void DrawRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush, float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_ROUNDED_RECT*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[18]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), roundedRect, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public void FillRoundedRectangle([NativeTypeName("const D2D1_ROUNDED_RECT *")] D2D1_ROUNDED_RECT* roundedRect, ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_ROUNDED_RECT*, ID2D1Brush*, void>)(lpVtbl[19]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), roundedRect, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public void DrawEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, ID2D1Brush* brush, float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_ELLIPSE*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[20]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), ellipse, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public void FillEllipse([NativeTypeName("const D2D1_ELLIPSE *")] D2D1_ELLIPSE* ellipse, ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_ELLIPSE*, ID2D1Brush*, void>)(lpVtbl[21]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), ellipse, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public void DrawGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, float strokeWidth = 1.0f, ID2D1StrokeStyle* strokeStyle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, float, ID2D1StrokeStyle*, void>)(lpVtbl[22]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), geometry, brush, strokeWidth, strokeStyle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public void FillGeometry(ID2D1Geometry* geometry, ID2D1Brush* brush, ID2D1Brush* opacityBrush = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Geometry*, ID2D1Brush*, ID2D1Brush*, void>)(lpVtbl[23]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), geometry, brush, opacityBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public void FillMesh(ID2D1Mesh* mesh, ID2D1Brush* brush)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Mesh*, ID2D1Brush*, void>)(lpVtbl[24]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), mesh, brush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, D2D1_OPACITY_MASK_CONTENT content, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, D2D1_OPACITY_MASK_CONTENT, D2D_RECT_F*, D2D_RECT_F*, void>)(lpVtbl[25]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), opacityMask, brush, content, destinationRectangle, sourceRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public void DrawBitmap(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, float opacity = 1.0f, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode = D2D1_BITMAP_INTERPOLATION_MODE_LINEAR, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_BITMAP_INTERPOLATION_MODE, D2D_RECT_F*, void>)(lpVtbl[26]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public void DrawText([NativeTypeName("const WCHAR *")] ushort* @string, [NativeTypeName("UINT32")] uint stringLength, IDWriteTextFormat* textFormat, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* layoutRect, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ushort*, uint, IDWriteTextFormat*, D2D_RECT_F*, ID2D1Brush*, D2D1_DRAW_TEXT_OPTIONS, DWRITE_MEASURING_MODE, void>)(lpVtbl[27]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), @string, stringLength, textFormat, layoutRect, defaultFillBrush, options, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public void DrawTextLayout([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F origin, IDWriteTextLayout* textLayout, ID2D1Brush* defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options = D2D1_DRAW_TEXT_OPTIONS_NONE)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_POINT_2F, IDWriteTextLayout*, ID2D1Brush*, D2D1_DRAW_TEXT_OPTIONS, void>)(lpVtbl[28]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), origin, textLayout, defaultFillBrush, options);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, ID2D1Brush*, DWRITE_MEASURING_MODE, void>)(lpVtbl[29]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, foregroundBrush, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[30]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[31]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_ANTIALIAS_MODE, void>)(lpVtbl[32]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), antialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public D2D1_ANTIALIAS_MODE GetAntialiasMode()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_ANTIALIAS_MODE>)(lpVtbl[33]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_TEXT_ANTIALIAS_MODE, void>)(lpVtbl[34]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), textAntialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_TEXT_ANTIALIAS_MODE>)(lpVtbl[35]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IDWriteRenderingParams*, void>)(lpVtbl[36]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IDWriteRenderingParams**, void>)(lpVtbl[37]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public void SetTags([NativeTypeName("D2D1_TAG")] ulong tag1, [NativeTypeName("D2D1_TAG")] ulong tag2)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong, ulong, void>)(lpVtbl[38]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public void GetTags([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, void>)(lpVtbl[39]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS *")] D2D1_LAYER_PARAMETERS* layerParameters, ID2D1Layer* layer)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_LAYER_PARAMETERS*, ID2D1Layer*, void>)(lpVtbl[40]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), layerParameters, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public void PopLayer()
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, void>)(lpVtbl[41]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT Flush([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, int>)(lpVtbl[42]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public void SaveDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1DrawingStateBlock*, void>)(lpVtbl[43]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public void RestoreDrawingState(ID2D1DrawingStateBlock* drawingStateBlock)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1DrawingStateBlock*, void>)(lpVtbl[44]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), drawingStateBlock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public void PushAxisAlignedClip([NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* clipRect, D2D1_ANTIALIAS_MODE antialiasMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_RECT_F*, D2D1_ANTIALIAS_MODE, void>)(lpVtbl[45]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), clipRect, antialiasMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public void PopAxisAlignedClip()
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, void>)(lpVtbl[46]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public void Clear([NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* clearColor = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, DXGI_RGBA*, void>)(lpVtbl[47]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), clearColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public void BeginDraw()
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, void>)(lpVtbl[48]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT EndDraw([NativeTypeName("D2D1_TAG *")] ulong* tag1 = null, [NativeTypeName("D2D1_TAG *")] ulong* tag2 = null)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ulong*, ulong*, int>)(lpVtbl[49]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), tag1, tag2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT result;
            return *((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*>)(lpVtbl[50]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public void SetDpi(float dpiX, float dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, float, float, void>)(lpVtbl[51]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        public void GetDpi(float* dpiX, float* dpiY)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, float*, float*, void>)(lpVtbl[52]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F result;
            return *((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_SIZE_F*, D2D_SIZE_F*>)(lpVtbl[53]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U result;
            return *((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_SIZE_U*, D2D_SIZE_U*>)(lpVtbl[54]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("UINT32")]
        public uint GetMaximumBitmapSize()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, uint>)(lpVtbl[55]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        public BOOL IsSupported([NativeTypeName("const D2D1_RENDER_TARGET_PROPERTIES *")] D2D1_RENDER_TARGET_PROPERTIES* renderTargetProperties)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_RENDER_TARGET_PROPERTIES*, int>)(lpVtbl[56]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), renderTargetProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        public HRESULT CreateBitmap([NativeTypeName("D2D1_SIZE_U")] D2D_SIZE_U size, [NativeTypeName("const void *")] void* sourceData, [NativeTypeName("UINT32")] uint pitch, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, ID2D1Bitmap1** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_SIZE_U, void*, uint, D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**, int>)(lpVtbl[57]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), size, sourceData, pitch, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        public HRESULT CreateBitmapFromWicBitmap(IWICBitmapSource* wicBitmapSource, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, ID2D1Bitmap1** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IWICBitmapSource*, D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**, int>)(lpVtbl[58]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), wicBitmapSource, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        public HRESULT CreateColorContext(D2D1_COLOR_SPACE space, [NativeTypeName("const BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize, ID2D1ColorContext** colorContext)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_COLOR_SPACE, byte*, uint, ID2D1ColorContext**, int>)(lpVtbl[59]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), space, profile, profileSize, colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        public HRESULT CreateColorContextFromFilename([NativeTypeName("PCWSTR")] ushort* filename, ID2D1ColorContext** colorContext)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ushort*, ID2D1ColorContext**, int>)(lpVtbl[60]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), filename, colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        public HRESULT CreateColorContextFromWicColorContext(IWICColorContext* wicColorContext, ID2D1ColorContext** colorContext)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IWICColorContext*, ID2D1ColorContext**, int>)(lpVtbl[61]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), wicColorContext, colorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        public HRESULT CreateBitmapFromDxgiSurface(IDXGISurface* surface, [NativeTypeName("const D2D1_BITMAP_PROPERTIES1 *")] D2D1_BITMAP_PROPERTIES1* bitmapProperties, ID2D1Bitmap1** bitmap)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, IDXGISurface*, D2D1_BITMAP_PROPERTIES1*, ID2D1Bitmap1**, int>)(lpVtbl[62]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), surface, bitmapProperties, bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        public HRESULT CreateEffect([NativeTypeName("const IID &")] Guid* effectId, ID2D1Effect** effect)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, Guid*, ID2D1Effect**, int>)(lpVtbl[63]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), effectId, effect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        public HRESULT CreateGradientStopCollection([NativeTypeName("const D2D1_GRADIENT_STOP *")] D2D1_GRADIENT_STOP* straightAlphaGradientStops, [NativeTypeName("UINT32")] uint straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, ID2D1GradientStopCollection1** gradientStopCollection1)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_GRADIENT_STOP*, uint, D2D1_COLOR_SPACE, D2D1_COLOR_SPACE, D2D1_BUFFER_PRECISION, D2D1_EXTEND_MODE, D2D1_COLOR_INTERPOLATION_MODE, ID2D1GradientStopCollection1**, int>)(lpVtbl[64]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), straightAlphaGradientStops, straightAlphaGradientStopsCount, preInterpolationSpace, postInterpolationSpace, bufferPrecision, extendMode, colorInterpolationMode, gradientStopCollection1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        public HRESULT CreateImageBrush(ID2D1Image* image, [NativeTypeName("const D2D1_IMAGE_BRUSH_PROPERTIES *")] D2D1_IMAGE_BRUSH_PROPERTIES* imageBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1ImageBrush** imageBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, D2D1_IMAGE_BRUSH_PROPERTIES*, D2D1_BRUSH_PROPERTIES*, ID2D1ImageBrush**, int>)(lpVtbl[65]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), image, imageBrushProperties, brushProperties, imageBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        public HRESULT CreateBitmapBrush(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_BITMAP_BRUSH_PROPERTIES1 *")] D2D1_BITMAP_BRUSH_PROPERTIES1* bitmapBrushProperties, [NativeTypeName("const D2D1_BRUSH_PROPERTIES *")] D2D1_BRUSH_PROPERTIES* brushProperties, ID2D1BitmapBrush1** bitmapBrush)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, D2D1_BITMAP_BRUSH_PROPERTIES1*, D2D1_BRUSH_PROPERTIES*, ID2D1BitmapBrush1**, int>)(lpVtbl[66]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), bitmap, bitmapBrushProperties, brushProperties, bitmapBrush);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        public HRESULT CreateCommandList(ID2D1CommandList** commandList)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1CommandList**, int>)(lpVtbl[67]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), commandList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        public BOOL IsDxgiFormatSupported(DXGI_FORMAT format)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, DXGI_FORMAT, int>)(lpVtbl[68]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), format);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        public BOOL IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_BUFFER_PRECISION, int>)(lpVtbl[69]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), bufferPrecision);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        public HRESULT GetImageLocalBounds(ID2D1Image* image, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* localBounds)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, D2D_RECT_F*, int>)(lpVtbl[70]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), image, localBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        public HRESULT GetImageWorldBounds(ID2D1Image* image, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* worldBounds)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, D2D_RECT_F*, int>)(lpVtbl[71]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), image, worldBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        public HRESULT GetGlyphRunWorldBounds([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* bounds)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_MEASURING_MODE, D2D_RECT_F*, int>)(lpVtbl[72]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, measuringMode, bounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public void GetDevice(ID2D1Device** device)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Device**, void>)(lpVtbl[73]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), device);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        public void SetTarget(ID2D1Image* image)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, void>)(lpVtbl[74]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), image);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public void GetTarget(ID2D1Image** image)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image**, void>)(lpVtbl[75]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), image);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        public void SetRenderingControls([NativeTypeName("const D2D1_RENDERING_CONTROLS *")] D2D1_RENDERING_CONTROLS* renderingControls)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_RENDERING_CONTROLS*, void>)(lpVtbl[76]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), renderingControls);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public void GetRenderingControls(D2D1_RENDERING_CONTROLS* renderingControls)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_RENDERING_CONTROLS*, void>)(lpVtbl[77]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), renderingControls);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        public void SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_PRIMITIVE_BLEND, void>)(lpVtbl[78]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), primitiveBlend);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        public D2D1_PRIMITIVE_BLEND GetPrimitiveBlend()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_PRIMITIVE_BLEND>)(lpVtbl[79]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(80)]
        public void SetUnitMode(D2D1_UNIT_MODE unitMode)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_UNIT_MODE, void>)(lpVtbl[80]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), unitMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(81)]
        public D2D1_UNIT_MODE GetUnitMode()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_UNIT_MODE>)(lpVtbl[81]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(82)]
        public void DrawGlyphRun([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F baselineOrigin, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, [NativeTypeName("const DWRITE_GLYPH_RUN_DESCRIPTION *")] DWRITE_GLYPH_RUN_DESCRIPTION* glyphRunDescription, ID2D1Brush* foregroundBrush, DWRITE_MEASURING_MODE measuringMode = DWRITE_MEASURING_MODE_NATURAL)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D_POINT_2F, DWRITE_GLYPH_RUN*, DWRITE_GLYPH_RUN_DESCRIPTION*, ID2D1Brush*, DWRITE_MEASURING_MODE, void>)(lpVtbl[82]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), baselineOrigin, glyphRun, glyphRunDescription, foregroundBrush, measuringMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(83)]
        public void DrawImage(ID2D1Image* image, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* imageRectangle = null, D2D1_INTERPOLATION_MODE interpolationMode = D2D1_INTERPOLATION_MODE_LINEAR, D2D1_COMPOSITE_MODE compositeMode = D2D1_COMPOSITE_MODE_SOURCE_OVER)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Image*, D2D_POINT_2F*, D2D_RECT_F*, D2D1_INTERPOLATION_MODE, D2D1_COMPOSITE_MODE, void>)(lpVtbl[83]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), image, targetOffset, imageRectangle, interpolationMode, compositeMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(84)]
        public void DrawGdiMetafile(ID2D1GdiMetafile* gdiMetafile, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* targetOffset = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1GdiMetafile*, D2D_POINT_2F*, void>)(lpVtbl[84]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), gdiMetafile, targetOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(85)]
        public void DrawBitmap(ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null, [NativeTypeName("const D2D1_MATRIX_4X4_F *")] D2D_MATRIX_4X4_F* perspectiveTransform = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, D2D_RECT_F*, float, D2D1_INTERPOLATION_MODE, D2D_RECT_F*, D2D_MATRIX_4X4_F*, void>)(lpVtbl[85]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), bitmap, destinationRectangle, opacity, interpolationMode, sourceRectangle, perspectiveTransform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(86)]
        public void PushLayer([NativeTypeName("const D2D1_LAYER_PARAMETERS1 *")] D2D1_LAYER_PARAMETERS1* layerParameters, ID2D1Layer* layer)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, D2D1_LAYER_PARAMETERS1*, ID2D1Layer*, void>)(lpVtbl[86]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), layerParameters, layer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(87)]
        public HRESULT InvalidateEffectInputRectangle(ID2D1Effect* effect, [NativeTypeName("UINT32")] uint input, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* inputRectangle)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, uint, D2D_RECT_F*, int>)(lpVtbl[87]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), effect, input, inputRectangle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(88)]
        public HRESULT GetEffectInvalidRectangleCount(ID2D1Effect* effect, [NativeTypeName("UINT32 *")] uint* rectangleCount)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, uint*, int>)(lpVtbl[88]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), effect, rectangleCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(89)]
        public HRESULT GetEffectInvalidRectangles(ID2D1Effect* effect, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* rectangles, [NativeTypeName("UINT32")] uint rectanglesCount)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, D2D_RECT_F*, uint, int>)(lpVtbl[89]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), effect, rectangles, rectanglesCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(90)]
        public HRESULT GetEffectRequiredInputRectangles(ID2D1Effect* renderEffect, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* renderImageRectangle, [NativeTypeName("const D2D1_EFFECT_INPUT_DESCRIPTION *")] D2D1_EFFECT_INPUT_DESCRIPTION* inputDescriptions, [NativeTypeName("D2D1_RECT_F *")] D2D_RECT_F* requiredInputRects, [NativeTypeName("UINT32")] uint inputCount)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Effect*, D2D_RECT_F*, D2D1_EFFECT_INPUT_DESCRIPTION*, D2D_RECT_F*, uint, int>)(lpVtbl[90]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), renderEffect, renderImageRectangle, inputDescriptions, requiredInputRects, inputCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(91)]
        public void FillOpacityMask(ID2D1Bitmap* opacityMask, ID2D1Brush* brush, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* destinationRectangle = null, [NativeTypeName("const D2D1_RECT_F *")] D2D_RECT_F* sourceRectangle = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DeviceContext*, ID2D1Bitmap*, ID2D1Brush*, D2D_RECT_F*, D2D_RECT_F*, void>)(lpVtbl[91]))((ID2D1DeviceContext*)Unsafe.AsPointer(ref this), opacityMask, brush, destinationRectangle, sourceRectangle);
        }
    }
}
