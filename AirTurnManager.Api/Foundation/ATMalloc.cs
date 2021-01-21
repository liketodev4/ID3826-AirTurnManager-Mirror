using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation.Delegates
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate global::System.IntPtr Func_IntPtr_ulong(ulong size);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void Action_IntPtr_ulong(global::System.IntPtr ptr, ulong size);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate global::System.IntPtr Func_IntPtr_IntPtr_ulong_ulong(global::System.IntPtr ptr, ulong new_size, ulong prev_size);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void Action_IntPtr_ulong_IntPtr(global::System.IntPtr reference, ulong index, global::System.IntPtr context);
}

namespace AirTurnManager.Api.Foundation
{
    /// <summary>Hook called when the module calls malloc() to allocate memory.</summary>
    /// <param name="size">- number of bytes</param>
    /// <returns>- Pointer to the allocated memory</returns>
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate global::System.IntPtr ATMallocHook(ulong size);

    /// <summary>Hook called when the module calls free() to free memory.</summary>
    /// <param name="ptr">The pointer to the memory to free</param>
    /// <param name="size">The number of bytes that were previously allocated</param>
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void ATFreeHook(global::System.IntPtr ptr, ulong size);

    /// <summary>Hook called when the module calls realloc() to reallocate memory.</summary>
    /// <param name="ptr">The pointer to the memory to reallocate</param>
    /// <param name="new_size">The desired new size of the allocated memory</param>
    /// <param name="prev_size">The previous size of the allocated memory</param>
    /// <returns>- Pointer to the reallocated memory</returns>
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate global::System.IntPtr ATReallocHook(global::System.IntPtr ptr, ulong new_size, ulong prev_size);

    /// <summary>A function definition for a weak pointer array element free'd callback</summary>
    /// <param name="reference">A pointer to the memory that has just been free'd</param>
    /// <param name="index">The index of the object in its array</param>
    /// <param name="context">Context provided when registering the callback</param>
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void ATWeakPointerArrayElementFreedCallback(global::System.IntPtr reference, ulong index, global::System.IntPtr context);

    public unsafe partial class ATMallocUnsafe
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATMalloc")]
            internal static extern global::System.IntPtr ATMalloc(ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATRealloc")]
            internal static extern global::System.IntPtr ATRealloc(global::System.IntPtr pointer, ulong new_size, ulong previous_size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATFree")]
            internal static extern void ATFree(global::System.IntPtr pointer, ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATMallocHookRegister")]
            internal static extern void ATMallocHookRegister(global::System.IntPtr mallocHook);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATFreeHookRegister")]
            internal static extern void ATFreeHookRegister(global::System.IntPtr freeHook);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATReallocHookRegister")]
            internal static extern void ATReallocHookRegister(global::System.IntPtr reallocHook);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATWeakPointerRegister")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATWeakPointerRegister(void** pointerToPointerToVariable);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATWeakPointerArrayRegister")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATWeakPointerArrayRegister(void** arrayOfPointersToVariable, ulong length, global::System.IntPtr context, global::System.IntPtr callback);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATWeakPointerArrayModifyLength")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATWeakPointerArrayModifyLength(void** arrayOfPointersToVariable, ulong newLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATWeakPointerArrayUnregister")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATWeakPointerArrayUnregister(void** arrayOfPointersToVariable);
        }

        /// <summary>Allocate memory from the heap</summary>
        /// <param name="size">The size of the memory to allocate</param>
        /// <returns>A pointer to the allocated memory, or `NULL` if unsuccessful</returns>
        public static global::System.IntPtr ATMalloc_(ulong size)
        {
            var __ret = __Internal.ATMalloc(size);
            return __ret;
        }

