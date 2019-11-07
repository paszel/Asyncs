## .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), X64 RyuJIT
```assembly
; Asynchronic.BenchmarkTest.PlaneUsage()
       mov     eax,4
       ret
       add     byte ptr [rax],al
       sbb     dword ptr [rax],eax
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],al
       add     byte ptr [rax],ch
       ???
       xlat    byte ptr [rbx]
       push    rdi
       inc     byte ptr [rdi]
       add     byte ptr [rax],al
       ret
       add     byte ptr [rax],al
       add     byte ptr [rcx],bl
; Total bytes of code 37
```
**No ILOffsetMap found**
Asynchronic.BenchmarkTest.TwoPlusTwo()

## .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), X64 RyuJIT
```assembly
; Asynchronic.BenchmarkTest.ExecuteOnThreadPool()
       IL_0000: newobj System.Void Asynchronic.BenchmarkTest/<>c__DisplayClass1_0::.ctor()
       mov     rcx,7FE57DB52B8h
       call    coreclr!GC_Initialize+0x42720
       mov     rsi,rax
       IL_0005: dup
       IL_0006: ldc.i4.0
       IL_0007: newobj System.Void System.Threading.AutoResetEvent::.ctor(System.Boolean)
       mov     rcx,offset System_Private_CoreLib+0xa72f88
       call    coreclr!GC_Initialize+0x42720
       mov     rdi,rax
       mov     rcx,rdi
       xor     edx,edx
       xor     r8d,r8d
       xor     r9d,r9d
       call    System.Threading.EventWaitHandle..ctor(Boolean, System.Threading.EventResetMode, System.String)
       IL_000c: stfld System.Threading.AutoResetEvent Asynchronic.BenchmarkTest/<>c__DisplayClass1_0::autoEvent
       IL_0011: dup
       IL_0012: ldc.i4.0
       IL_0013: stfld System.Int32 Asynchronic.BenchmarkTest/<>c__DisplayClass1_0::result
       IL_0018: dup
       IL_0019: ldftn System.Void Asynchronic.BenchmarkTest/<>c__DisplayClass1_0::<ExecuteOnThreadPool>b__0(System.Object)
       IL_001f: newobj System.Void System.Threading.WaitCallback::.ctor(System.Object,System.IntPtr)
       IL_0024: call System.Boolean System.Threading.ThreadPool::QueueUserWorkItem(System.Threading.WaitCallback)
       IL_0029: pop
       IL_002a: dup
       IL_002b: ldfld System.Threading.AutoResetEvent Asynchronic.BenchmarkTest/<>c__DisplayClass1_0::autoEvent
       IL_0030: ldc.i4 2000
       IL_0035: callvirt System.Boolean System.Threading.WaitHandle::WaitOne(System.Int32)
       IL_003a: pop
       IL_003b: dup
       IL_003c: ldfld System.Threading.AutoResetEvent Asynchronic.BenchmarkTest/<>c__DisplayClass1_0::autoEvent
       IL_0041: callvirt System.Void System.Threading.WaitHandle::Close()
       lea     rcx,[rsi+8]
       mov     rdx,rdi
       call    coreclr!GC_Initialize+0x41280
       xor     ecx,ecx
       mov     dword ptr [rsi+10h],ecx
       mov     rcx,offset System_Private_CoreLib+0xa1e930
       call    coreclr!GC_Initialize+0x42720
       mov     rdi,rax
       lea     rcx,[rdi+8]
       mov     rdx,rsi
       call    coreclr!GC_Initialize+0x41280
       mov     rcx,7FE57C629B8h
       mov     qword ptr [rdi+18h],rcx
       mov     rcx,rdi
       xor     edx,edx
       call    System.Threading.ThreadPool.QueueUserWorkItem(System.Threading.WaitCallback, System.Object)
       mov     rcx,qword ptr [rsi+8]
       mov     r8d,dword ptr [rcx]
       movzx   r8d,byte ptr [rcx+18h]
       mov     rcx,qword ptr [rcx+8]
       mov     edx,7D0h
       xor     r9d,r9d
       call    System.Threading.WaitHandle.InternalWaitOne(System.Runtime.InteropServices.SafeHandle, Int64, Boolean, Boolean)
       mov     rdi,qword ptr [rsi+8]
       cmp     qword ptr [rdi+8],0
       je      M00_L00
       mov     rcx,qword ptr [rdi+8]
       mov     eax,dword ptr [rcx]
       call    System.Runtime.InteropServices.SafeHandle.InternalDispose()
M00_L00:
       mov     rcx,rdi
       call    System.GC.SuppressFinalize(System.Object)
       IL_0046: ldfld System.Int32 Asynchronic.BenchmarkTest/<>c__DisplayClass1_0::result
       IL_004b: ret
       mov     eax,dword ptr [rsi+10h]
; Total bytes of code 185
```
```assembly
; System.Threading.EventWaitHandle..ctor(Boolean, System.Threading.EventResetMode, System.String)
       IL_0000: ldarg.0
       IL_0001: call System.Void System.Threading.WaitHandle::.ctor()
       xor     ecx,ecx
       mov     qword ptr [rsi+8],rcx
       mov     rcx,qword ptr [System_Private_CoreLib+0x1548
       mov     edx,324h
       call    System_Private_CoreLib+0x2d40a0
       mov     r8,qword ptr [rax+8A8h]
       mov     qword ptr [rsi+10h],r8
       mov     byte ptr [rsi+18h],0
       IL_0006: ldarg.3
       IL_0007: brfalse.s IL_0036
       test    rdi,rdi
       je      System_Private_CoreLib+0x75cfa3
       IL_0009: ldc.i4 260
       IL_000e: ldarg.3
       IL_000f: callvirt System.Int32 System.String::get_Length()
       IL_0014: bge.s IL_0036
       IL_0016: call System.String System.SR::get_Argument_WaitHandleNameTooLong()
       IL_001b: ldarg.3
       IL_001c: ldc.i4 260
       IL_0021: box System.Int32
       IL_0026: call System.String System.SR::Format(System.String,System.Object,System.Object)
       IL_002b: ldstr "name"
       IL_0030: newobj System.Void System.ArgumentException::.ctor(System.String,System.String)
       cmp     dword ptr [rdi+8],104h
       jg      System_Private_CoreLib+0xb502f4
       IL_0036: ldarg.1
       IL_0037: brtrue.s IL_003c
       test    r14b,r14b
       jne     System_Private_CoreLib+0x75cfad
       IL_0039: ldc.i4.0
       IL_003a: br.s IL_003d
       xor     r8d,r8d
       jmp     System_Private_CoreLib+0x75cfb3
       IL_003c: ldc.i4.2
       IL_003d: stloc.0
       mov     r8d,2
       IL_003e: ldarg.2
       IL_003f: brfalse.s IL_005c
       test    ebx,ebx
       je      System_Private_CoreLib+0x75cfc4
       IL_0041: ldarg.2
       IL_0042: ldc.i4.1
       IL_0043: bne.un.s IL_004b
       cmp     ebx,1
       jne     System_Private_CoreLib+0xb50361
       IL_0045: ldloc.0
       IL_0046: ldc.i4.1
       IL_0047: or
       IL_0048: stloc.0
       IL_0049: br.s IL_005c
       IL_004b: call System.String System.SR::get_Argument_InvalidFlag()
       IL_0050: ldarg.3
       IL_0051: call System.String System.SR::Format(System.String,System.Object)
       IL_0056: newobj System.Void System.ArgumentException::.ctor(System.String)
       or      r8d,1
       IL_005c: ldnull
       IL_005d: ldarg.3
       IL_005e: ldloc.0
       IL_005f: ldc.i4 34603010
       IL_0064: call Microsoft.Win32.SafeHandles.SafeWaitHandle Microsoft.Win32.Win32Native::CreateEventEx(Microsoft.Win32.Win32Native/SECURITY_ATTRIBUTES,System.String,System.UInt32,System.UInt32)
       IL_0069: stloc.1
       mov     rdx,rdi
       xor     ecx,ecx
       mov     r9d,2100002h
       call    Microsoft.Win32.Win32Native.CreateEventEx(SECURITY_ATTRIBUTES, System.String, UInt32, UInt32)
       mov     rbx,rax
       IL_006a: ldloc.1
       IL_006b: callvirt System.Boolean System.Runtime.InteropServices.SafeHandle::get_IsInvalid()
       IL_0070: brfalse.s IL_00a6
       mov     rcx,rbx
       cmp     dword ptr [rcx],ecx
       call    Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test    eax,eax
       jne     System_Private_CoreLib+0xb503a2
       IL_00a6: ldarg.0
       IL_00a7: ldloc.1
       IL_00a8: call System.Void System.Threading.WaitHandle::SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle)
       lea     rcx,[rsi+8]
       mov     rdx,rbx
       call    System_Private_CoreLib+0x2d4010
       mov     rcx,qword ptr [rbx+8]
       mov     qword ptr [rsi+10h],rcx
       IL_00ad: ret
       lea     rsp,[rbp-20h]
       pop     rbx
       pop     rsi
       pop     rdi
       pop     r14
       pop     rbp
       ret
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       sub     rsp,38h
       nop
       mov     rax,qword ptr [rsp+60h]
       mov     qword ptr [rsp+20h],rax
       xor     eax,eax
       mov     qword ptr [rsp+28h],rax
       movzx   edx,dl
       call    System.Threading.EventWaitHandle..ctor(Boolean, System.Threading.EventResetMode, System.String, Boolean ByRef, System.Security.AccessControl.EventWaitHandleSecurity)
       nop
       add     rsp,38h
       ret
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       push    rbp
       push    r14
       push    rdi
       push    rsi
       push    rbx
       sub     rsp,20h
       lea     rbp,[rsp+40h]
       mov     rsi,rcx
       mov     r14d,edx
       mov     ebx,r8d
       mov     rdi,r9
       xor     ecx,ecx
       mov     qword ptr [rsi+8],rcx
       mov     rcx,qword ptr [System_Private_CoreLib+0x1548
       mov     edx,324h
       IL_0035: throw
       call    System_Private_CoreLib+0x2d40a0
       mov     rcx,qword ptr [rax+8A8h]
       mov     qword ptr [rsi+10h],rcx
       mov     byte ptr [rsi+18h],0
       test    rdi,rdi
       je      System_Private_CoreLib+0x75d093
       cmp     dword ptr [rdi+8],104h
       jg      System_Private_CoreLib+0xb50418
       test    r14b,r14b
       jne     System_Private_CoreLib+0x75d09c
       xor     ecx,ecx
       jmp     System_Private_CoreLib+0x75d0a1
       mov     ecx,2
       mov     r8d,ecx
       test    ebx,ebx
       je      System_Private_CoreLib+0x75d0b5
       cmp     ebx,1
       jne     System_Private_CoreLib+0xb50485
       IL_005b: throw
       xor     edi,dword ptr [rdi]
       add     byte ptr [rcx-7Dh],al
       enter   3301h,0C9h
       IL_0072: call System.Int32 System.Runtime.InteropServices.Marshal::GetLastWin32Error()
       IL_0077: stloc.2
       leave
       mov     rdx,rdi
       mov     r9d,2100002h
       IL_0078: ldloc.1
       IL_0079: callvirt System.Void System.Runtime.InteropServices.SafeHandle::SetHandleAsInvalid()
       add     byte ptr [rax],dl
       add     ch,al
       pop     rbx
       jp      System_Private_CoreLib+0x75d07e
       dec     dword ptr [rax-75h]
       IL_007e: ldarg.3
       IL_007f: brfalse.s IL_009e
       mov     rbx,rax
       call    System.Runtime.InteropServices.Marshal.GetLastWin32Error()
       IL_0081: ldarg.3
       IL_0082: callvirt System.Int32 System.String::get_Length()
       IL_0087: brfalse.s IL_009e
       pop     rbp
       mov     edx,0F08B44FFh
       IL_0089: ldc.i4.6
       IL_008a: ldloc.2
       IL_008b: bne.un.s IL_009e
       IL_008d: call System.String System.SR::get_Threading_WaitHandleCannotBeOpenedException_InvalidHandle()
       IL_0092: ldarg.3
       IL_0093: call System.String System.SR::Format(System.String,System.Object)
       IL_0098: newobj System.Void System.Threading.WaitHandleCannotBeOpenedException::.ctor(System.String)
       mov     rcx,rbx
       cmp     dword ptr [rcx],ecx
       call    Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test    eax,eax
       jne     System_Private_CoreLib+0xb504c6
       cmp     r14d,0B7h
       setne   dl
       mov     rdi,qword ptr [rbp+30h]
       mov     byte ptr [rdi],dl
       lea     rcx,[rsi+8]
       mov     rdx,rbx
       call    System_Private_CoreLib+0x2d4010
       mov     rcx,qword ptr [rbx+8]
       mov     qword ptr [rsi+10h],rcx
       lea     rsp,[rbp-20h]
       pop     rbx
       pop     rsi
       pop     rdi
       pop     r14
       IL_009d: throw
       pop     rsi
       pop     rbp
       ret
       int     3
       int     3
       int     3
       int     3
       int     3
       IL_009e: ldloc.2
       IL_009f: ldarg.3
       IL_00a0: call System.Exception System.IO.Win32Marshal::GetExceptionForWin32Error(System.Int32,System.String)
       IL_00a5: throw
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       push    rdi
       push    rsi
       sub     rsp,28h
       mov     rsi,rcx
       mov     rdi,rdx
       xor     ecx,ecx
       mov     qword ptr [rsi+8],rcx
       mov     rcx,qword ptr [System_Private_CoreLib+0x1548
; Total bytes of code 475
```
```assembly
; System.Threading.ThreadPool.QueueUserWorkItem(System.Threading.WaitCallback, System.Object)
       IL_0000: ldarg.0
       IL_0001: brtrue.s IL_000a
       test    rsi,rsi
       je      System_Private_CoreLib+0xb4f630
       IL_000a: call System.Void System.Threading.ThreadPool::EnsureVMInitialized()
       IL_000f: call System.Threading.ExecutionContext System.Threading.ExecutionContext::Capture()
       IL_0014: stloc.0
       mov     rbx,qword ptr [System_Private_CoreLib+0x1548
       mov     rcx,rbx
       mov     edx,302h
       call    System_Private_CoreLib+0x2d40a0
       cmp     byte ptr [rax+8A0h],0
       jne     System_Private_CoreLib+0x74f1fb
       call    System.Threading.ThreadPool.EnsureVMInitializedCore()
       call    System.Threading.ExecutionContext.Capture()
       mov     rbp,rax
       IL_0015: ldloc.0
       IL_0016: brfalse.s IL_0020
       IL_0018: ldloc.0
       IL_0019: callvirt System.Boolean System.Threading.ExecutionContext::get_IsDefault()
       IL_001e: brtrue.s IL_002c
       test    rbp,rbp
       je      System_Private_CoreLib+0x74f20e
       cmp     byte ptr [rbp+19h],0
       jne     System_Private_CoreLib+0x74f243
       IL_0020: ldarg.0
       IL_0021: ldarg.1
       IL_0022: ldloc.0
       IL_0023: newobj System.Void System.Threading.QueueUserWorkItemCallback::.ctor(System.Threading.WaitCallback,System.Object,System.Threading.ExecutionContext)
       IL_0028: stloc.2
       lea     rcx,[System_Private_CoreLib+0xa72240
       call    System_Private_CoreLib+0x2d4080
       mov     r14,rax
       lea     rcx,[r14+8]
       mov     rdx,rsi
       call    System_Private_CoreLib+0x2d4010
       lea     rcx,[r14+10h]
       mov     rdx,rdi
       call    System_Private_CoreLib+0x2d4010
       lea     rcx,[r14+18h]
       mov     rdx,rbp
       call    System_Private_CoreLib+0x2d4010
       IL_0029: ldloc.2
       IL_002a: br.s IL_0035
       jmp     System_Private_CoreLib+0x74f26a
       IL_002c: ldarg.0
       IL_002d: ldarg.1
       IL_002e: newobj System.Void System.Threading.QueueUserWorkItemCallbackDefaultContext::.ctor(System.Threading.WaitCallback,System.Object)
       IL_0033: stloc.2
       IL_0034: ldloc.2
       IL_0035: stloc.1
       lea     rcx,[System_Private_CoreLib+0xa723c8
       call    System_Private_CoreLib+0x2d4080
       mov     r14,rax
       lea     rcx,[r14+8]
       mov     rdx,rsi
       call    System_Private_CoreLib+0x2d4010
       lea     rcx,[r14+10h]
       mov     rdx,rdi
       call    System_Private_CoreLib+0x2d4010
       IL_0036: ldsfld System.Threading.ThreadPoolWorkQueue System.Threading.ThreadPoolGlobals::workQueue
       IL_003b: ldloc.1
       IL_003c: ldc.i4.1
       IL_003d: callvirt System.Void System.Threading.ThreadPoolWorkQueue::Enqueue(System.Threading.IThreadPoolWorkItem,System.Boolean)
       mov     rcx,rbx
       mov     edx,302h
       call    System_Private_CoreLib+0x2d4088
       mov     rcx,qword ptr [rax+7D8h]
       mov     rdx,r14
       mov     r8d,1
       cmp     dword ptr [rcx],ecx
       call    System.Threading.ThreadPoolWorkQueue.Enqueue(System.Threading.IThreadPoolWorkItem, Boolean)
       IL_0042: ldc.i4.1
       IL_0043: ret
       mov     eax,1
       add     rsp,20h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       ret
       IL_0003: ldc.i4.s 64
       IL_0005: call System.Void System.ThrowHelper::ThrowArgumentNullException(System.ExceptionArgument)
       int     3
       int     3
       push    r15
       push    r14
       push    r12
       push    rdi
       push    rsi
       push    rbp
       push    rbx
       sub     rsp,30h
       mov     qword ptr [rsp+28h],rcx
       mov     rbp,rcx
       mov     rsi,rdx
       mov     rdi,r8
       mov     ebx,r9d
; Total bytes of code 239
```
```assembly
; System.Threading.WaitHandle.InternalWaitOne(System.Runtime.InteropServices.SafeHandle, Int64, Boolean, Boolean)
       IL_0000: ldarg.0
       IL_0001: brtrue.s IL_000f
       IL_0003: ldnull
       IL_0004: call System.String System.SR::get_ObjectDisposed_Generic()
       IL_0009: newobj System.Void System.ObjectDisposedException::.ctor(System.String,System.String)
       test    rcx,rcx
       je      System_Private_CoreLib+0xb52860
       IL_000f: ldarg.0
       IL_0010: ldarg.1
       IL_0011: conv.u4
       IL_0012: ldarg.2
       IL_0013: ldarg.3
       IL_0014: call System.Int32 System.Threading.WaitHandle::WaitOneNative(System.Runtime.InteropServices.SafeHandle,System.UInt32,System.Boolean,System.Boolean)
       IL_0019: stloc.0
       movzx   r8d,r8b
       movzx   r9d,r9b
       call    System.Threading.WaitHandle.WaitOneNative(System.Runtime.InteropServices.SafeHandle, UInt32, Boolean, Boolean)
       IL_001a: ldloc.0
       IL_001b: ldc.i4 128
       IL_0020: bne.un.s IL_0027
       cmp     eax,80h
       je      System_Private_CoreLib+0xb52898
       IL_0027: ldloc.0
       IL_0028: ldc.i4 258
       IL_002d: ceq
       IL_002f: ldc.i4.0
       IL_0030: ceq
       IL_0032: ret
       cmp     eax,102h
       setne   al
       movzx   eax,al
       add     rsp,20h
       pop     rsi
       ret
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       push    rsi
       sub     rsp,20h
       cmp     qword ptr [rcx+8],0
       je      System_Private_CoreLib+0xb528a0
       movzx   r8d,byte ptr [rcx+18h]
       mov     rcx,qword ptr [rcx+8]
       mov     edx,0FFFFFFFFh
       xor     r9d,r9d
       call    System.Threading.WaitHandle.WaitOneNative(System.Runtime.InteropServices.SafeHandle, UInt32, Boolean, Boolean)
       cmp     eax,80h
       IL_000e: throw
       add     byte ptr [rax],0
       add     byte ptr [rdi],cl
       test    byte ptr [rdi],dh
       cmp     eax,1023D00h
       IL_0022: call System.Void System.Threading.WaitHandle::ThrowAbandonedMutexException()
       cmp     eax,1023D00h
       add     byte ptr [rax],al
       setne   al
       movzx   eax,al
       add     rsp,20h
       pop     rsi
       ret
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
; Total bytes of code 147
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       IL_0000: ldarg.0
       IL_0001: brtrue.s IL_000e
       test    rcx,rcx
       je      System_Private_CoreLib+0xb4378c
       IL_000e: ldarg.0
       IL_000f: call System.Void System.GC::_SuppressFinalize(System.Object)
       IL_0014: ret
       lea     rax,[System_Private_CoreLib+0x303c98
       add     rsp,20h
       pop     rsi
       jmp     rax
       IL_0003: ldstr "obj"
       IL_0008: newobj System.Void System.ArgumentNullException::.ctor(System.String)
       int     3
       int     3
       int     3
       push    rsi
       sub     rsp,20h
       test    rcx,rcx
       je      System_Private_CoreLib+0xb437bc
       lea     rax,[System_Private_CoreLib+0x303ca8
       add     rsp,20h
       pop     rsi
       jmp     rax
       int     3
       int     3
       int     3
       push    rbp
       IL_000d: throw
       push    r15
       push    r14
       push    r13
       push    r12
       push    rdi
       push    rsi
       push    rbx
       sub     rsp,68h
       lea     rbp,[rsp+0A0h]
       mov     esi,ecx
       lea     rcx,[rbp-70h]
       mov     rdx,r10
; Total bytes of code 92
```
```assembly
; System.Threading.AutoResetEvent..ctor(Boolean)
       IL_0000: ldarg.0
       IL_0001: ldarg.1
       IL_0002: ldc.i4.0
       IL_0003: call System.Void System.Threading.EventWaitHandle::.ctor(System.Boolean,System.Threading.EventResetMode)
       IL_0008: ret
       movzx   edx,dl
       xor     r8d,r8d
       xor     r9d,r9d
       lea     rax,[System_Private_CoreLib+0x75cf50
; Total bytes of code 16
```
```assembly
; Asynchronic.BenchmarkTest+<>c__DisplayClass1_0.<ExecuteOnThreadPool>b__0(System.Object)
       IL_0017: ret
       nop
; Total bytes of code 1
```
```assembly
; System.Threading.WaitHandle.WaitOne(Int32)
       IL_0000: ldarg.0
       IL_0001: ldarg.1
       IL_0002: ldc.i4.0
       IL_0003: callvirt System.Boolean System.Threading.WaitHandle::WaitOne(System.Int32,System.Boolean)
       IL_0008: ret
       xor     r8d,r8d
       mov     rax,qword ptr [rcx]
       mov     rax,qword ptr [rax+40h]
       mov     rax,qword ptr [rax+38h]
; Total bytes of code 14
```
```assembly
; System.Threading.WaitHandle.Close()
       IL_0000: ldarg.0
       IL_0001: ldc.i4.1
       IL_0002: callvirt System.Void System.Threading.WaitHandle::Dispose(System.Boolean)
       mov     rcx,rsi
       mov     edx,1
       mov     rax,qword ptr [rsi]
       mov     rax,qword ptr [rax+48h]
       call    qword ptr [rax+28h]
       IL_0007: ldarg.0
       IL_0008: call System.Void System.GC::SuppressFinalize(System.Object)
       IL_000d: ret
       mov     rcx,rsi
       lea     rax,[System_Private_CoreLib+0x6c8390
; Total bytes of code 28
```
**No ILOffsetMap found**
System.Runtime.InteropServices.SafeHandle.InternalDispose()
Asynchronic.BenchmarkTest+<>c__DisplayClass1_0..ctor()

