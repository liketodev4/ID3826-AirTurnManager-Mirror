using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void ATBaseArrayWeakElementRemovedCallback(global::System.IntPtr baseArray, ulong index);

    /// <summary>The struct for ATBaseArray objects. ATBaseArray is an array of objects based on ATBaseRef. Objects are retained when added and released when removed. If initialised as a weak array, objects are not retained when added and when they are deallocated they are removed from the array and the callback is called.</summary>
    public unsafe partial class ATBaseArrayUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 104)]
        public partial struct __Internal
        {
            // PRIVATE - DO NOT USE
            // The super-struct
            [FieldOffset(0)]
            internal global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.__Internal _base;

            // Are the array items weakly stored
            [FieldOffset(64)]
            internal byte _isWeak;

            // The callback when a weak item is removed due to deallocation
            [FieldOffset(72)]
            internal global::System.IntPtr _weakCallback;

            // PUBLIC
            // The capacity of the array
            [FieldOffset(80)]
            internal ulong capacity;

            // A pointer to the array items storage
            [FieldOffset(88)]
            internal global::System.IntPtr items;

            // The array count
            [FieldOffset(96)]
            internal ulong count;

            //[SuppressUnmanagedCodeSecurity]
            //[DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            //    EntryPoint = "??0ATBaseArray@@QEAA@AEBU0@@Z")]
            //internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayNew")]
            internal static extern global::System.IntPtr ATBaseArrayNew(global::System.IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayInit")]
            internal static extern global::System.IntPtr ATBaseArrayInit(global::System.IntPtr array, ulong capacity, bool weak, global::System.IntPtr weakElementRemovedCallback);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayInitWithObjects")]
            internal static extern global::System.IntPtr ATBaseArrayInitWithObjects(global::System.IntPtr array, void** existingObjects, ulong length, bool weak, global::System.IntPtr weakElementRemovedCallback);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayInitWithObjectsNoCopy")]
            internal static extern global::System.IntPtr ATBaseArrayInitWithObjectsNoCopy(global::System.IntPtr array, void** existingObjects, ulong length, ulong capacity, bool weak, global::System.IntPtr weakElementRemovedCallback);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayGetObjectAtIndex")]
            internal static extern global::System.IntPtr ATBaseArrayGetObjectAtIndex(global::System.IntPtr array, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayAppendObject")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayAppendObject(global::System.IntPtr array, global::System.IntPtr objectToAppend);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayInsertObject")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayInsertObject(global::System.IntPtr array, global::System.IntPtr objectToInsert, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayRemoveObject")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayRemoveObject(global::System.IntPtr array, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayRemoveAllObjects")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayRemoveAllObjects(global::System.IntPtr array);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayResize")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayResize(global::System.IntPtr array, ulong newCapacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayCopy")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayCopy(global::System.IntPtr destination, global::System.IntPtr source);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayIsEqual")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayIsEqual(global::System.IntPtr array1, global::System.IntPtr array2);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe __CreateInstance(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATBaseArrayUnsafe(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATBaseArrayUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATBaseArrayUnsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATBaseArrayUnsafe(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Create a new base array object</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        public static global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe ATBaseArrayNew(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe optionalStorage)
        {
            var __arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage.__Instance;
            var __ret = __Internal.ATBaseArrayNew(__arg0);
            global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe)global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a new base array object</summary>
        /// <param name="array">The object to initialize. Can be `NULL` so the result from `ATBaseArrayNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="capacity">The number of object references to allocate space for</param>
        /// <param name="weak">If `true`, creates a weak array and does not retain objects</param>
        /// <param name="weakElementRemovedCallback">Only if weak is `true`, the callback to be called when an object is removed from the array because it was deallocated</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe ATBaseArrayInit(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array, ulong capacity, bool weak, global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_ulong weakElementRemovedCallback)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __arg3 = weakElementRemovedCallback == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(weakElementRemovedCallback);
            var __ret = __Internal.ATBaseArrayInit(__arg0, capacity, weak, __arg3);
            global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe)global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a new base array object with existing objects</summary>
        /// <param name="array">The object to initialize. Can be `NULL` so the result from `ATBaseArrayNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingObjects">A pointer to a buffer of existing object references</param>
        /// <param name="length">The length of the buffer (number of object references)</param>
        /// <param name="weak">If `true`, creates a weak array and does not retain objects</param>
        /// <param name="weakElementRemovedCallback">Only if weak is `true`, the callback to be called when an object is removed from the array because it was deallocated</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe ATBaseArrayInitWithObjects(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array, void** existingObjects, ulong length, bool weak, global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_ulong weakElementRemovedCallback)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __arg4 = weakElementRemovedCallback == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(weakElementRemovedCallback);
            var __ret = __Internal.ATBaseArrayInitWithObjects(__arg0, existingObjects, length, weak, __arg4);
            global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe)global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a new base array object with existing objects using the original buffer without copying</summary>
        /// <param name="array">The object to initialize. Can be `NULL` so the result from `ATBaseArrayNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingObjects">A pointer to a buffer of existing object references</param>
        /// <param name="length">The length of the buffer (number of object references)</param>
        /// <param name="capacity">The capacity of the buffer (number of object references)</param>
        /// <param name="weak">If `true`, creates a weak array and does not retain objects</param>
        /// <param name="weakElementRemovedCallback">Only if weak is `true`, the callback to be called when an object is removed from the array because it was deallocated</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe ATBaseArrayInitWithObjectsNoCopy(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array, void** existingObjects, ulong length, ulong capacity, bool weak, global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_ulong weakElementRemovedCallback)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __arg5 = weakElementRemovedCallback == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(weakElementRemovedCallback);
            var __ret = __Internal.ATBaseArrayInitWithObjectsNoCopy(__arg0, existingObjects, length, capacity, weak, __arg5);
            global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe)global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Get a pointer to an object in the array</summary>
        /// <param name="array">The array</param>
        /// <param name="index">The index of the object to retrieve</param>
        /// <returns>A pointer to the object</returns>
        public static global::System.IntPtr ATBaseArrayGetObjectAtIndex(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array, ulong index)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __ret = __Internal.ATBaseArrayGetObjectAtIndex(__arg0, index);
            return __ret;
        }

        /// <summary>Append an object to the array</summary>
        /// <param name="array">The array</param>
        /// <param name="objectToAppend">A pointer to the item to append</param>
        /// <returns>`true` if successful</returns>
        public static bool ATBaseArrayAppendObject(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array, global::System.IntPtr objectToAppend)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __ret = __Internal.ATBaseArrayAppendObject(__arg0, objectToAppend);
            return __ret;
        }

        /// <summary>Insert an object into the array at a given index</summary>
        /// <param name="array">The array</param>
        /// <param name="objectToInsert">The object to insert</param>
        /// <param name="index">The index to insert the object at</param>
        /// <returns>`true` if successful</returns>
        public static bool ATBaseArrayInsertObject(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array, global::System.IntPtr objectToInsert, ulong index)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __ret = __Internal.ATBaseArrayInsertObject(__arg0, objectToInsert, index);
            return __ret;
        }

        /// <summary>Remove an object from the array at a given index</summary>
        /// <param name="array">The array</param>
        /// <param name="index">The index to remove the object from</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>Will not zero out object pointers above new count</remarks>
        public static bool ATBaseArrayRemoveObject(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array, ulong index)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __ret = __Internal.ATBaseArrayRemoveObject(__arg0, index);
            return __ret;
        }

        /// <summary>Remove all objects</summary>
        /// <param name="array">The array</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>Will not zero out object pointers removed</remarks>
        public static bool ATBaseArrayRemoveAllObjects(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __ret = __Internal.ATBaseArrayRemoveAllObjects(__arg0);
            return __ret;
        }

        /// <summary>Resize an array</summary>
        /// <param name="array">The array</param>
        /// <param name="newCapacity">The new object capacity</param>
        /// <returns>`true` if successful</returns>
        public static bool ATBaseArrayResize(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array, ulong newCapacity)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __ret = __Internal.ATBaseArrayResize(__arg0, newCapacity);
            return __ret;
        }

        /// <summary>Copy an array, retaining all objects for the destination array</summary>
        /// <param name="destination">The destination array</param>
        /// <param name="source">The source array</param>
        /// <returns>`true` if successful</returns>
        public static bool ATBaseArrayCopy(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe destination, global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe source)
        {
            var __arg0 = ReferenceEquals(destination, null) ? global::System.IntPtr.Zero : destination.__Instance;
            var __arg1 = ReferenceEquals(source, null) ? global::System.IntPtr.Zero : source.__Instance;
            var __ret = __Internal.ATBaseArrayCopy(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Determine if two arrays are equal</summary>
        /// <param name="array1">The first array</param>
        /// <param name="array2">The second array</param>
        /// <returns>`true` if the arrays are equal (the pointers in the array are equal)</returns>
        public static bool ATBaseArrayIsEqual(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array1, global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe array2)
        {
            var __arg0 = ReferenceEquals(array1, null) ? global::System.IntPtr.Zero : array1.__Instance;
            var __arg1 = ReferenceEquals(array2, null) ? global::System.IntPtr.Zero : array2.__Instance;
            var __ret = __Internal.ATBaseArrayIsEqual(__arg0, __arg1);
            return __ret;
        }

        public global::AirTurnManager.Api.Foundation.ATGenericArray Base
        {
            get
            {
                return global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.__CreateInstance(new global::System.IntPtr(&((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->_base));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->_base = *(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.__Internal*)value.__Instance;
            }
        }

        public bool IsWeak
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->_isWeak != 0;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->_isWeak = (byte)(value ? 1 : 0);
            }
        }

        public global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_ulong WeakCallback
        {
            get
            {
                var __ptr0 = ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->_weakCallback;
                return __ptr0 == IntPtr.Zero ? null : (global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_ulong)Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_ulong));
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->_weakCallback = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }

        public ulong Capacity
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->capacity;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->capacity = value;
            }
        }

        public void** Items
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->items;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->items = value;
            }
        }

        public ulong Count
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->count;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__Internal*)__Instance)->count = value;
            }
        }
    }
}