        /// <summary>Reallocate memory</summary>
        /// <param name="pointer">A pointer to the existing memory</param>
        /// <param name="new_size">The new size of the memory</param>
        /// <param name="previous_size">The previous size of the memory</param>
        /// <returns>A pointer to the allocated memory, or `NULL` if unsuccessful</returns>
        /// <remarks>If unsuccessful, the original pointer will remain valid</remarks>
        public static global::System.IntPtr ATRealloc(global::System.IntPtr pointer, ulong new_size, ulong previous_size)
        {
            var __ret = __Internal.ATRealloc(pointer, new_size, previous_size);
            return __ret;
        }

        /// <summary>Free memory</summary>
        /// <param name="pointer">A pointer to the memory</param>
        /// <param name="size">The size of the allocated memory</param>
        public static void ATFree(global::System.IntPtr pointer, ulong size)
        {
            __Internal.ATFree(pointer, size);
        }

        /// <summary>Allows the user to register a function that will get called when the module calls malloc().</summary>
        public static void ATMallocHookRegister(global::AirTurnManager.Api.Foundation.Delegates.Func_IntPtr_ulong mallocHook)
        {
            var __arg0 = mallocHook == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(mallocHook);
            __Internal.ATMallocHookRegister(__arg0);
        }

        /// <summary>Allows the user to register a function that will get called when the module calls free().</summary>
        public static void ATFreeHookRegister(global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_ulong freeHook)
        {
            var __arg0 = freeHook == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(freeHook);
            __Internal.ATFreeHookRegister(__arg0);
        }

        /// <summary>Allows the user to register a function that will get called when the module calls realloc().</summary>
        public static void ATReallocHookRegister(global::AirTurnManager.Api.Foundation.Delegates.Func_IntPtr_IntPtr_ulong_ulong reallocHook)
        {
            var __arg0 = reallocHook == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(reallocHook);
            __Internal.ATReallocHookRegister(__arg0);
        }

        /// <summary>Register a weak pointer. When the memory the pointer is pointed to is free'd, the pointer is set to NULL</summary>
        /// <param name="pointerToPointerToVariable">A pointer to a pointer to some allocated memory</param>
        /// <returns>`true` if registration was successful</returns>
        public static bool ATWeakPointerRegister(void** pointerToPointerToVariable)
        {
            var __ret = __Internal.ATWeakPointerRegister(pointerToPointerToVariable);
            return __ret;
        }

        /// <summary>Register an array of weak pointers</summary>
        /// <param name="arrayOfPointersToVariable">The array of weak pointers</param>
        /// <param name="length">The length of the array</param>
        /// <param name="context">The context to provide when the callback function is called</param>
        /// <param name="callback">The callback function</param>
        /// <returns>`true` if registration was successful</returns>
        /// <remarks>When an array of pointers is registered, if any of the memory pointed to by any of the pointers is free'd, the pointer to that memory will be removed from the array and the callback will be called. Call `ATWeakPointerArrayUnregister` when the array is deallocated</remarks>
        public static bool ATWeakPointerArrayRegister(void** arrayOfPointersToVariable, ulong length, global::System.IntPtr context, global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_ulong_IntPtr callback)
        {
            var __arg3 = callback == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback);
            var __ret = __Internal.ATWeakPointerArrayRegister(arrayOfPointersToVariable, length, context, __arg3);
            return __ret;
        }

        /// <summary>Modify the length of a weak pointer array</summary>
        /// <param name="arrayOfPointersToVariable">The array of weak pointers</param>
        /// <param name="newLength">The new length of the array</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>call when the array length is modified externally</remarks>
        public static bool ATWeakPointerArrayModifyLength(void** arrayOfPointersToVariable, ulong newLength)
        {
            var __ret = __Internal.ATWeakPointerArrayModifyLength(arrayOfPointersToVariable, newLength);
            return __ret;
        }

        /// <summary>Unregister an array of pointers</summary>
        /// <param name="arrayOfPointersToVariable">The array of weak pointers</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>Should be called when the array is deallocated</remarks>
        public static bool ATWeakPointerArrayUnregister(void** arrayOfPointersToVariable)
        {
            var __ret = __Internal.ATWeakPointerArrayUnregister(arrayOfPointersToVariable);
            return __ret;
        }
    }
}
