﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ATBaseArrayWeakElementRemovedCallback(IntPtr baseArray, ulong index);

    // The struct for ATBaseArray objects. ATBaseArray is an array of objects based on ATBaseRef. Objects are retained when added and released when removed. If initialised as a weak array, objects are not retained when added and when they are deallocated they are removed from the array and the callback is called.
    public unsafe partial class ATBaseArrayUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 104)]
        public partial struct _Internal
        {
            // PRIVATE - DO NOT USE
            // The super-struct
            [FieldOffset(0)]
            internal Foundation.ATGenericArrayUnsafe._Internal _base;

            // Are the array items weakly stored
            [FieldOffset(64)]
            internal byte _isWeak;

            // The callback when a weak item is removed due to deallocation
            [FieldOffset(72)]
            internal IntPtr _weakCallback;

            // PUBLIC
            // The capacity of the array
            [FieldOffset(80)]
            internal ulong capacity;

            // A pointer to the array items storage
            [FieldOffset(88)]
            internal IntPtr items;

            // The array count
            [FieldOffset(96)]
            internal ulong count;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayNew")]
            internal static extern IntPtr ATBaseArrayNew(IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayInit")]
            internal static extern IntPtr ATBaseArrayInit(IntPtr array, ulong capacity, bool weak, IntPtr weakElementRemovedCallback);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayInitWithObjects")]
            internal static extern IntPtr ATBaseArrayInitWithObjects(IntPtr array, void** existingObjects, ulong length, bool weak, IntPtr weakElementRemovedCallback);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayInitWithObjectsNoCopy")]
            internal static extern IntPtr ATBaseArrayInitWithObjectsNoCopy(IntPtr array, void** existingObjects, ulong length, ulong capacity, bool weak, IntPtr weakElementRemovedCallback);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayGetObjectAtIndex")]
            internal static extern IntPtr ATBaseArrayGetObjectAtIndex(IntPtr array, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayAppendObject")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayAppendObject(IntPtr array, IntPtr objectToAppend);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayInsertObject")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayInsertObject(IntPtr array, IntPtr objectToInsert, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayRemoveObject")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayRemoveObject(IntPtr array, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayRemoveAllObjects")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayRemoveAllObjects(IntPtr array);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayResize")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayResize(IntPtr array, ulong newCapacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayCopy")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayCopy(IntPtr destination, IntPtr source);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseArrayIsEqual")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseArrayIsEqual(IntPtr array1, IntPtr array2);
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATBaseArrayUnsafe> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATBaseArrayUnsafe>();

        protected bool _ownsNativeInstance;

        internal static Foundation.ATBaseArrayUnsafe _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Foundation.ATBaseArrayUnsafe(native.ToPointer(), skipVTables);
        }

        internal static Foundation.ATBaseArrayUnsafe _CreateInstance(Foundation.ATBaseArrayUnsafe._Internal native, bool skipVTables = false)
        {
            return new Foundation.ATBaseArrayUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(Foundation.ATBaseArrayUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Foundation.ATBaseArrayUnsafe._Internal));
            *(Foundation.ATBaseArrayUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATBaseArrayUnsafe(Foundation.ATBaseArrayUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATBaseArrayUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATBaseArrayUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATBaseArrayUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATBaseArrayUnsafe(Foundation.ATBaseArrayUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATBaseArrayUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((Foundation.ATBaseArrayUnsafe._Internal*)_Instance) = *((Foundation.ATBaseArrayUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            Foundation.ATBaseArrayUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        /// <summary>Create a new base array object</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        public static Foundation.ATBaseArrayUnsafe ATBaseArrayNew(Foundation.ATBaseArrayUnsafe optionalStorage)
        {
            var _arg0 = ReferenceEquals(optionalStorage, null) ? IntPtr.Zero : optionalStorage._Instance;
            var _ret = _Internal.ATBaseArrayNew(_arg0);
            Foundation.ATBaseArrayUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATBaseArrayUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATBaseArrayUnsafe)Foundation.ATBaseArrayUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATBaseArrayUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new base array object</summary>
        /// <param name="array">The object to initialize. Can be `NULL` so the result from `ATBaseArrayNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="capacity">The number of object references to allocate space for</param>
        /// <param name="weak">If `true`, creates a weak array and does not retain objects</param>
        /// <param name="weakElementRemovedCallback">Only if weak is `true`, the callback to be called when an object is removed from the array because it was deallocated</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static Foundation.ATBaseArrayUnsafe ATBaseArrayInit(Foundation.ATBaseArrayUnsafe array, ulong capacity, bool weak, Foundation.Delegates.Action_IntPtr_ulong weakElementRemovedCallback)
        {
            var _arg0 = ReferenceEquals(array, null) ? IntPtr.Zero : array._Instance;
            var _arg3 = weakElementRemovedCallback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(weakElementRemovedCallback);
            var _ret = _Internal.ATBaseArrayInit(_arg0, capacity, weak, _arg3);
            Foundation.ATBaseArrayUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATBaseArrayUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATBaseArrayUnsafe)Foundation.ATBaseArrayUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATBaseArrayUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new base array object with existing objects</summary>
        /// <param name="array">The object to initialize. Can be `NULL` so the result from `ATBaseArrayNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingObjects">A pointer to a buffer of existing object references</param>
        /// <param name="length">The length of the buffer (number of object references)</param>
        /// <param name="weak">If `true`, creates a weak array and does not retain objects</param>
        /// <param name="weakElementRemovedCallback">Only if weak is `true`, the callback to be called when an object is removed from the array because it was deallocated</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static Foundation.ATBaseArrayUnsafe ATBaseArrayInitWithObjects(Foundation.ATBaseArrayUnsafe array, void** existingObjects, ulong length, bool weak, Foundation.Delegates.Action_IntPtr_ulong weakElementRemovedCallback)
        {
            var _arg0 = ReferenceEquals(array, null) ? IntPtr.Zero : array._Instance;
            var _arg4 = weakElementRemovedCallback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(weakElementRemovedCallback);
            var _ret = _Internal.ATBaseArrayInitWithObjects(_arg0, existingObjects, length, weak, _arg4);
            Foundation.ATBaseArrayUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATBaseArrayUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATBaseArrayUnsafe)Foundation.ATBaseArrayUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATBaseArrayUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new base array object with existing objects using the original buffer without copying</summary>
        /// <param name="array">The object to initialize. Can be `NULL` so the result from `ATBaseArrayNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingObjects">A pointer to a buffer of existing object references</param>
        /// <param name="length">The length of the buffer (number of object references)</param>
        /// <param name="capacity">The capacity of the buffer (number of object references)</param>
        /// <param name="weak">If `true`, creates a weak array and does not retain objects</param>
        /// <param name="weakElementRemovedCallback">Only if weak is `true`, the callback to be called when an object is removed from the array because it was deallocated</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static Foundation.ATBaseArrayUnsafe ATBaseArrayInitWithObjectsNoCopy(Foundation.ATBaseArrayUnsafe array, void** existingObjects, ulong length, ulong capacity, bool weak, Foundation.Delegates.Action_IntPtr_ulong weakElementRemovedCallback)
        {
            var _arg0 = ReferenceEquals(array, null) ? IntPtr.Zero : array._Instance;
            var _arg5 = weakElementRemovedCallback == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(weakElementRemovedCallback);
            var _ret = _Internal.ATBaseArrayInitWithObjectsNoCopy(_arg0, existingObjects, length, capacity, weak, _arg5);
            Foundation.ATBaseArrayUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATBaseArrayUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATBaseArrayUnsafe)Foundation.ATBaseArrayUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATBaseArrayUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Get a pointer to an object in the array</summary>
        /// <param name="array">The array</param>
        /// <param name="index">The index of the object to retrieve</param>
        /// <returns>A pointer to the object</returns>
        public static IntPtr ATBaseArrayGetObjectAtIndex(Foundation.ATBaseArrayUnsafe array, ulong index)
        {
            var _arg0 = ReferenceEquals(array, null) ? IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATBaseArrayGetObjectAtIndex(_arg0, index);
            return _ret;
        }

        /// <summary>Append an object to the array</summary>
        /// <param name="array">The array</param>
        /// <param name="objectToAppend">A pointer to the item to append</param>
        /// <returns>`true` if successful</returns>
        public static bool ATBaseArrayAppendObject(Foundation.ATBaseArrayUnsafe array, IntPtr objectToAppend)
        {
            var _arg0 = ReferenceEquals(array, null) ? IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATBaseArrayAppendObject(_arg0, objectToAppend);
            return _ret;
        }

        /// <summary>Insert an object into the array at a given index</summary>
        /// <param name="array">The array</param>
        /// <param name="objectToInsert">The object to insert</param>
        /// <param name="index">The index to insert the object at</param>
        /// <returns>`true` if successful</returns>
        public static bool ATBaseArrayInsertObject(Foundation.ATBaseArrayUnsafe array, IntPtr objectToInsert, ulong index)
        {
            var _arg0 = ReferenceEquals(array, null) ? IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATBaseArrayInsertObject(_arg0, objectToInsert, index);
            return _ret;
        }

        /// <summary>Remove an object from the array at a given index</summary>
        /// <param name="array">The array</param>
        /// <param name="index">The index to remove the object from</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>Will not zero out object pointers above new count</remarks>
        public static bool ATBaseArrayRemoveObject(Foundation.ATBaseArrayUnsafe array, ulong index)
        {
            var _arg0 = ReferenceEquals(array, null) ? IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATBaseArrayRemoveObject(_arg0, index);
            return _ret;
        }

        /// <summary>Remove all objects</summary>
        /// <param name="array">The array</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>Will not zero out object pointers removed</remarks>
        public static bool ATBaseArrayRemoveAllObjects(Foundation.ATBaseArrayUnsafe array)
        {
            var _arg0 = ReferenceEquals(array, null) ? IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATBaseArrayRemoveAllObjects(_arg0);
            return _ret;
        }

        /// <summary>Resize an array</summary>
        /// <param name="array">The array</param>
        /// <param name="newCapacity">The new object capacity</param>
        /// <returns>`true` if successful</returns>
        public static bool ATBaseArrayResize(Foundation.ATBaseArrayUnsafe array, ulong newCapacity)
        {
            var _arg0 = ReferenceEquals(array, null) ? IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATBaseArrayResize(_arg0, newCapacity);
            return _ret;
        }

        /// <summary>Copy an array, retaining all objects for the destination array</summary>
        /// <param name="destination">The destination array</param>
        /// <param name="source">The source array</param>
        /// <returns>`true` if successful</returns>
        public static bool ATBaseArrayCopy(Foundation.ATBaseArrayUnsafe destination, Foundation.ATBaseArrayUnsafe source)
        {
            var _arg0 = ReferenceEquals(destination, null) ? IntPtr.Zero : destination._Instance;
            var _arg1 = ReferenceEquals(source, null) ? IntPtr.Zero : source._Instance;
            var _ret = _Internal.ATBaseArrayCopy(_arg0, _arg1);
            return _ret;
        }

        /// <summary>Determine if two arrays are equal</summary>
        /// <param name="array1">The first array</param>
        /// <param name="array2">The second array</param>
        /// <returns>`true` if the arrays are equal (the pointers in the array are equal)</returns>
        public static bool ATBaseArrayIsEqual(Foundation.ATBaseArrayUnsafe array1, Foundation.ATBaseArrayUnsafe array2)
        {
            var _arg0 = ReferenceEquals(array1, null) ? IntPtr.Zero : array1._Instance;
            var _arg1 = ReferenceEquals(array2, null) ? IntPtr.Zero : array2._Instance;
            var _ret = _Internal.ATBaseArrayIsEqual(_arg0, _arg1);
            return _ret;
        }

        public Foundation.ATGenericArrayUnsafe Base
        {
            get
            {
                return Foundation.ATGenericArrayUnsafe._CreateInstance(new IntPtr(&((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->_base));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->_base = *(Foundation.ATGenericArrayUnsafe._Internal*)value._Instance;
            }
        }

        public bool IsWeak
        {
            get
            {
                return ((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->_isWeak != 0;
            }

            set
            {
                ((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->_isWeak = (byte)(value ? 1 : 0);
            }
        }

        public Foundation.Delegates.Action_IntPtr_ulong WeakCallback
        {
            get
            {
                var _ptr0 = ((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->_weakCallback;
                return _ptr0 == IntPtr.Zero ? null : (Foundation.Delegates.Action_IntPtr_ulong)Marshal.GetDelegateForFunctionPointer(_ptr0, typeof(Foundation.Delegates.Action_IntPtr_ulong));
            }

            set
            {
                ((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->_weakCallback = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }

        public ulong Capacity
        {
            get
            {
                return ((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->capacity;
            }

            set
            {
                ((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->capacity = value;
            }
        }

        public void** Items
        {
            get
            {
                return (void**)((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->items;
            }

            set
            {
                ((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->items = (IntPtr)value;
            }
        }

        public ulong Count
        {
            get
            {
                return ((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->count;
            }

            set
            {
                ((Foundation.ATBaseArrayUnsafe._Internal*)_Instance)->count = value;
            }
        }
    }
}