## .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), X64 RyuJIT
```assembly
; Asynchronic.BenchmarkTest.ExecuteOnTask()
       IL_0000: newobj System.Void Asynchronic.BenchmarkTest/<>c__DisplayClass2_0::.ctor()
       mov     rcx,7FE57DB5290h
       call    coreclr!GC_Initialize+0x42720
       mov     rsi,rax
       IL_0005: dup
       IL_0006: ldc.i4.0
       IL_0007: stfld System.Int32 Asynchronic.BenchmarkTest/<>c__DisplayClass2_0::result
       IL_000c: dup
       IL_000d: ldftn System.Void Asynchronic.BenchmarkTest/<>c__DisplayClass2_0::<ExecuteOnTask>b__0()
       IL_0013: newobj System.Void System.Action::.ctor(System.Object,System.IntPtr)
       xor     ecx,ecx
       mov     dword ptr [rsi+8],ecx
       mov     rcx,offset System_Private_CoreLib+0xa197c0
       call    coreclr!GC_Initialize+0x42720
       mov     rdi,rax
       lea     rcx,[rdi+8]
       mov     rdx,rsi
       call    coreclr!GC_Initialize+0x41280
       mov     rcx,7FE57C629B8h
       mov     qword ptr [rdi+18h],rcx
       IL_0018: newobj System.Void System.Threading.Tasks.Task::.ctor(System.Action)
       mov     rcx,offset System_Private_CoreLib+0xa5d130
       call    coreclr!GC_Initialize+0x42720
       mov     rbx,rax
       xor     ecx,ecx
       mov     qword ptr [rsp+20h],rcx
       xor     ecx,ecx
       mov     dword ptr [rsp+28h],ecx
       mov     dword ptr [rsp+30h],ecx
       xor     ecx,ecx
       mov     qword ptr [rsp+38h],rcx
       mov     rcx,rbx
       mov     rdx,rdi
       xor     r8d,r8d
       xor     r9d,r9d
       call    System.Threading.Tasks.Task..ctor(System.Delegate, System.Object, System.Threading.Tasks.Task, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       IL_001d: dup
       IL_001e: callvirt System.Void System.Threading.Tasks.Task::Start()
       call    System.Threading.Tasks.TaskScheduler.get_Current()
       mov     rdx,rax
       mov     rcx,rbx
       call    System.Threading.Tasks.Task.Start(System.Threading.Tasks.TaskScheduler)
       IL_0023: ldc.i4 2000
       IL_0028: callvirt System.Boolean System.Threading.Tasks.Task::Wait(System.Int32)
       IL_002d: pop
       IL_002e: ldfld System.Int32 Asynchronic.BenchmarkTest/<>c__DisplayClass2_0::result
       IL_0033: ret
       mov     rcx,rbx
       xor     r8d,r8d
       mov     edx,7D0h
       call    System.Threading.Tasks.Task.Wait(Int32, System.Threading.CancellationToken)
       mov     eax,dword ptr [rsi+8]
; Total bytes of code 161
```
```assembly
; System.Threading.Tasks.Task..ctor(System.Delegate, System.Object, System.Threading.Tasks.Task, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       IL_0006: ldarg.1
       IL_0007: brtrue.s IL_0010
       test    rsi,rsi
       je      System_Private_CoreLib+0xb4a528
       IL_0010: ldarg.3
       IL_0011: brfalse.s IL_0025
       test    rbx,rbx
       je      System_Private_CoreLib+0x713dd6
       IL_0013: ldarg.s creationOptions
       IL_0015: ldc.i4.4
       IL_0016: and
       IL_0017: brfalse.s IL_0025
       IL_0019: ldarg.0
       IL_001a: call System.Threading.Tasks.Task/ContingentProperties System.Threading.Tasks.Task::EnsureContingentPropertiesInitializedUnsafe()
       IL_001f: ldarg.3
       IL_0020: stfld System.Threading.Tasks.Task System.Threading.Tasks.Task/ContingentProperties::m_parent
       test    r14b,4
       je      System_Private_CoreLib+0x713dd6
       mov     rcx,rdi
       call    System.Threading.Tasks.Task.EnsureContingentPropertiesInitializedUnsafe()
       lea     rcx,[rax+30h]
       mov     rdx,rbx
       call    System_Private_CoreLib+0x2d4010
       IL_0025: ldarg.0
       IL_0026: ldarg.1
       IL_0027: ldarg.2
       IL_0028: ldarg.s cancellationToken
       IL_002a: ldarg.s creationOptions
       IL_002c: ldarg.s internalOptions
       IL_002e: ldarg.s scheduler
       IL_0030: call System.Void System.Threading.Tasks.Task::TaskConstructorCore(System.Delegate,System.Object,System.Threading.CancellationToken,System.Threading.Tasks.TaskCreationOptions,System.Threading.Tasks.InternalTaskOptions,System.Threading.Tasks.TaskScheduler)
       mov     dword ptr [rsp+20h],r14d
       mov     ebx,dword ptr [rsp+0A0h]
       mov     dword ptr [rsp+28h],ebx
       mov     rbx,qword ptr [rsp+0A8h]
       mov     qword ptr [rsp+30h],rbx
       mov     rcx,rdi
       mov     rdx,rsi
       mov     r8,rbp
       mov     r9,qword ptr [rsp+90h]
       call    System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       IL_0035: ret
       nop
       add     rsp,40h
       pop     rbx
       pop     rbp
       pop     rsi
       pop     rdi
       pop     r14
       ret
       IL_0009: ldc.i4.s 20
       IL_000b: call System.Void System.ThrowHelper::ThrowArgumentNullException(System.ExceptionArgument)
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       push    r15
       push    r14
       push    rdi
       push    rsi
       push    rbp
       push    rbx
       sub     rsp,28h
       mov     rsi,rcx
       mov     rdi,r8
       mov     rbx,r9
; Total bytes of code 135
```
```assembly
; System.Threading.Tasks.TaskScheduler.get_Current()
       IL_0006: ldloc.0
       IL_0007: dup
       IL_0008: brtrue.s IL_0010
       IL_000a: pop
       IL_000b: call System.Threading.Tasks.TaskScheduler System.Threading.Tasks.TaskScheduler::get_Default()
       IL_0010: ret
       test    rax,rax
       jne     System_Private_CoreLib+0x73f1b7
       mov     rcx,qword ptr [System_Private_CoreLib+0x1548
       mov     edx,3A3h
       call    System_Private_CoreLib+0x2d4088
       mov     rax,qword ptr [rax+988h]
; Total bytes of code 29
```
```assembly
; System.Threading.Tasks.Task.Start(System.Threading.Tasks.TaskScheduler)
       IL_0000: ldarg.0
       IL_0001: volatile.
       IL_0003: ldfld System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Tasks.Task::m_stateFlags
       IL_0008: stloc.0
       IL_0009: ldloc.0
       IL_000a: call System.Boolean System.Threading.Tasks.Task::IsCompletedMethod(System.Int32)
       IL_000f: brfalse.s IL_0018
       mov     ecx,dword ptr [rsi+34h]
       test    ecx,1600000h
       jne     System_Private_CoreLib+0xb4a540
       IL_0018: ldarg.1
       IL_0019: brtrue.s IL_0022
       test    rdx,rdx
       je      System_Private_CoreLib+0xb4a54b
       and     ecx,0FFFFh
       IL_0029: ldloc.1
       IL_002a: ldc.i4 1024
       IL_002f: and
       IL_0030: brfalse.s IL_0039
       test    ecx,400h
       jne     System_Private_CoreLib+0xb4a556
       IL_0039: ldloc.1
       IL_003a: ldc.i4 512
       IL_003f: and
       IL_0040: brfalse.s IL_0049
       test    ecx,200h
       jne     System_Private_CoreLib+0xb4a561
       IL_0049: ldarg.0
       IL_004a: ldflda System.Threading.Tasks.TaskScheduler System.Threading.Tasks.Task::m_taskScheduler
       IL_004f: ldarg.1
       IL_0050: ldnull
       IL_0051: call T System.Threading.Interlocked::CompareExchange<System.Threading.Tasks.TaskScheduler>(T&,T,T)
       IL_0056: brfalse.s IL_005f
       lea     rcx,[rsi+18h]
       xor     r8d,r8d
       call    System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test    rax,rax
       jne     System_Private_CoreLib+0xb4a56c
       IL_005f: ldarg.0
       IL_0060: ldc.i4.1
       IL_0061: call System.Void System.Threading.Tasks.Task::ScheduleAndStart(System.Boolean)
       IL_0066: ret
       mov     rcx,rsi
       mov     edx,1
       lea     rax,[System_Private_CoreLib+0x304db8
       add     rsp,20h
       pop     rsi
       jmp     rax
       IL_0011: ldc.i4.s 64
       IL_0013: call System.Void System.ThrowHelper::ThrowInvalidOperationException(System.ExceptionResource)
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       push    rsi
       sub     rsp,20h
       IL_001b: ldc.i4.s 47
       IL_001d: call System.Void System.ThrowHelper::ThrowArgumentNullException(System.ExceptionArgument)
       IL_0022: ldloc.0
       IL_0023: call System.Threading.Tasks.TaskCreationOptions System.Threading.Tasks.Task::OptionsMethod(System.Int32)
       IL_0028: stloc.1
       mov     rsi,rcx
       call    System.Threading.Tasks.TaskScheduler.get_Current()
       mov     rdx,rax
       IL_0032: ldc.i4.s 65
       IL_0034: call System.Void System.ThrowHelper::ThrowInvalidOperationException(System.ExceptionResource)
       mov     rcx,rsi
       mov     r8d,1
       lea     rax,[System_Private_CoreLib+0x714710
       IL_0042: ldc.i4.s 66
       IL_0044: call System.Void System.ThrowHelper::ThrowInvalidOperationException(System.ExceptionResource)
       add     eax,40h
       add     rsp,20h
       pop     rsi
       jmp     rax
       IL_0058: ldc.i4.s 67
       IL_005a: call System.Void System.ThrowHelper::ThrowInvalidOperationException(System.ExceptionResource)
       jmp     rax
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       sub     rsp,28h
       nop
       test    rdx,rdx
       je      System_Private_CoreLib+0xb4a578
       mov     r8d,1
       lea     rax,[System_Private_CoreLib+0x714710
; Total bytes of code 186
```
```assembly
; System.Threading.Tasks.Task.Wait(Int32, System.Threading.CancellationToken)
       IL_0000: ldarg.1
       IL_0001: ldc.i4.m1
       IL_0002: bge.s IL_000b
       cmp     edx,0FFFFFFFFh
       jl      System_Private_CoreLib+0xb4a5d4
       mov     eax,dword ptr [rsi+34h]
       and     eax,11000000h
       cmp     eax,1000000h
       jne     System_Private_CoreLib+0x716822
       IL_0013: ldc.i4.1
       IL_0014: ret
       mov     eax,1
       add     rsp,28h
       pop     rsi
       pop     rdi
       ret
       IL_0015: ldarg.0
       IL_0016: ldarg.1
       IL_0017: ldarg.2
       IL_0018: call System.Boolean System.Threading.Tasks.Task::InternalWait(System.Int32,System.Threading.CancellationToken)
       IL_001d: brtrue.s IL_0021
       mov     r8,qword ptr [rsp+50h]
       mov     rcx,rsi
       call    System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
       test    eax,eax
       jne     System_Private_CoreLib+0x71683c
       IL_001f: ldc.i4.0
       IL_0020: ret
       IL_0021: ldarg.0
       IL_0022: call System.Boolean System.Threading.Tasks.Task::get_IsWaitNotificationEnabledOrNotRanToCompletion()
       IL_0027: brfalse.s IL_0046
       IL_0029: ldarg.0
       IL_002a: call System.Boolean System.Threading.Tasks.Task::NotifyDebuggerOfWaitCompletionIfNecessary()
       IL_002f: pop
       IL_0030: ldarg.0
       IL_0031: call System.Boolean System.Threading.Tasks.Task::get_IsCanceled()
       IL_0036: brfalse.s IL_003f
       xor     eax,eax
       add     rsp,28h
       pop     rsi
       pop     rdi
       ret
       mov     ecx,dword ptr [rsi+34h]
       and     ecx,11000000h
       cmp     ecx,1000000h
       je      System_Private_CoreLib+0x7168a4
       mov     rcx,rsi
       call    System.Threading.Tasks.Task.NotifyDebuggerOfWaitCompletionIfNecessary()
       mov     ecx,dword ptr [rsi+34h]
       and     ecx,600000h
       cmp     ecx,400000h
       jne     System_Private_CoreLib+0x71688b
       IL_0038: ldarga.s cancellationToken
       IL_003a: call System.Void System.Threading.CancellationToken::ThrowIfCancellationRequested()
       cmp     qword ptr [rsp+50h],0
       je      System_Private_CoreLib+0x71688b
       mov     rcx,qword ptr [rsp+50h]
       cmp     dword ptr [rcx+28h],2
       setge   cl
       movzx   ecx,cl
       test    ecx,ecx
       je      System_Private_CoreLib+0x71688b
       lea     rcx,[rsp+50h]
       call    System.Threading.CancellationToken.ThrowOperationCanceledException()
       IL_003f: ldarg.0
       IL_0040: ldc.i4.1
       IL_0041: call System.Void System.Threading.Tasks.Task::ThrowIfExceptional(System.Boolean)
       mov     rcx,rsi
       mov     edx,1
       call    System.Threading.Tasks.Task.GetExceptions(Boolean)
       mov     rdi,rax
       test    rdi,rdi
       jne     System_Private_CoreLib+0xb4a5df
       IL_0046: ldc.i4.1
       IL_0047: ret
       mov     eax,1
       add     rsp,28h
       pop     rsi
       pop     rdi
       ret
       IL_0004: ldc.i4.s 49
       IL_0006: call System.Void System.ThrowHelper::ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       IL_000b: ldarg.0
       IL_000c: call System.Boolean System.Threading.Tasks.Task::get_IsWaitNotificationEnabledOrNotRanToCompletion()
       IL_0011: brtrue.s IL_0015
       push    rbp
       push    rdi
       push    rsi
       sub     rsp,30h
       lea     rbp,[rsp+40h]
       ???
       mov     qword ptr [rbp-20h],rsp
       cmp     qword ptr [rcx+18h],0
       jne     System_Private_CoreLib+0x7168d1
       xor     eax,eax
       lea     rsp,[rbp-10h]
       pop     rsi
       pop     rdi
       pop     rbp
       ret
       mov     qword ptr [rbp+10h],rcx
       mov     rcx,qword ptr [rcx+18h]
       mov     rdx,qword ptr [rbp+10h]
; Total bytes of code 224
```
```assembly
; Asynchronic.BenchmarkTest+<>c__DisplayClass2_0.<ExecuteOnTask>b__0()
       IL_000b: ret
       ret
; Total bytes of code 1
```
**No ILOffsetMap found**
Asynchronic.BenchmarkTest+<>c__DisplayClass2_0..ctor()

