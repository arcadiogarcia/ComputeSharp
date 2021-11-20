// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("0000000B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IStorage : IUnknown")]
    [NativeInheritance("IUnknown")]
    internal unsafe partial struct IStorage : IStorage.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, Guid*, void**, int>)(lpVtbl[0]))((IStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, uint>)(lpVtbl[1]))((IStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, uint>)(lpVtbl[2]))((IStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateStream([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, IStream** ppstm)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, ushort*, uint, uint, uint, IStream**, int>)(lpVtbl[3]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, reserved1, reserved2, ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OpenStream([NativeTypeName("const OLECHAR *")] ushort* pwcsName, void* reserved1, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved2, IStream** ppstm)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, ushort*, void*, uint, uint, IStream**, int>)(lpVtbl[4]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, reserved1, grfMode, reserved2, ppstm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateStorage([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, IStorage** ppstg)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, ushort*, uint, uint, uint, IStorage**, int>)(lpVtbl[5]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, reserved1, reserved2, ppstg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OpenStorage([NativeTypeName("const OLECHAR *")] ushort* pwcsName, IStorage* pstgPriority, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("DWORD")] uint reserved, IStorage** ppstg)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, ushort*, IStorage*, uint, ushort**, uint, IStorage**, int>)(lpVtbl[6]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT CopyTo([NativeTypeName("DWORD")] uint ciidExclude, [NativeTypeName("const IID *")] Guid* rgiidExclude, [NativeTypeName("SNB")] ushort** snbExclude, IStorage* pstgDest)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, uint, Guid*, ushort**, IStorage*, int>)(lpVtbl[7]))((IStorage*)Unsafe.AsPointer(ref this), ciidExclude, rgiidExclude, snbExclude, pstgDest);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT MoveElementTo([NativeTypeName("const OLECHAR *")] ushort* pwcsName, IStorage* pstgDest, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName, [NativeTypeName("DWORD")] uint grfFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, ushort*, IStorage*, ushort*, uint, int>)(lpVtbl[8]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pstgDest, pwcsNewName, grfFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, uint, int>)(lpVtbl[9]))((IStorage*)Unsafe.AsPointer(ref this), grfCommitFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Revert()
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, int>)(lpVtbl[10]))((IStorage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT EnumElements([NativeTypeName("DWORD")] uint reserved1, void* reserved2, [NativeTypeName("DWORD")] uint reserved3, IEnumSTATSTG** ppenum)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, uint, void*, uint, IEnumSTATSTG**, int>)(lpVtbl[11]))((IStorage*)Unsafe.AsPointer(ref this), reserved1, reserved2, reserved3, ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT DestroyElement([NativeTypeName("const OLECHAR *")] ushort* pwcsName)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, ushort*, int>)(lpVtbl[12]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT RenameElement([NativeTypeName("const OLECHAR *")] ushort* pwcsOldName, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, ushort*, ushort*, int>)(lpVtbl[13]))((IStorage*)Unsafe.AsPointer(ref this), pwcsOldName, pwcsNewName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT SetElementTimes([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, ushort*, FILETIME*, FILETIME*, FILETIME*, int>)(lpVtbl[14]))((IStorage*)Unsafe.AsPointer(ref this), pwcsName, pctime, patime, pmtime);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetClass([NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, Guid*, int>)(lpVtbl[15]))((IStorage*)Unsafe.AsPointer(ref this), clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT SetStateBits([NativeTypeName("DWORD")] uint grfStateBits, [NativeTypeName("DWORD")] uint grfMask)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, uint, uint, int>)(lpVtbl[16]))((IStorage*)Unsafe.AsPointer(ref this), grfStateBits, grfMask);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
        {
            return ((delegate* unmanaged[Stdcall]<IStorage*, STATSTG*, uint, int>)(lpVtbl[17]))((IStorage*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateStream([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, IStream** ppstm);

            [VtblIndex(4)]
            HRESULT OpenStream([NativeTypeName("const OLECHAR *")] ushort* pwcsName, void* reserved1, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved2, IStream** ppstm);

            [VtblIndex(5)]
            HRESULT CreateStorage([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint reserved1, [NativeTypeName("DWORD")] uint reserved2, IStorage** ppstg);

            [VtblIndex(6)]
            HRESULT OpenStorage([NativeTypeName("const OLECHAR *")] ushort* pwcsName, IStorage* pstgPriority, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("SNB")] ushort** snbExclude, [NativeTypeName("DWORD")] uint reserved, IStorage** ppstg);

            [VtblIndex(7)]
            HRESULT CopyTo([NativeTypeName("DWORD")] uint ciidExclude, [NativeTypeName("const IID *")] Guid* rgiidExclude, [NativeTypeName("SNB")] ushort** snbExclude, IStorage* pstgDest);

            [VtblIndex(8)]
            HRESULT MoveElementTo([NativeTypeName("const OLECHAR *")] ushort* pwcsName, IStorage* pstgDest, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName, [NativeTypeName("DWORD")] uint grfFlags);

            [VtblIndex(9)]
            HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags);

            [VtblIndex(10)]
            HRESULT Revert();

            [VtblIndex(11)]
            HRESULT EnumElements([NativeTypeName("DWORD")] uint reserved1, void* reserved2, [NativeTypeName("DWORD")] uint reserved3, IEnumSTATSTG** ppenum);

            [VtblIndex(12)]
            HRESULT DestroyElement([NativeTypeName("const OLECHAR *")] ushort* pwcsName);

            [VtblIndex(13)]
            HRESULT RenameElement([NativeTypeName("const OLECHAR *")] ushort* pwcsOldName, [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName);

            [VtblIndex(14)]
            HRESULT SetElementTimes([NativeTypeName("const OLECHAR *")] ushort* pwcsName, [NativeTypeName("const FILETIME *")] FILETIME* pctime, [NativeTypeName("const FILETIME *")] FILETIME* patime, [NativeTypeName("const FILETIME *")] FILETIME* pmtime);

            [VtblIndex(15)]
            HRESULT SetClass([NativeTypeName("const IID &")] Guid* clsid);

            [VtblIndex(16)]
            HRESULT SetStateBits([NativeTypeName("DWORD")] uint grfStateBits, [NativeTypeName("DWORD")] uint grfMask);

            [VtblIndex(17)]
            HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag);
        }
    }
}
