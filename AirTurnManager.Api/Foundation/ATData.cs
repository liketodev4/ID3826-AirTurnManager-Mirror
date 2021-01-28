using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    /// <summary>The struct for ATData objects</summary>
    public unsafe partial class ATDataUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct _Internal
        {
            // PRIVATE - do not use
            /// The super-struct
            [FieldOffset(0)]
            internal Foundation.ATBaseUnsafe._Internal _base;

            /// If this object owns the storage at its bytes pointer
            [FieldOffset(4)]
            internal byte _ownsBytesStorage;

            // PUBLIC
            /// The capacity of the bytes storage.
            [FieldOffset(8)]
            internal ulong capacity;

            /// The data pointer
            [FieldOffset(16)]
            internal IntPtr bytes;

            /// The length of the data (may be shorter than capacity)
            [FieldOffset(24)]
            internal ulong length;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataNew")]
            internal static extern IntPtr ATDataNew(IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataInit")]
            internal static extern IntPtr ATDataInit(IntPtr data);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataInitWithCapacity")]
            internal static extern IntPtr ATDataInitWithCapacity(IntPtr data, ulong capacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataInitWithBytes")]
            internal static extern IntPtr ATDataInitWithBytes(IntPtr data, IntPtr existingData, ulong length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataInitWithBytesNoCopy")]
            internal static extern IntPtr ATDataInitWithBytesNoCopy(IntPtr data, IntPtr existingData, ulong length, ulong capacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataAdoptStorage")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataAdoptStorage(IntPtr data, IntPtr storageToAdopt, ulong capacity, ulong length, bool shouldOwnStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataAppendBytes")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataAppendBytes(IntPtr data, IntPtr bytesToAppend, ulong length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataInsertBytes")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataInsertBytes(IntPtr data, IntPtr bytesToInsert, ulong length, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataRemoveBytes")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataRemoveBytes(IntPtr data, ulong length, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataResetToEmpty")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataResetToEmpty(IntPtr data);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataGetBytes")]
            internal static extern void ATDataGetBytes(IntPtr data, IntPtr bytes, ulong maxLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataGetBytesAtOffset")]
            internal static extern void ATDataGetBytesAtOffset(IntPtr data, IntPtr bytes, ulong offset, ulong maxLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataResizeCapacity")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataResizeCapacity(IntPtr data, ulong newCapacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataResize")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataResize(IntPtr data, ulong newLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataIncreaseLength")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataIncreaseLength(IntPtr data, ulong extraLength, byte fillWith);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataCopy")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataCopy(IntPtr destination, IntPtr source);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataSubdataWithRange")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataSubdataWithRange(IntPtr data, IntPtr subData, ulong offset, ulong length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataSubdataNoCopyWithRange")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataSubdataNoCopyWithRange(IntPtr data, IntPtr subData, ulong offset, ulong length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataIsEqual")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataIsEqual(IntPtr data1, IntPtr data2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATDataOwnsStorage")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataOwnsStorage(IntPtr data);
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATDataUnsafe> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATDataUnsafe>();

        protected bool _ownsNativeInstance;

        internal static Foundation.ATDataUnsafe _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Foundation.ATDataUnsafe(native.ToPointer(), skipVTables);
        }

        internal static Foundation.ATDataUnsafe _CreateInstance(Foundation.ATDataUnsafe._Internal native, bool skipVTables = false)
        {
            return new Foundation.ATDataUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(Foundation.ATDataUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Foundation.ATDataUnsafe._Internal));
            *(Foundation.ATDataUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATDataUnsafe(Foundation.ATDataUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATDataUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATDataUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATDataUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATDataUnsafe(Foundation.ATDataUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATDataUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((Foundation.ATDataUnsafe._Internal*)_Instance) = *((Foundation.ATDataUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            Foundation.ATDataUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        /// <summary>Create a new data object</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. NULL if allocation could not be completed</returns>
        public static Foundation.ATDataUnsafe ATDataNew(Foundation.ATDataUnsafe optionalStorage)
        {
            var _arg0 = ReferenceEquals(optionalStorage, null) ? IntPtr.Zero : optionalStorage._Instance;
            var _ret = _Internal.ATDataNew(_arg0);
            Foundation.ATDataUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATDataUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new data object with empty bytes</summary>
        /// <param name="data">The object to initialize. Can be `NULL` so the result from `ATDataNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static Foundation.ATDataUnsafe ATDataInit(Foundation.ATDataUnsafe data)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataInit(_arg0);
            Foundation.ATDataUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATDataUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Intialise a new data object with a given capacity</summary>
        /// <param name="data">The object to initialize. Can be `NULL` so the result from `ATDataNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="capacity">The capacity to allocate for the data bytes</param>
        /// <returns>The initialised object or `NULL` if initialization failed</returns>
        public static Foundation.ATDataUnsafe ATDataInitWithCapacity(Foundation.ATDataUnsafe data, ulong capacity)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataInitWithCapacity(_arg0, capacity);
            Foundation.ATDataUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATDataUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new data object with given bytes</summary>
        /// <param name="data">The object to initialize. Can be `NULL` so the result from `ATDataNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingData">A pointer to some existing data to copy into the new data object</param>
        /// <param name="length">The length of the existing data</param>
        /// <returns>The initialized data object with the existing data copied in or `NULL` if initialization failed</returns>
        public static Foundation.ATDataUnsafe ATDataInitWithBytes(Foundation.ATDataUnsafe data, IntPtr existingData, ulong length)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataInitWithBytes(_arg0, existingData, length);
            Foundation.ATDataUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATDataUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new data object with given bytes by storing a pointer to the data without copying it</summary>
        /// <param name="data">The object to initialize. Can be `NULL` so the result from `ATDataNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingData">A pointer to some existing data to use in the new data object</param>
        /// <param name="length">The length of the existing data</param>
        /// <param name="capacity">The capacity of the buffer pointed to. This can be larger or the same as the length but not smaller.</param>
        /// <returns>The initialized data object with the existing data copied in or `NULL` if initialization failed</returns>
        public static Foundation.ATDataUnsafe ATDataInitWithBytesNoCopy(Foundation.ATDataUnsafe data, IntPtr existingData, ulong length, ulong capacity)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataInitWithBytesNoCopy(_arg0, existingData, length, capacity);
            Foundation.ATDataUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATDataUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Adopt a given storage buffer as the object's storage buffer</summary>
        /// <param name="data">The data object</param>
        /// <param name="storageToAdopt">The storage buffer to adopt</param>
        /// <param name="capacity">The capacity of the storage buffer</param>
        /// <param name="length">The length of data currently stored in the buffer</param>
        /// <param name="shouldOwnStorage">If this data object should assume ownership of the storage buffer</param>
        /// <returns>`true` if the storage was adopted successfully</returns>
        public static bool ATDataAdoptStorage(Foundation.ATDataUnsafe data, IntPtr storageToAdopt, ulong capacity, ulong length, bool shouldOwnStorage)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataAdoptStorage(_arg0, storageToAdopt, capacity, length, shouldOwnStorage);
            return _ret;
        }

        /// <summary>Append bytes to the data</summary>
        /// <param name="data">The data object</param>
        /// <param name="bytesToAppend">A pointer to bytes to append</param>
        /// <param name="length">The length of the bytes to append</param>
        /// <returns>`true` if appending was successful</returns>
        /// <remarks>The bytes will be copied into the data object's storage buffer</remarks>
        public static bool ATDataAppendBytes(Foundation.ATDataUnsafe data, IntPtr bytesToAppend, ulong length)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataAppendBytes(_arg0, bytesToAppend, length);
            return _ret;
        }

        /// <summary>Insert bytes into the data</summary>
        /// <param name="data">The data object</param>
        /// <param name="bytesToInsert">The bytes to insert</param>
        /// <param name="length">The length of the bytes to insert</param>
        /// <param name="index">The index in the existing data object buffer at which to insert the new data. Must be less than or equal to the data object's length</param>
        /// <returns>`true` if the insertion was successful</returns>
        /// <remarks>The bytes will be copied into the data object's storage buffer at the index specified</remarks>
        public static bool ATDataInsertBytes(Foundation.ATDataUnsafe data, IntPtr bytesToInsert, ulong length, ulong index)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataInsertBytes(_arg0, bytesToInsert, length, index);
            return _ret;
        }

        /// <summary>Remove bytes from the data</summary>
        /// <param name="data">The data object</param>
        /// <param name="length">The length of data to remove</param>
        /// <param name="index">The index from which to remove the data</param>
        /// <returns>`true` if removal was successful</returns>
        /// <remarks>Will not zero out bytes above new length</remarks>
        public static bool ATDataRemoveBytes(Foundation.ATDataUnsafe data, ulong length, ulong index)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataRemoveBytes(_arg0, length, index);
            return _ret;
        }

        /// <summary>Reset to empty</summary>
        /// <param name="data">The data object</param>
        /// <returns>`true` if removal was successful</returns>
        /// <remarks>Will not zero out bytes removed</remarks>
        public static bool ATDataResetToEmpty(Foundation.ATDataUnsafe data)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataResetToEmpty(_arg0);
            return _ret;
        }

        /// <summary>Copy bytes from the data object into a given buffer</summary>
        /// <param name="data">The data object</param>
        /// <param name="bytes">The buffer to copy into</param>
        /// <param name="maxLength">The maximum length of data to copy</param>
        public static void ATDataGetBytes(Foundation.ATDataUnsafe data, IntPtr bytes, ulong maxLength)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            _Internal.ATDataGetBytes(_arg0, bytes, maxLength);
        }

        /// <summary>Copy bytes from the data object at a given start offset into a given buffer</summary>
        /// <param name="data">The data object</param>
        /// <param name="bytes">The buffer to copy into</param>
        /// <param name="offset">The offset in the data object to copy from</param>
        /// <param name="maxLength">The maximum length of data to copy</param>
        public static void ATDataGetBytesAtOffset(Foundation.ATDataUnsafe data, IntPtr bytes, ulong offset, ulong maxLength)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            _Internal.ATDataGetBytesAtOffset(_arg0, bytes, offset, maxLength);
        }

        /// <summary>Resize a data object's buffer</summary>
        /// <param name="data">The data object</param>
        /// <param name="newCapacity">The new size of the data buffer</param>
        /// <returns>`true` if resize was successful. If not the buffer will remain the same size</returns>
        /// <remarks>After resizing, the buffer pointer may change. If the data object does not own the data buffer then it cannot resize it so this will fail.</remarks>
        public static bool ATDataResizeCapacity(Foundation.ATDataUnsafe data, ulong newCapacity)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataResizeCapacity(_arg0, newCapacity);
            return _ret;
        }

        /// <summary>Resize a data object's length</summary>
        /// <param name="data">The data object</param>
        /// <param name="newLength">The new length of the data object. If longer than current capacity, buffer resize will be attempted.</param>
        /// <returns>`true` if resize was successful. If not the buffer and data length will remain the same size</returns>
        /// <remarks>After resizing, the buffer pointer may change. If the data object does not own the data buffer then it cannot resize it so this will fail.</remarks>
        public static bool ATDataResize(Foundation.ATDataUnsafe data, ulong newLength)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataResize(_arg0, newLength);
            return _ret;
        }

        /// <summary>Increase the data length and fill the new data with a given value</summary>
        /// <param name="data">The data object</param>
        /// <param name="extraLength">How much to extend the data length by</param>
        /// <param name="fillWith">The value to fill the new bytes with</param>
        /// <returns>`true` if successful</returns>
        public static bool ATDataIncreaseLength(Foundation.ATDataUnsafe data, ulong extraLength, byte fillWith)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataIncreaseLength(_arg0, extraLength, fillWith);
            return _ret;
        }

        /// <summary>Copy a data object into a new destination object</summary>
        /// <param name="destination">The destination object</param>
        /// <param name="source">The source object</param>
        /// <returns>`true` if the copy was successful</returns>
        /// <remarks>Will also copy the data buffer to the destination's buffer (as much as will fit in the destination capacity without resizing destination)</remarks>
        public static bool ATDataCopy(Foundation.ATDataUnsafe destination, Foundation.ATDataUnsafe source)
        {
            var _arg0 = ReferenceEquals(destination, null) ? IntPtr.Zero : destination._Instance;
            var _arg1 = ReferenceEquals(source, null) ? IntPtr.Zero : source._Instance;
            var _ret = _Internal.ATDataCopy(_arg0, _arg1);
            return _ret;
        }

        /// <summary>Copy a range of data from a data object to a given subdata object</summary>
        /// <param name="data">The data object</param>
        /// <param name="subData">The subdata object to copy into</param>
        /// <param name="offset">The offset to start copying from</param>
        /// <param name="length">The length of data to copy</param>
        /// <returns>`true` if copying was successful</returns>
        /// <remarks>The subdata object must have capacity to contain the full length of data requested</remarks>
        public static bool ATDataSubdataWithRange(Foundation.ATDataUnsafe data, Foundation.ATDataUnsafe subData, ulong offset, ulong length)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _arg1 = ReferenceEquals(subData, null) ? IntPtr.Zero : subData._Instance;
            var _ret = _Internal.ATDataSubdataWithRange(_arg0, _arg1, offset, length);
            return _ret;
        }

        /// <summary>Adopt a range of data into the subData object without copying.</summary>
        /// <param name="data">The data object</param>
        /// <param name="subData">The subdata object to adopt the buffer into</param>
        /// <param name="offset">The offset to start copying from</param>
        /// <param name="length">The length of data to copy</param>
        /// <returns>`true` if adoption was successful</returns>
        /// <remarks>The subData object will simply hold a pointer to the original `data` object's buffer at `offset`.</remarks>
        public static bool ATDataSubdataNoCopyWithRange(Foundation.ATDataUnsafe data, Foundation.ATDataUnsafe subData, ulong offset, ulong length)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _arg1 = ReferenceEquals(subData, null) ? IntPtr.Zero : subData._Instance;
            var _ret = _Internal.ATDataSubdataNoCopyWithRange(_arg0, _arg1, offset, length);
            return _ret;
        }

        /// <summary>Determine if two data objects are equal</summary>
        /// <param name="data1">The first data object</param>
        /// <param name="data2">The second data object</param>
        /// <returns>`true` if the data objects are equal (the bytes in the data buffer are the same and the length is the same)</returns>
        public static bool ATDataIsEqual(Foundation.ATDataUnsafe data1, Foundation.ATDataUnsafe data2)
        {
            var _arg0 = ReferenceEquals(data1, null) ? IntPtr.Zero : data1._Instance;
            var _arg1 = ReferenceEquals(data2, null) ? IntPtr.Zero : data2._Instance;
            var _ret = _Internal.ATDataIsEqual(_arg0, _arg1);
            return _ret;
        }

        /// <summary>Determine if a data object owns its storage buffer</summary>
        /// <param name="data">The data object</param>
        /// <returns>`true` if the data object does own its storage</returns>
        public static bool ATDataOwnsStorage(Foundation.ATDataUnsafe data)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATDataOwnsStorage(_arg0);
            return _ret;
        }

        public Foundation.ATBaseUnsafe Base
        {
            get
            {
                return Foundation.ATBaseUnsafe._CreateInstance(new IntPtr(&((Foundation.ATDataUnsafe._Internal*)_Instance)->_base));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((Foundation.ATDataUnsafe._Internal*)_Instance)->_base = *(Foundation.ATBaseUnsafe._Internal*)value._Instance;
            }
        }

        public bool OwnsBytesStorage
        {
            get
            {
                return ((Foundation.ATDataUnsafe._Internal*)_Instance)->_ownsBytesStorage != 0;
            }

            set
            {
                ((Foundation.ATDataUnsafe._Internal*)_Instance)->_ownsBytesStorage = (byte)(value ? 1 : 0);
            }
        }

        public ulong Capacity
        {
            get
            {
                return ((Foundation.ATDataUnsafe._Internal*)_Instance)->capacity;
            }

            set
            {
                ((Foundation.ATDataUnsafe._Internal*)_Instance)->capacity = value;
            }
        }

        public IntPtr Bytes
        {
            get
            {
                return ((Foundation.ATDataUnsafe._Internal*)_Instance)->bytes;
            }

            set
            {
                ((Foundation.ATDataUnsafe._Internal*)_Instance)->bytes = (IntPtr)value;
            }
        }

        public ulong Length
        {
            get
            {
                return ((Foundation.ATDataUnsafe._Internal*)_Instance)->length;
            }

            set
            {
                ((Foundation.ATDataUnsafe._Internal*)_Instance)->length = value;
            }
        }
    }
}