## .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), X64 RyuJIT
```assembly
; Asynchronic.BenchmarkTest.ExecuteOnThread()
       IL_0000: newobj System.Void Asynchronic.BenchmarkTest/<>c__DisplayClass3_0::.ctor()
       mov     rcx,7FE57D952B8h
       call    coreclr!GC_Initialize+0x42720
       mov     rsi,rax
       IL_0005: dup
       IL_0006: ldc.i4.0
       IL_0007: newobj System.Void System.Threading.AutoResetEvent::.ctor(System.Boolean)
       mov     rcx,offset System_Private_CoreLib+0xa72f88
       call    coreclr!GC_Initialize+0x42720
       mov     rdi,rax
       mov     rcx,rdi
       xor     edx,edx
       xor     r8d,r8d
       xor     r9d,r9d
       call    System.Threading.EventWaitHandle..ctor(Boolean, System.Threading.EventResetMode, System.String)
       IL_000c: stfld System.Threading.AutoResetEvent Asynchronic.BenchmarkTest/<>c__DisplayClass3_0::autoEvent
       IL_0011: dup
       IL_0012: ldc.i4.0
       IL_0013: stfld System.Int32 Asynchronic.BenchmarkTest/<>c__DisplayClass3_0::result
       IL_0018: dup
       IL_0019: ldftn System.Void Asynchronic.BenchmarkTest/<>c__DisplayClass3_0::<ExecuteOnThread>b__0()
       IL_001f: newobj System.Void System.Threading.ThreadStart::.ctor(System.Object,System.IntPtr)
       lea     rcx,[rsi+8]
       mov     rdx,rdi
       call    coreclr!GC_Initialize+0x41280
       xor     ecx,ecx
       mov     dword ptr [rsi+10h],ecx
       mov     rcx,offset System_Private_CoreLib+0xa1f678
       call    coreclr!GC_Initialize+0x42720
       mov     rdi,rax
       lea     rcx,[rdi+8]
       mov     rdx,rsi
       call    coreclr!GC_Initialize+0x41280
       mov     rcx,7FE57C429B8h
       mov     qword ptr [rdi+18h],rcx
       IL_0024: newobj System.Void System.Threading.Thread::.ctor(System.Threading.ThreadStart)
       mov     rcx,7FE57D96268h
       call    coreclr!coreclr_shutdown_2+0x180f0
       mov     rbx,rax
       mov     rcx,rbx
       mov     rdx,rdi
       call    System.Threading.Thread..ctor(System.Threading.ThreadStart)
       IL_0029: callvirt System.Void System.Threading.Thread::Start()
       mov     rdx,qword ptr [rbx+8]
       mov     ecx,dword ptr [rdx]
       mov     rcx,offset System_Private_CoreLib+0xa547e8
       cmp     qword ptr [rdx],rcx
       je      M00_L00
       call    coreclr!GC_Initialize+0x41070
       mov     rcx,rax
       jmp     M00_L01
M00_L00:
       mov     rcx,rdx
M00_L01:
       call    System.Threading.Thread.Start()
       IL_002e: dup
       IL_002f: ldfld System.Threading.AutoResetEvent Asynchronic.BenchmarkTest/<>c__DisplayClass3_0::autoEvent
       IL_0034: ldc.i4 2000
       IL_0039: callvirt System.Boolean System.Threading.WaitHandle::WaitOne(System.Int32)
       IL_003e: pop
       IL_003f: dup
       IL_0040: ldfld System.Threading.AutoResetEvent Asynchronic.BenchmarkTest/<>c__DisplayClass3_0::autoEvent
       IL_0045: callvirt System.Void System.Threading.WaitHandle::Close()
       mov     rcx,qword ptr [rsi+8]
       mov     r8d,dword ptr [rcx]
       movzx   r8d,byte ptr [rcx+18h]
       mov     rcx,qword ptr [rcx+8]
       mov     edx,7D0h
       xor     r9d,r9d
       call    System.Threading.WaitHandle.InternalWaitOne(System.Runtime.InteropServices.SafeHandle, Int64, Boolean, Boolean)
       mov     rdi,qword ptr [rsi+8]
       cmp     qword ptr [rdi+8],0
       je      M00_L02
       mov     rcx,qword ptr [rdi+8]
       mov     eax,dword ptr [rcx]
       call    System.Runtime.InteropServices.SafeHandle.InternalDispose()
M00_L02:
       mov     rcx,rdi
       call    System.GC.SuppressFinalize(System.Object)
       IL_004a: ldfld System.Int32 Asynchronic.BenchmarkTest/<>c__DisplayClass3_0::result
       IL_004f: ret
       mov     eax,dword ptr [rsi+10h]
; Total bytes of code 243
```
```assembly
; System.Threading.EventWaitHandle..ctor(Boolean, System.Threading.EventResetMode, System.String)
       IL_0000: ldarg.0
       IL_0001: call System.Void System.Threading.WaitHandle::.ctor()
       xor     ecx,ecx
       mov     qword ptr [rsi+8],rcx
       mov     rcx,qword ptr [System_Private_CoreLib+0x1548
       mov     edx,324h
       call    System_Private_CoreLib+0x2d40a0
       mov     r8,qword ptr [rax+8A8h]
       mov     qword ptr [rsi+10h],r8
       mov     byte ptr [rsi+18h],0
       IL_0006: ldarg.3
       IL_0007: brfalse.s IL_0036
       test    rdi,rdi
       je      System_Private_CoreLib+0x75cfa3
       IL_0009: ldc.i4 260
       IL_000e: ldarg.3
       IL_000f: callvirt System.Int32 System.String::get_Length()
       IL_0014: bge.s IL_0036
       IL_0016: call System.String System.SR::get_Argument_WaitHandleNameTooLong()
       IL_001b: ldarg.3
       IL_001c: ldc.i4 260
       IL_0021: box System.Int32
       IL_0026: call System.String System.SR::Format(System.String,System.Object,System.Object)
       IL_002b: ldstr "name"
       IL_0030: newobj System.Void System.ArgumentException::.ctor(System.String,System.String)
       cmp     dword ptr [rdi+8],104h
       jg      System_Private_CoreLib+0xb502f4
       IL_0036: ldarg.1
       IL_0037: brtrue.s IL_003c
       test    r14b,r14b
       jne     System_Private_CoreLib+0x75cfad
       IL_0039: ldc.i4.0
       IL_003a: br.s IL_003d
       xor     r8d,r8d
       jmp     System_Private_CoreLib+0x75cfb3
       IL_003c: ldc.i4.2
       IL_003d: stloc.0
       mov     r8d,2
       IL_003e: ldarg.2
       IL_003f: brfalse.s IL_005c
       test    ebx,ebx
       je      System_Private_CoreLib+0x75cfc4
       IL_0041: ldarg.2
       IL_0042: ldc.i4.1
       IL_0043: bne.un.s IL_004b
       cmp     ebx,1
       jne     System_Private_CoreLib+0xb50361
       IL_0045: ldloc.0
       IL_0046: ldc.i4.1
       IL_0047: or
       IL_0048: stloc.0
       IL_0049: br.s IL_005c
       IL_004b: call System.String System.SR::get_Argument_InvalidFlag()
       IL_0050: ldarg.3
       IL_0051: call System.String System.SR::Format(System.String,System.Object)
       IL_0056: newobj System.Void System.ArgumentException::.ctor(System.String)
       or      r8d,1
       IL_005c: ldnull
       IL_005d: ldarg.3
       IL_005e: ldloc.0
       IL_005f: ldc.i4 34603010
       IL_0064: call Microsoft.Win32.SafeHandles.SafeWaitHandle Microsoft.Win32.Win32Native::CreateEventEx(Microsoft.Win32.Win32Native/SECURITY_ATTRIBUTES,System.String,System.UInt32,System.UInt32)
       IL_0069: stloc.1
       mov     rdx,rdi
       xor     ecx,ecx
       mov     r9d,2100002h
       call    Microsoft.Win32.Win32Native.CreateEventEx(SECURITY_ATTRIBUTES, System.String, UInt32, UInt32)
       mov     rbx,rax
       IL_006a: ldloc.1
       IL_006b: callvirt System.Boolean System.Runtime.InteropServices.SafeHandle::get_IsInvalid()
       IL_0070: brfalse.s IL_00a6
       mov     rcx,rbx
       cmp     dword ptr [rcx],ecx
       call    Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test    eax,eax
       jne     System_Private_CoreLib+0xb503a2
       IL_00a6: ldarg.0
       IL_00a7: ldloc.1
       IL_00a8: call System.Void System.Threading.WaitHandle::SetHandleInternal(Microsoft.Win32.SafeHandles.SafeWaitHandle)
       lea     rcx,[rsi+8]
       mov     rdx,rbx
       call    System_Private_CoreLib+0x2d4010
       mov     rcx,qword ptr [rbx+8]
       mov     qword ptr [rsi+10h],rcx
       IL_00ad: ret
       lea     rsp,[rbp-20h]
       pop     rbx
       pop     rsi
       pop     rdi
       pop     r14
       pop     rbp
       ret
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       sub     rsp,38h
       nop
       mov     rax,qword ptr [rsp+60h]
       mov     qword ptr [rsp+20h],rax
       xor     eax,eax
       mov     qword ptr [rsp+28h],rax
       movzx   edx,dl
       call    System.Threading.EventWaitHandle..ctor(Boolean, System.Threading.EventResetMode, System.String, Boolean ByRef, System.Security.AccessControl.EventWaitHandleSecurity)
       nop
       add     rsp,38h
       ret
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       push    rbp
       push    r14
       push    rdi
       push    rsi
       push    rbx
       sub     rsp,20h
       lea     rbp,[rsp+40h]
       mov     rsi,rcx
       mov     r14d,edx
       mov     ebx,r8d
       mov     rdi,r9
       xor     ecx,ecx
       mov     qword ptr [rsi+8],rcx
       mov     rcx,qword ptr [System_Private_CoreLib+0x1548
       mov     edx,324h
       IL_0035: throw
       call    System_Private_CoreLib+0x2d40a0
       mov     rcx,qword ptr [rax+8A8h]
       mov     qword ptr [rsi+10h],rcx
       mov     byte ptr [rsi+18h],0
       test    rdi,rdi
       je      System_Private_CoreLib+0x75d093
       cmp     dword ptr [rdi+8],104h
       jg      System_Private_CoreLib+0xb50418
       test    r14b,r14b
       jne     System_Private_CoreLib+0x75d09c
       xor     ecx,ecx
       jmp     System_Private_CoreLib+0x75d0a1
       mov     ecx,2
       mov     r8d,ecx
       test    ebx,ebx
       je      System_Private_CoreLib+0x75d0b5
       cmp     ebx,1
       jne     System_Private_CoreLib+0xb50485
       IL_005b: throw
       xor     edi,dword ptr [rdi]
       add     byte ptr [rcx-7Dh],al
       enter   3301h,0C9h
       IL_0072: call System.Int32 System.Runtime.InteropServices.Marshal::GetLastWin32Error()
       IL_0077: stloc.2
       leave
       mov     rdx,rdi
       mov     r9d,2100002h
       IL_0078: ldloc.1
       IL_0079: callvirt System.Void System.Runtime.InteropServices.SafeHandle::SetHandleAsInvalid()
       add     byte ptr [rax],dl
       add     ch,al
       pop     rbx
       jp      System_Private_CoreLib+0x75d07e
       dec     dword ptr [rax-75h]
       IL_007e: ldarg.3
       IL_007f: brfalse.s IL_009e
       mov     rbx,rax
       call    System.Runtime.InteropServices.Marshal.GetLastWin32Error()
       IL_0081: ldarg.3
       IL_0082: callvirt System.Int32 System.String::get_Length()
       IL_0087: brfalse.s IL_009e
       pop     rbp
       mov     edx,0F08B44FFh
       IL_0089: ldc.i4.6
       IL_008a: ldloc.2
       IL_008b: bne.un.s IL_009e
       IL_008d: call System.String System.SR::get_Threading_WaitHandleCannotBeOpenedException_InvalidHandle()
       IL_0092: ldarg.3
       IL_0093: call System.String System.SR::Format(System.String,System.Object)
       IL_0098: newobj System.Void System.Threading.WaitHandleCannotBeOpenedException::.ctor(System.String)
       mov     rcx,rbx
       cmp     dword ptr [rcx],ecx
       call    Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test    eax,eax
       jne     System_Private_CoreLib+0xb504c6
       cmp     r14d,0B7h
       setne   dl
       mov     rdi,qword ptr [rbp+30h]
       mov     byte ptr [rdi],dl
       lea     rcx,[rsi+8]
       mov     rdx,rbx
       call    System_Private_CoreLib+0x2d4010
       mov     rcx,qword ptr [rbx+8]
       mov     qword ptr [rsi+10h],rcx
       lea     rsp,[rbp-20h]
       pop     rbx
       pop     rsi
       pop     rdi
       pop     r14
       IL_009d: throw
       pop     rsi
       pop     rbp
       ret
       int     3
       int     3
       int     3
       int     3
       int     3
       IL_009e: ldloc.2
       IL_009f: ldarg.3
       IL_00a0: call System.Exception System.IO.Win32Marshal::GetExceptionForWin32Error(System.Int32,System.String)
       IL_00a5: throw
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       push    rdi
       push    rsi
       sub     rsp,28h
       mov     rsi,rcx
       mov     rdi,rdx
       xor     ecx,ecx
       mov     qword ptr [rsi+8],rcx
       mov     rcx,qword ptr [System_Private_CoreLib+0x1548
; Total bytes of code 475
```
```assembly
; System.Threading.Thread..ctor(System.Threading.ThreadStart)
       IL_0000: ldarg.0
       IL_0001: call System.Void System.Runtime.ConstrainedExecution.CriticalFinalizerObject::.ctor()
       mov     rcx,rsi
       call    qword ptr [System_Threading_Thread+0x1120
       IL_0006: ldarg.1
       IL_0007: brtrue.s IL_0014
       test    rdi,rdi
       je      System_Threading_Thread+0x6dab
       IL_0014: ldarg.0
       IL_0015: ldarg.0
       IL_0016: ldftn System.Void System.Threading.Thread::ThreadMain_ThreadStart()
       IL_001c: newobj System.Void System.Threading.ThreadStart::.ctor(System.Object,System.IntPtr)
       call    qword ptr [System_Threading_Thread+0x1080
       mov     rbx,rax
       mov     rcx,rbx
       mov     rdx,rsi
       call    qword ptr [System_Threading_Thread+0x1088
       IL_0021: call Internal.Runtime.Augments.RuntimeThread Internal.Runtime.Augments.RuntimeThread::Create(System.Threading.ThreadStart)
       IL_0026: stfld Internal.Runtime.Augments.RuntimeThread System.Threading.Thread::_runtimeThread
       mov     rcx,rbx
       call    qword ptr [System_Threading_Thread+0x1128
       mov     rdx,qword ptr [System_Threading_Thread+0x1318
       lea     rcx,[rsi+rdx]
       mov     rdx,rax
       call    qword ptr [System_Threading_Thread+0x1010
       IL_002b: ldarg.0
       IL_002c: ldarg.1
       IL_002d: stfld System.Delegate System.Threading.Thread::_start
       mov     rdx,qword ptr [System_Threading_Thread+0x1318
       lea     rcx,[rsi+rdx+8]
       mov     rdx,rdi
       call    qword ptr [System_Threading_Thread+0x1010
       IL_0032: ret
       nop
       add     rsp,20h
       pop     rbx
       pop     rsi
       pop     rdi
       ret
       IL_0009: ldstr "start"
       IL_000e: newobj System.Void System.ArgumentNullException::.ctor(System.String)
       call    qword ptr [System_Threading_Thread+0x1078
       mov     rsi,rax
       mov     ecx,261h
       call    System_Threading_Thread+0x27b7
       mov     rdx,rax
       mov     rcx,rsi
       call    qword ptr [System_Threading_Thread+0x1118
       IL_0013: throw
       mov     rcx,rsi
       call    System_Threading_Thread+0x27b1
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       push    rdi
       push    rsi
       push    rbp
       push    rbx
       sub     rsp,28h
       mov     rsi,rcx
; Total bytes of code 158
```
```assembly
; System.Threading.Thread.Start()
       IL_0000: ldarg.0
       IL_0001: call System.Void System.Threading.Thread::StartupSetApartmentStateInternal()
       mov     rcx,rsi
       call    System.Threading.Thread.StartupSetApartmentStateInternal()
       IL_0006: ldarg.0
       IL_0007: ldfld System.Delegate System.Threading.Thread::m_Delegate
       IL_000c: brfalse.s IL_002c
       cmp     qword ptr [rsi+20h],0
       je      System_Private_CoreLib+0x625ad6
       IL_000e: ldarg.0
       IL_000f: ldfld System.Delegate System.Threading.Thread::m_Delegate
       IL_0014: callvirt System.Object System.Delegate::get_Target()
       IL_0019: castclass System.Threading.ThreadHelper
       IL_001e: stloc.0
       IL_001f: call System.Threading.ExecutionContext System.Threading.ExecutionContext::Capture()
       IL_0024: stloc.1
       mov     rcx,qword ptr [rsi+20h]
       mov     rax,qword ptr [rcx]
       mov     rax,qword ptr [rax+48h]
       call    qword ptr [rax+18h]
       mov     rdx,rax
       mov     rdi,rdx
       test    rdi,rdi
       je      System_Private_CoreLib+0x625ac5
       lea     rcx,[System_Private_CoreLib+0xa55810
       cmp     qword ptr [rdi],rcx
       je      System_Private_CoreLib+0x625ac5
       call    System_Private_CoreLib+0x2d4058
       mov     rdi,rax
       call    System.Threading.ExecutionContext.Capture()
       IL_0025: ldloc.0
       IL_0026: ldloc.1
       IL_0027: callvirt System.Void System.Threading.ThreadHelper::SetExecutionContextHelper(System.Threading.ExecutionContext)
       lea     rcx,[rdi+18h]
       mov     rdx,rax
       call    System_Private_CoreLib+0x2d4010
       IL_002c: ldarg.0
       IL_002d: call System.Void System.Threading.Thread::StartInternal()
       IL_0032: ret
       mov     rcx,rsi
       lea     rax,[System_Private_CoreLib+0x2feaa0
; Total bytes of code 87
```
```assembly
; System.Threading.WaitHandle.InternalWaitOne(System.Runtime.InteropServices.SafeHandle, Int64, Boolean, Boolean)
       IL_0000: ldarg.0
       IL_0001: brtrue.s IL_000f
       IL_0003: ldnull
       IL_0004: call System.String System.SR::get_ObjectDisposed_Generic()
       IL_0009: newobj System.Void System.ObjectDisposedException::.ctor(System.String,System.String)
       test    rcx,rcx
       je      System_Private_CoreLib+0xb52860
       IL_000f: ldarg.0
       IL_0010: ldarg.1
       IL_0011: conv.u4
       IL_0012: ldarg.2
       IL_0013: ldarg.3
       IL_0014: call System.Int32 System.Threading.WaitHandle::WaitOneNative(System.Runtime.InteropServices.SafeHandle,System.UInt32,System.Boolean,System.Boolean)
       IL_0019: stloc.0
       movzx   r8d,r8b
       movzx   r9d,r9b
       call    System.Threading.WaitHandle.WaitOneNative(System.Runtime.InteropServices.SafeHandle, UInt32, Boolean, Boolean)
       IL_001a: ldloc.0
       IL_001b: ldc.i4 128
       IL_0020: bne.un.s IL_0027
       cmp     eax,80h
       je      System_Private_CoreLib+0xb52898
       IL_0027: ldloc.0
       IL_0028: ldc.i4 258
       IL_002d: ceq
       IL_002f: ldc.i4.0
       IL_0030: ceq
       IL_0032: ret
       cmp     eax,102h
       setne   al
       movzx   eax,al
       add     rsp,20h
       pop     rsi
       ret
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       push    rsi
       sub     rsp,20h
       cmp     qword ptr [rcx+8],0
       je      System_Private_CoreLib+0xb528a0
       movzx   r8d,byte ptr [rcx+18h]
       mov     rcx,qword ptr [rcx+8]
       mov     edx,0FFFFFFFFh
       xor     r9d,r9d
       call    System.Threading.WaitHandle.WaitOneNative(System.Runtime.InteropServices.SafeHandle, UInt32, Boolean, Boolean)
       cmp     eax,80h
       IL_000e: throw
       add     byte ptr [rax],0
       add     byte ptr [rdi],cl
       test    byte ptr [rdi],dh
       cmp     eax,1023D00h
       IL_0022: call System.Void System.Threading.WaitHandle::ThrowAbandonedMutexException()
       cmp     eax,1023D00h
       add     byte ptr [rax],al
       setne   al
       movzx   eax,al
       add     rsp,20h
       pop     rsi
       ret
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
       int     3
; Total bytes of code 147
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       IL_0000: ldarg.0
       IL_0001: brtrue.s IL_000e
       test    rcx,rcx
       je      System_Private_CoreLib+0xb4378c
       IL_000e: ldarg.0
       IL_000f: call System.Void System.GC::_SuppressFinalize(System.Object)
       IL_0014: ret
       lea     rax,[System_Private_CoreLib+0x303c98
       add     rsp,20h
       pop     rsi
       jmp     rax
       IL_0003: ldstr "obj"
       IL_0008: newobj System.Void System.ArgumentNullException::.ctor(System.String)
       int     3
       int     3
       int     3
       push    rsi
       sub     rsp,20h
       test    rcx,rcx
       je      System_Private_CoreLib+0xb437bc
       lea     rax,[System_Private_CoreLib+0x303ca8
       add     rsp,20h
       pop     rsi
       jmp     rax
       int     3
       int     3
       int     3
       push    rbp
       IL_000d: throw
       push    r15
       push    r14
       push    r13
       push    r12
       push    rdi
       push    rsi
       push    rbx
       sub     rsp,68h
       lea     rbp,[rsp+0A0h]
       mov     esi,ecx
       lea     rcx,[rbp-70h]
       mov     rdx,r10
; Total bytes of code 92
```
```assembly
; System.Threading.AutoResetEvent..ctor(Boolean)
       IL_0000: ldarg.0
       IL_0001: ldarg.1
       IL_0002: ldc.i4.0
       IL_0003: call System.Void System.Threading.EventWaitHandle::.ctor(System.Boolean,System.Threading.EventResetMode)
       IL_0008: ret
       movzx   edx,dl
       xor     r8d,r8d
       xor     r9d,r9d
       lea     rax,[System_Private_CoreLib+0x75cf50
; Total bytes of code 16
```
```assembly
; Asynchronic.BenchmarkTest+<>c__DisplayClass3_0.<ExecuteOnThread>b__0()
       IL_0017: ret
       nop
; Total bytes of code 1
```
```assembly
; System.Threading.WaitHandle.WaitOne(Int32)
       IL_0000: ldarg.0
       IL_0001: ldarg.1
       IL_0002: ldc.i4.0
       IL_0003: callvirt System.Boolean System.Threading.WaitHandle::WaitOne(System.Int32,System.Boolean)
       IL_0008: ret
       xor     r8d,r8d
       mov     rax,qword ptr [rcx]
       mov     rax,qword ptr [rax+40h]
       mov     rax,qword ptr [rax+38h]
; Total bytes of code 14
```
```assembly
; System.Threading.WaitHandle.Close()
       IL_0000: ldarg.0
       IL_0001: ldc.i4.1
       IL_0002: callvirt System.Void System.Threading.WaitHandle::Dispose(System.Boolean)
       mov     rcx,rsi
       mov     edx,1
       mov     rax,qword ptr [rsi]
       mov     rax,qword ptr [rax+48h]
       call    qword ptr [rax+28h]
       IL_0007: ldarg.0
       IL_0008: call System.Void System.GC::SuppressFinalize(System.Object)
       IL_000d: ret
       mov     rcx,rsi
       lea     rax,[System_Private_CoreLib+0x6c8390
; Total bytes of code 28
```
**No ILOffsetMap found**
System.Runtime.InteropServices.SafeHandle.InternalDispose()
Asynchronic.BenchmarkTest+<>c__DisplayClass3_0..ctor()

