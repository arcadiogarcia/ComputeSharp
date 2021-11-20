// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("2CD906AB-12E2-11DC-9FED-001143A055F9")]
    [NativeTypeName("struct ID2D1LinearGradientBrush : ID2D1Brush")]
    [NativeInheritance("ID2D1Brush")]
    internal unsafe partial struct ID2D1LinearGradientBrush : ID2D1LinearGradientBrush.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, uint>)(lpVtbl[1]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, uint>)(lpVtbl[2]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void SetOpacity(float opacity)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, float, void>)(lpVtbl[4]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), opacity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetTransform([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[5]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public float GetOpacity()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, float>)(lpVtbl[6]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GetTransform([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* transform)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_MATRIX_3X2_F*, void>)(lpVtbl[7]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void SetStartPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_POINT_2F, void>)(lpVtbl[8]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), startPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void SetEndPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F endPoint)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_POINT_2F, void>)(lpVtbl[9]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), endPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetStartPoint()
        {
            D2D_POINT_2F result;
            return *((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_POINT_2F*, D2D_POINT_2F*>)(lpVtbl[10]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetEndPoint()
        {
            D2D_POINT_2F result;
            return *((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, D2D_POINT_2F*, D2D_POINT_2F*>)(lpVtbl[11]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), &result);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public void GetGradientStopCollection(ID2D1GradientStopCollection** gradientStopCollection)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1LinearGradientBrush*, ID2D1GradientStopCollection**, void>)(lpVtbl[12]))((ID2D1LinearGradientBrush*)Unsafe.AsPointer(ref this), gradientStopCollection);
        }

        public interface Interface : ID2D1Brush.Interface
        {
            [VtblIndex(8)]
            void SetStartPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F startPoint);

            [VtblIndex(9)]
            void SetEndPoint([NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F endPoint);

            [VtblIndex(10)]
            [return: NativeTypeName("D2D1_POINT_2F")]
            D2D_POINT_2F GetStartPoint();

            [VtblIndex(11)]
            [return: NativeTypeName("D2D1_POINT_2F")]
            D2D_POINT_2F GetEndPoint();

            [VtblIndex(12)]
            void GetGradientStopCollection(ID2D1GradientStopCollection** gradientStopCollection);
        }
    }
}
