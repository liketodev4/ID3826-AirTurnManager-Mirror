using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation.Delegates
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate IntPtr Func_IntPtr_ulong(ulong size);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void Action_IntPtr_ulong(IntPtr ptr, ulong size);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate IntPtr Func_IntPtr_IntPtr_ulong_ulong(IntPtr ptr, ulong new_size, ulong prev_size);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void Action_IntPtr_ulong_IntPtr(IntPtr reference, ulong index, IntPtr context);
}

namespace AirTurnManager.Api.Foundation
{
    /// <summary>Hook called when the module calls malloc() to allocate memory.</summary>
    /// <param name="size">- number of bytes</param>
    /// <returns>- Pointer to the allocated memory</returns>
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate IntPtr ATMallocHook(ulong size);

    /// <summary>Hook called when the module calls free() to free memory.</summary>
    /// <param name="ptr">The pointer to the memory to free</param>
    /// <param name="size">The number of bytes that were previously allocated</param>
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void ATFreeHook(IntPtr ptr, ulong size);

    /// <summary>Hook called when the module calls realloc() to reallocate memory.</summary>
    /// <param name="ptr">The pointer to the memory to reallocate</param>
    /// <param name="new_size">The desired new size of the allocated memory</param>
    /// <param name="prev_size">The previous size of the allocated memory</param>
    /// <returns>- Pointer to the reallocated memory</returns>
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate IntPtr ATReallocHook(IntPtr ptr, ulong new_size, ulong prev_size);

    /// <summary>A function definition for a weak pointer array element free'd callback</summary>
    /// <param name="reference">A pointer to the memory that has just been free'd</param>
    /// <param name="index">The index of the object in its array</param>
    /// <param name="context">Context provided when registering the callback</param>
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void ATWeakPointerArrayElementFreedCallback(IntPtr reference, ulong index, IntPtr context);

    public unsafe partial class ATMallocUnsafe
    {
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATMalloc")]
            internal static extern IntPtr ATMalloc(ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATRealloc")]
            internal static extern IntPtr ATRealloc(IntPtr pointer, ulong new_size, ulong previous_size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATFree")]
            internal static extern void ATFree(IntPtr pointer, ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATMallocHookRegister")]
            internal static extern void ATMallocHookRegister(IntPtr mallocHook);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATFreeHookRegister")]
            internal static extern void ATFreeHookRegister(IntPtr freeHook);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATReallocHookRegister")]
            internal static extern void ATReallocHookRegister(IntPtr reallocHook);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATWeakPointerRegister")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATWeakPointerRegister(void** pointerToPointerToVariable);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATWeakPointerArrayRegister")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATWeakPointerArrayRegister(void** arrayOfPointersToVariable, ulong length, IntPtr context, IntPtr callback);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATWeakPointerArrayModifyLength")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATWeakPointerArrayModifyLength(void** arrayOfPointersToVariable, ulong newLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATWeakPointerArrayUnregister")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATWeakPointerArrayUnregister(void** arrayOfPointersToVariable);
        }

        /// <summary>Allocate memory from the heap</summary>
        /// <param name="size">The size of the memory to allocate</param>
        /// <returns>A pointer to the allocated memory, or `NULL` if unsuccessful</returns>
        public static IntPtr ATMalloc_(ulong size)
        {
            var _ret = _Internal.ATMalloc(size);
            return _ret;
        }

        /// <summary>Reallocate memory</summary>
        /// <param name="pointer">A pointer to the existing memory</param>
        /// <param name="new_size">The new size of the memory</param>
        /// <param name="previous_size">The previous size of the memory</param>
        /// <returns>A pointer to the allocated memory, or `NULL` if unsuccessful</returns>
        /// <remarks>If unsuccessful, the original pointer will remain valid</remarks>
        public static IntPtr ATRealloc(IntPtr pointer, ulong new_size, ulong previous_size)
        {
            var _ret = _Internal.ATRealloc(pointer, new_size, previous_size);
            return _ret;
        }

        /// <summary>Free memory</summary>
        /// <param name="pointer">A pointer to the memory</param>
        /// <param name="size">The size of the allocated memory</param>
        public static void ATFree(IntPtr pointer, ulong size)
        {
            _Internal.ATFree(pointer, size);
        }

        /// <summary>Allows the user to register a function that will get called when the module calls malloc().</summary>
        public static void ATMallocHookRegister(Foundation.Delegates.Func_IntPtr_ulong mallocHook)
        {
            var _arg0 = mallocHook == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(mallocHook);
            _Internal.ATMallocHookRegister(_arg0);
        }

        /// <summary>Allows the user to register a function that will get called when the module calls free().</summary>
        public static void ATFreeHookRegister(Foundation.Delegates.Action_IntPtr_ulong freeHook)
        {
            var _arg0 = freeHook == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(freeHook);
            _Internal.ATFreeHookRegister(_arg0);
        }

        /// <summary>Allows the user to register a function that will get called when the module calls realloc().</summary>
        public static void ATReallocHookRegister(Foundation.Delegates.Func_IntPtr_IntPtr_ulong_ulong reallocHook)
        {
            var _arg0 = reallocHook == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(reallocHook);
            _Internal.ATReallocHookRegister(_arg0);
        }

        /// <summary>Register a weak pointer. When the memory the pointer is pointed to is free'd, the pointer is set to NULL</summary>
        /// <param name="pointerToPointerToVariable">A pointer to a pointer to some allocated memory</param>
        /// <returns>`true` if registration was successful</returns>
        public static bool ATWeakPointerRegister(void** pointerToPointerToVariable)
        {
            var _ret = _Internal.ATWeakPointerRegister(pointerToPointerToVariable);
            return _ret;
        }

        /// <summary>Register an array of weak pointers</summary>
        /// <param name="arrayOfPointersToVariable">The array of weak pointers</param>
        /// <param name="length">The length of the array</param>
        /// <param name="context">The context to provide when the callback function is called</param>
        /// <param name="callback">The callback function</param>
        /// <returns>`true` if registration was successful</returns>
        /// <remarks>When an array of pointers is registered, if any of the memory pointed to by any of the pointers is free'd, the pointer to that memory will be removed from the array and the callback will be called. Call `ATWeakPointerArrayUnregister` when the array is deallocated</remarks>
        public static bool ATWeakPointerArrayRegister(void** arrayOfPointersToVariable, ulong length, IntPtr context, Foundation.Delegates.Action_IntPtr_ulong_IntPtr callback)
        {
            var _arg3 = callback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback);
            var _ret = _Internal.ATWeakPointerArrayRegister(arrayOfPointersToVariable, length, context, _arg3);
            return _ret;
        }

        /// <summary>Modify the length of a weak pointer array</summary>
        /// <param name="arrayOfPointersToVariable">The array of weak pointers</param>
        /// <param name="newLength">The new length of the array</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>call when the array length is modified externally</remarks>
        public static bool ATWeakPointerArrayModifyLength(void** arrayOfPointersToVariable, ulong newLength)
        {
            var _ret = _Internal.ATWeakPointerArrayModifyLength(arrayOfPointersToVariable, newLength);
            return _ret;
        }

        /// <summary>Unregister an array of pointers</summary>
        /// <param name="arrayOfPointersToVariable">The array of weak pointers</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>Should be called when the array is deallocated</remarks>
        public static bool ATWeakPointerArrayUnregister(void** arrayOfPointersToVariable)
        {
            var _ret = _Internal.ATWeakPointerArrayUnregister(arrayOfPointersToVariable);
            return _ret;
        }
    }
}
