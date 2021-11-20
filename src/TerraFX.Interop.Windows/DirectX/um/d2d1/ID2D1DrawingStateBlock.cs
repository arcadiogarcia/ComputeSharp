// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("28506E39-EBF6-46A1-BB47-FD85565AB957")]
    [NativeTypeName("struct ID2D1DrawingStateBlock : ID2D1Resource")]
    [NativeInheritance("ID2D1Resource")]
    internal unsafe partial struct ID2D1DrawingStateBlock : ID2D1DrawingStateBlock.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, uint>)(lpVtbl[1]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, uint>)(lpVtbl[2]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(lpVtbl[4]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), stateDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, D2D1_DRAWING_STATE_DESCRIPTION*, void>)(lpVtbl[5]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), stateDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, IDWriteRenderingParams*, void>)(lpVtbl[6]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, IDWriteRenderingParams**, void>)(lpVtbl[7]))((ID2D1DrawingStateBlock*)Unsafe.AsPointer(ref this), textRenderingParams);
        }

        public interface Interface : ID2D1Resource.Interface
        {
            [VtblIndex(4)]
            void GetDescription(D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

            [VtblIndex(5)]
            void SetDescription([NativeTypeName("const D2D1_DRAWING_STATE_DESCRIPTION *")] D2D1_DRAWING_STATE_DESCRIPTION* stateDescription);

            [VtblIndex(6)]
            void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams = null);

            [VtblIndex(7)]
            void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams);
        }
    }
}
