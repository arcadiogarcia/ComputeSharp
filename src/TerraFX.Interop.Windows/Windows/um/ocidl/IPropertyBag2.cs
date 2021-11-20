// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("22F55882-280B-11D0-A8A9-00A0C90C2004")]
    [NativeTypeName("struct IPropertyBag2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    internal unsafe partial struct IPropertyBag2 : IPropertyBag2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyBag2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint>)(lpVtbl[1]))((IPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint>)(lpVtbl[2]))((IPropertyBag2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Read([NativeTypeName("ULONG")] uint cProperties, PROPBAG2* pPropBag, IErrorLog* pErrLog, VARIANT* pvarValue, HRESULT* phrError)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint, PROPBAG2*, IErrorLog*, VARIANT*, HRESULT*, int>)(lpVtbl[3]))((IPropertyBag2*)Unsafe.AsPointer(ref this), cProperties, pPropBag, pErrLog, pvarValue, phrError);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Write([NativeTypeName("ULONG")] uint cProperties, PROPBAG2* pPropBag, VARIANT* pvarValue)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint, PROPBAG2*, VARIANT*, int>)(lpVtbl[4]))((IPropertyBag2*)Unsafe.AsPointer(ref this), cProperties, pPropBag, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CountProperties([NativeTypeName("ULONG *")] uint* pcProperties)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint*, int>)(lpVtbl[5]))((IPropertyBag2*)Unsafe.AsPointer(ref this), pcProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPropertyInfo([NativeTypeName("ULONG")] uint iProperty, [NativeTypeName("ULONG")] uint cProperties, PROPBAG2* pPropBag, [NativeTypeName("ULONG *")] uint* pcProperties)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, uint, uint, PROPBAG2*, uint*, int>)(lpVtbl[6]))((IPropertyBag2*)Unsafe.AsPointer(ref this), iProperty, cProperties, pPropBag, pcProperties);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT LoadObject([NativeTypeName("LPCOLESTR")] ushort* pstrName, [NativeTypeName("DWORD")] uint dwHint, IUnknown* pUnkObject, IErrorLog* pErrLog)
        {
            return ((delegate* unmanaged[Stdcall]<IPropertyBag2*, ushort*, uint, IUnknown*, IErrorLog*, int>)(lpVtbl[7]))((IPropertyBag2*)Unsafe.AsPointer(ref this), pstrName, dwHint, pUnkObject, pErrLog);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Read([NativeTypeName("ULONG")] uint cProperties, PROPBAG2* pPropBag, IErrorLog* pErrLog, VARIANT* pvarValue, HRESULT* phrError);

            [VtblIndex(4)]
            HRESULT Write([NativeTypeName("ULONG")] uint cProperties, PROPBAG2* pPropBag, VARIANT* pvarValue);

            [VtblIndex(5)]
            HRESULT CountProperties([NativeTypeName("ULONG *")] uint* pcProperties);

            [VtblIndex(6)]
            HRESULT GetPropertyInfo([NativeTypeName("ULONG")] uint iProperty, [NativeTypeName("ULONG")] uint cProperties, PROPBAG2* pPropBag, [NativeTypeName("ULONG *")] uint* pcProperties);

            [VtblIndex(7)]
            HRESULT LoadObject([NativeTypeName("LPCOLESTR")] ushort* pstrName, [NativeTypeName("DWORD")] uint dwHint, IUnknown* pUnkObject, IErrorLog* pErrLog);
        }
    }
}
