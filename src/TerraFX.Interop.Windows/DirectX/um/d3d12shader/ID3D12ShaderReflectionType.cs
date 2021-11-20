// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("E913C351-783D-48CA-A1D1-4F306284AD56")]
    internal unsafe partial struct ID3D12ShaderReflectionType
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT GetDesc(D3D12_SHADER_TYPE_DESC* pDesc)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, D3D12_SHADER_TYPE_DESC*, int>)(lpVtbl[0]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        public ID3D12ShaderReflectionType* GetMemberTypeByIndex(uint Index)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)(lpVtbl[1]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        public ID3D12ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, sbyte*, ID3D12ShaderReflectionType*>)(lpVtbl[2]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("LPCSTR")]
        public sbyte* GetMemberTypeName(uint Index)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, sbyte*>)(lpVtbl[3]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT IsEqual(ID3D12ShaderReflectionType* pType)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)(lpVtbl[4]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D12ShaderReflectionType* GetSubType()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)(lpVtbl[5]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public ID3D12ShaderReflectionType* GetBaseClass()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*>)(lpVtbl[6]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public uint GetNumInterfaces()
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint>)(lpVtbl[7]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public ID3D12ShaderReflectionType* GetInterfaceByIndex(uint uIndex)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, uint, ID3D12ShaderReflectionType*>)(lpVtbl[8]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), uIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT IsOfType(ID3D12ShaderReflectionType* pType)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)(lpVtbl[9]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT ImplementsInterface(ID3D12ShaderReflectionType* pBase)
        {
            return ((delegate* unmanaged[Stdcall]<ID3D12ShaderReflectionType*, ID3D12ShaderReflectionType*, int>)(lpVtbl[10]))((ID3D12ShaderReflectionType*)Unsafe.AsPointer(ref this), pBase);
        }

        public interface Interface
        {
            [VtblIndex(0)]
            HRESULT GetDesc(D3D12_SHADER_TYPE_DESC* pDesc);

            [VtblIndex(1)]
            ID3D12ShaderReflectionType* GetMemberTypeByIndex(uint Index);

            [VtblIndex(2)]
            ID3D12ShaderReflectionType* GetMemberTypeByName([NativeTypeName("LPCSTR")] sbyte* Name);

            [VtblIndex(3)]
            [return: NativeTypeName("LPCSTR")]
            sbyte* GetMemberTypeName(uint Index);

            [VtblIndex(4)]
            HRESULT IsEqual(ID3D12ShaderReflectionType* pType);

            [VtblIndex(5)]
            ID3D12ShaderReflectionType* GetSubType();

            [VtblIndex(6)]
            ID3D12ShaderReflectionType* GetBaseClass();

            [VtblIndex(7)]
            uint GetNumInterfaces();

            [VtblIndex(8)]
            ID3D12ShaderReflectionType* GetInterfaceByIndex(uint uIndex);

            [VtblIndex(9)]
            HRESULT IsOfType(ID3D12ShaderReflectionType* pType);

            [VtblIndex(10)]
            HRESULT ImplementsInterface(ID3D12ShaderReflectionType* pBase);
        }
    }
}
