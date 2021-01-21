﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    /// <summary>The struct for generic array objects. A generic array is an array of values of a user defined length</summary>
    public unsafe partial class ATGenericArrayUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct _Internal
        {
            // PRIVATE - DO NOT USE
            // The super-struct
            [FieldOffset(0)]
            internal global::AirTurnManager.Api.Foundation.ATDataUnsafe._Internal _base;

            //The number of bytes per item
            [FieldOffset(32)]
            internal ulong _bytesPerItem;

            // PUBLIC
            // The capacity of the array (number of items)
            [FieldOffset(40)]
            internal ulong capacity;

            // A pointer to the items storage
            [FieldOffset(48)]
            internal global::System.IntPtr items;

            // The number of items stored in the array
            [FieldOffset(56)]
            internal ulong count;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATGenericArray@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr _instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayNew")]
            internal static extern global::System.IntPtr ATGenericArrayNew(global::System.IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayInit")]
            internal static extern global::System.IntPtr ATGenericArrayInit(global::System.IntPtr array, ulong capacity, ulong bytesPerItem);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayInitWithItems")]
            internal static extern global::System.IntPtr ATGenericArrayInitWithItems(global::System.IntPtr array, global::System.IntPtr existingData, ulong length, ulong bytesPerItem);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayInitWithItemsNoCopy")]
            internal static extern global::System.IntPtr ATGenericArrayInitWithItemsNoCopy(global::System.IntPtr array, global::System.IntPtr existingData, ulong length, ulong capacity, ulong bytesPerItem);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayGetPointerForItem")]
            internal static extern global::System.IntPtr ATGenericArrayGetPointerForItem(global::System.IntPtr array, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayAppendItem")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATGenericArrayAppendItem(global::System.IntPtr array, global::System.IntPtr itemToAppend);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayInsertItem")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATGenericArrayInsertItem(global::System.IntPtr array, global::System.IntPtr itemToInsert, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayRemoveItem")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATGenericArrayRemoveItem(global::System.IntPtr array, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayRemoveAllItems")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATGenericArrayRemoveAllItems(global::System.IntPtr array);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayResize")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATGenericArrayResize(global::System.IntPtr array, ulong newCapacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayCopy")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATGenericArrayCopy(global::System.IntPtr destination, global::System.IntPtr source);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArrayIsEqual")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATGenericArrayIsEqual(global::System.IntPtr array1, global::System.IntPtr array2);
        }

        public global::System.IntPtr _Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe>();

        protected bool _ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe _CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe _CreateInstance(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal));
            *(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATGenericArrayUnsafe(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATGenericArrayUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new global::System.IntPtr(native);
        }

        public ATGenericArrayUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATGenericArrayUnsafe(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance) = *((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        /// <summary>Create a new generic array object</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        public static global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe ATGenericArrayNew(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe optionalStorage)
        {
            var _arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage._Instance;
            var _ret = _Internal.ATGenericArrayNew(_arg0);
            global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe)global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.NativeToManagedMap[_ret];
            else _result0 = global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new generic array object</summary>
        /// <param name="array">The object to initialize. Can be `NULL` so the result from `ATGenericArrayNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="capacity">The number of items to allocate space for</param>
        /// <param name="bytesPerItem">The number of bytes per item</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe ATGenericArrayInit(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array, ulong capacity, ulong bytesPerItem)
        {
            var _arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATGenericArrayInit(_arg0, capacity, bytesPerItem);
            global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe)global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.NativeToManagedMap[_ret];
            else _result0 = global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new generic array object from existing data</summary>
        /// <param name="array">The object to initialize. Can be `NULL` so the result from `ATGenericArrayNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingData">The existing data to copy from</param>
        /// <param name="length">The length of the existing data (number of items)</param>
        /// <param name="bytesPerItem">The number of bytes per item</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe ATGenericArrayInitWithItems(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array, global::System.IntPtr existingData, ulong length, ulong bytesPerItem)
        {
            var _arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATGenericArrayInitWithItems(_arg0, existingData, length, bytesPerItem);
            global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe)global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.NativeToManagedMap[_ret];
            else _result0 = global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new generic array object from existing data by storing a pointer to the data without copying it</summary>
        /// <param name="array">The object to initialize. Can be `NULL` so the result from `ATGenericArrayNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingData">The existing data to use</param>
        /// <param name="length">The length of the existing data (number of items)</param>
        /// <param name="capacity">The capacity of the existing data buffer (number of items)</param>
        /// <param name="bytesPerItem">The number of bytes per item</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe ATGenericArrayInitWithItemsNoCopy(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array, global::System.IntPtr existingData, ulong length, ulong capacity, ulong bytesPerItem)
        {
            var _arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATGenericArrayInitWithItemsNoCopy(_arg0, existingData, length, capacity, bytesPerItem);
            global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe)global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.NativeToManagedMap[_ret];
            else _result0 = global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Get a pointer to an item in the array</summary>
        /// <param name="array">The array</param>
        /// <param name="index">The index of the item to retrieve</param>
        /// <returns>A pointer to the item</returns>
        public static global::System.IntPtr ATGenericArrayGetPointerForItem(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array, ulong index)
        {
            var _arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATGenericArrayGetPointerForItem(_arg0, index);
            return _ret;
        }

        /// <summary>Append an item to the array</summary>
        /// <param name="array">The array</param>
        /// <param name="itemToAppend">A pointer to the item to append</param>
        /// <returns>`true` if successful</returns>
        public static bool ATGenericArrayAppendItem(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array, global::System.IntPtr itemToAppend)
        {
            var _arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATGenericArrayAppendItem(_arg0, itemToAppend);
            return _ret;
        }

        /// <summary>Insert an item into the array at a given index</summary>
        /// <param name="array">The array</param>
        /// <param name="itemToInsert">The item to insert</param>
        /// <param name="index">The index to insert the item at</param>
        /// <returns>`true` if successful</returns>
        public static bool ATGenericArrayInsertItem(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array, global::System.IntPtr itemToInsert, ulong index)
        {
            var _arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATGenericArrayInsertItem(_arg0, itemToInsert, index);
            return _ret;
        }

        /// <summary>Remove an item from the array at a given index</summary>
        /// <param name="array">The array</param>
        /// <param name="index">The index to remove the item from</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>Will not zero out items above new length</remarks>
        public static bool ATGenericArrayRemoveItem(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array, ulong index)
        {
            var _arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATGenericArrayRemoveItem(_arg0, index);
            return _ret;
        }

        /// <summary>Remove all items</summary>
        /// <param name="array">The array</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>Will not zero out items removed</remarks>
        public static bool ATGenericArrayRemoveAllItems(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array)
        {
            var _arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATGenericArrayRemoveAllItems(_arg0);
            return _ret;
        }

        /// <summary>Resize an array</summary>
        /// <param name="array">The array</param>
        /// <param name="newCapacity">The new item capacity</param>
        /// <returns>`true` if successful</returns>
        public static bool ATGenericArrayResize(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array, ulong newCapacity)
        {
            var _arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array._Instance;
            var _ret = _Internal.ATGenericArrayResize(_arg0, newCapacity);
            return _ret;
        }

        /// <summary>Copy an array. Will attempt to resize destination if destination capacity is less than source length</summary>
        /// <param name="destination">The destination array</param>
        /// <param name="source">The source array</param>
        /// <returns>`true` if successful</returns>
        public static bool ATGenericArrayCopy(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe destination, global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe source)
        {
            var _arg0 = ReferenceEquals(destination, null) ? global::System.IntPtr.Zero : destination._Instance;
            var _arg1 = ReferenceEquals(source, null) ? global::System.IntPtr.Zero : source._Instance;
            var _ret = _Internal.ATGenericArrayCopy(_arg0, _arg1);
            return _ret;
        }

        /// <summary>Determine if two arrays are equal</summary>
        /// <param name="array1">The first array</param>
        /// <param name="array2">The second array</param>
        /// <returns>`true` if the arrays are equal (the contents of the array are equal)</returns>
        public static bool ATGenericArrayIsEqual(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array1, global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe array2)
        {
            var _arg0 = ReferenceEquals(array1, null) ? global::System.IntPtr.Zero : array1._Instance;
            var _arg1 = ReferenceEquals(array2, null) ? global::System.IntPtr.Zero : array2._Instance;
            var _ret = _Internal.ATGenericArrayIsEqual(_arg0, _arg1);
            return _ret;
        }

        public global::AirTurnManager.Api.Foundation.ATDataUnsafe Base
        {
            get
            {
                return global::AirTurnManager.Api.Foundation.ATDataUnsafe._CreateInstance(new global::System.IntPtr(&((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance)->_base));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance)->_base = *(global::AirTurnManager.Api.Foundation.ATDataUnsafe._Internal*)value._Instance;
            }
        }

        public ulong BytesPerItem
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance)->_bytesPerItem;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance)->_bytesPerItem = value;
            }
        }

        public ulong Capacity
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance)->capacity;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance)->capacity = value;
            }
        }

        public global::System.IntPtr Items
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance)->items;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance)->items = (global::System.IntPtr)value;
            }
        }

        public ulong Count
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance)->count;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe._Internal*)_Instance)->count = value;
            }
        }
    }
}
