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
    public unsafe partial class ATDataEnum : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            // PRIVATE - do not use
            /// The super-struct
            [FieldOffset(0)]
            internal global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal _base;

            /// If this object owns the storage at its bytes pointer
            [FieldOffset(4)]
            internal byte _ownsBytesStorage;

            // PUBLIC
            /// The capacity of the bytes storage.
            [FieldOffset(8)]
            internal ulong capacity;

            /// The data pointer
            [FieldOffset(16)]
            internal global::System.IntPtr bytes;

            /// The length of the data (may be shorter than capacity)
            [FieldOffset(24)]
            internal ulong length;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATData@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataNew")]
            internal static extern global::System.IntPtr ATDataNew(global::System.IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataInit")]
            internal static extern global::System.IntPtr ATDataInit(global::System.IntPtr data);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataInitWithCapacity")]
            internal static extern global::System.IntPtr ATDataInitWithCapacity(global::System.IntPtr data, ulong capacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataInitWithBytes")]
            internal static extern global::System.IntPtr ATDataInitWithBytes(global::System.IntPtr data, global::System.IntPtr existingData, ulong length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataInitWithBytesNoCopy")]
            internal static extern global::System.IntPtr ATDataInitWithBytesNoCopy(global::System.IntPtr data, global::System.IntPtr existingData, ulong length, ulong capacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataAdoptStorage")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataAdoptStorage(global::System.IntPtr data, global::System.IntPtr storageToAdopt, ulong capacity, ulong length, bool shouldOwnStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataAppendBytes")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataAppendBytes(global::System.IntPtr data, global::System.IntPtr bytesToAppend, ulong length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataInsertBytes")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataInsertBytes(global::System.IntPtr data, global::System.IntPtr bytesToInsert, ulong length, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataRemoveBytes")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataRemoveBytes(global::System.IntPtr data, ulong length, ulong index);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataResetToEmpty")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataResetToEmpty(global::System.IntPtr data);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataGetBytes")]
            internal static extern void ATDataGetBytes(global::System.IntPtr data, global::System.IntPtr bytes, ulong maxLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataGetBytesAtOffset")]
            internal static extern void ATDataGetBytesAtOffset(global::System.IntPtr data, global::System.IntPtr bytes, ulong offset, ulong maxLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataResizeCapacity")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataResizeCapacity(global::System.IntPtr data, ulong newCapacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataResize")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataResize(global::System.IntPtr data, ulong newLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataIncreaseLength")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataIncreaseLength(global::System.IntPtr data, ulong extraLength, byte fillWith);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataCopy")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataCopy(global::System.IntPtr destination, global::System.IntPtr source);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataSubdataWithRange")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataSubdataWithRange(global::System.IntPtr data, global::System.IntPtr subData, ulong offset, ulong length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataSubdataNoCopyWithRange")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataSubdataNoCopyWithRange(global::System.IntPtr data, global::System.IntPtr subData, ulong offset, ulong length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataIsEqual")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataIsEqual(global::System.IntPtr data1, global::System.IntPtr data2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataOwnsStorage")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATDataOwnsStorage(global::System.IntPtr data);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATDataEnum> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATDataEnum>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATDataEnum __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATDataEnum(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATDataEnum __CreateInstance(global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATDataEnum(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATDataEnum(global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATDataEnum(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATDataEnum()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATDataEnum(global::AirTurnManager.Api.Foundation.ATDataEnum _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATDataEnum __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Create a new data object</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. NULL if allocation could not be completed</returns>
        public static global::AirTurnManager.Api.Foundation.ATDataEnum ATDataNew(global::AirTurnManager.Api.Foundation.ATDataEnum optionalStorage)
        {
            var __arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage.__Instance;
            var __ret = __Internal.ATDataNew(__arg0);
            global::AirTurnManager.Api.Foundation.ATDataEnum __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATDataEnum.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATDataEnum)global::AirTurnManager.Api.Foundation.ATDataEnum.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATDataEnum.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a new data object with empty bytes</summary>
        /// <param name="data">The object to initialize. Can be `NULL` so the result from `ATDataNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATDataEnum ATDataInit(global::AirTurnManager.Api.Foundation.ATDataEnum data)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataInit(__arg0);
            global::AirTurnManager.Api.Foundation.ATDataEnum __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATDataEnum.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATDataEnum)global::AirTurnManager.Api.Foundation.ATDataEnum.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATDataEnum.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Intialise a new data object with a given capacity</summary>
        /// <param name="data">The object to initialize. Can be `NULL` so the result from `ATDataNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="capacity">The capacity to allocate for the data bytes</param>
        /// <returns>The initialised object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATDataEnum ATDataInitWithCapacity(global::AirTurnManager.Api.Foundation.ATDataEnum data, ulong capacity)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataInitWithCapacity(__arg0, capacity);
            global::AirTurnManager.Api.Foundation.ATDataEnum __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATDataEnum.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATDataEnum)global::AirTurnManager.Api.Foundation.ATDataEnum.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATDataEnum.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a new data object with given bytes</summary>
        /// <param name="data">The object to initialize. Can be `NULL` so the result from `ATDataNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingData">A pointer to some existing data to copy into the new data object</param>
        /// <param name="length">The length of the existing data</param>
        /// <returns>The initialized data object with the existing data copied in or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATDataEnum ATDataInitWithBytes(global::AirTurnManager.Api.Foundation.ATDataEnum data, global::System.IntPtr existingData, ulong length)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataInitWithBytes(__arg0, existingData, length);
            global::AirTurnManager.Api.Foundation.ATDataEnum __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATDataEnum.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATDataEnum)global::AirTurnManager.Api.Foundation.ATDataEnum.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATDataEnum.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a new data object with given bytes by storing a pointer to the data without copying it</summary>
        /// <param name="data">The object to initialize. Can be `NULL` so the result from `ATDataNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingData">A pointer to some existing data to use in the new data object</param>
        /// <param name="length">The length of the existing data</param>
        /// <param name="capacity">The capacity of the buffer pointed to. This can be larger or the same as the length but not smaller.</param>
        /// <returns>The initialized data object with the existing data copied in or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATDataEnum ATDataInitWithBytesNoCopy(global::AirTurnManager.Api.Foundation.ATDataEnum data, global::System.IntPtr existingData, ulong length, ulong capacity)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataInitWithBytesNoCopy(__arg0, existingData, length, capacity);
            global::AirTurnManager.Api.Foundation.ATDataEnum __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATDataEnum.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATDataEnum)global::AirTurnManager.Api.Foundation.ATDataEnum.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATDataEnum.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Adopt a given storage buffer as the object's storage buffer</summary>
        /// <param name="data">The data object</param>
        /// <param name="storageToAdopt">The storage buffer to adopt</param>
        /// <param name="capacity">The capacity of the storage buffer</param>
        /// <param name="length">The length of data currently stored in the buffer</param>
        /// <param name="shouldOwnStorage">If this data object should assume ownership of the storage buffer</param>
        /// <returns>`true` if the storage was adopted successfully</returns>
        public static bool ATDataAdoptStorage(global::AirTurnManager.Api.Foundation.ATDataEnum data, global::System.IntPtr storageToAdopt, ulong capacity, ulong length, bool shouldOwnStorage)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataAdoptStorage(__arg0, storageToAdopt, capacity, length, shouldOwnStorage);
            return __ret;
        }

        /// <summary>Append bytes to the data</summary>
        /// <param name="data">The data object</param>
        /// <param name="bytesToAppend">A pointer to bytes to append</param>
        /// <param name="length">The length of the bytes to append</param>
        /// <returns>`true` if appending was successful</returns>
        /// <remarks>The bytes will be copied into the data object's storage buffer</remarks>
        public static bool ATDataAppendBytes(global::AirTurnManager.Api.Foundation.ATDataEnum data, global::System.IntPtr bytesToAppend, ulong length)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataAppendBytes(__arg0, bytesToAppend, length);
            return __ret;
        }

        /// <summary>Insert bytes into the data</summary>
        /// <param name="data">The data object</param>
        /// <param name="bytesToInsert">The bytes to insert</param>
        /// <param name="length">The length of the bytes to insert</param>
        /// <param name="index">The index in the existing data object buffer at which to insert the new data. Must be less than or equal to the data object's length</param>
        /// <returns>`true` if the insertion was successful</returns>
        /// <remarks>The bytes will be copied into the data object's storage buffer at the index specified</remarks>
        public static bool ATDataInsertBytes(global::AirTurnManager.Api.Foundation.ATDataEnum data, global::System.IntPtr bytesToInsert, ulong length, ulong index)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataInsertBytes(__arg0, bytesToInsert, length, index);
            return __ret;
        }

        /// <summary>Remove bytes from the data</summary>
        /// <param name="data">The data object</param>
        /// <param name="length">The length of data to remove</param>
        /// <param name="index">The index from which to remove the data</param>
        /// <returns>`true` if removal was successful</returns>
        /// <remarks>Will not zero out bytes above new length</remarks>
        public static bool ATDataRemoveBytes(global::AirTurnManager.Api.Foundation.ATDataEnum data, ulong length, ulong index)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataRemoveBytes(__arg0, length, index);
            return __ret;
        }

        /// <summary>Reset to empty</summary>
        /// <param name="data">The data object</param>
        /// <returns>`true` if removal was successful</returns>
        /// <remarks>Will not zero out bytes removed</remarks>
        public static bool ATDataResetToEmpty(global::AirTurnManager.Api.Foundation.ATDataEnum data)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataResetToEmpty(__arg0);
            return __ret;
        }

        /// <summary>Copy bytes from the data object into a given buffer</summary>
        /// <param name="data">The data object</param>
        /// <param name="bytes">The buffer to copy into</param>
        /// <param name="maxLength">The maximum length of data to copy</param>
        public static void ATDataGetBytes(global::AirTurnManager.Api.Foundation.ATDataEnum data, global::System.IntPtr bytes, ulong maxLength)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            __Internal.ATDataGetBytes(__arg0, bytes, maxLength);
        }

        /// <summary>Copy bytes from the data object at a given start offset into a given buffer</summary>
        /// <param name="data">The data object</param>
        /// <param name="bytes">The buffer to copy into</param>
        /// <param name="offset">The offset in the data object to copy from</param>
        /// <param name="maxLength">The maximum length of data to copy</param>
        public static void ATDataGetBytesAtOffset(global::AirTurnManager.Api.Foundation.ATDataEnum data, global::System.IntPtr bytes, ulong offset, ulong maxLength)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            __Internal.ATDataGetBytesAtOffset(__arg0, bytes, offset, maxLength);
        }

        /// <summary>Resize a data object's buffer</summary>
        /// <param name="data">The data object</param>
        /// <param name="newCapacity">The new size of the data buffer</param>
        /// <returns>`true` if resize was successful. If not the buffer will remain the same size</returns>
        /// <remarks>After resizing, the buffer pointer may change. If the data object does not own the data buffer then it cannot resize it so this will fail.</remarks>
        public static bool ATDataResizeCapacity(global::AirTurnManager.Api.Foundation.ATDataEnum data, ulong newCapacity)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataResizeCapacity(__arg0, newCapacity);
            return __ret;
        }

        /// <summary>Resize a data object's length</summary>
        /// <param name="data">The data object</param>
        /// <param name="newLength">The new length of the data object. If longer than current capacity, buffer resize will be attempted.</param>
        /// <returns>`true` if resize was successful. If not the buffer and data length will remain the same size</returns>
        /// <remarks>After resizing, the buffer pointer may change. If the data object does not own the data buffer then it cannot resize it so this will fail.</remarks>
        public static bool ATDataResize(global::AirTurnManager.Api.Foundation.ATDataEnum data, ulong newLength)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataResize(__arg0, newLength);
            return __ret;
        }

        /// <summary>Increase the data length and fill the new data with a given value</summary>
        /// <param name="data">The data object</param>
        /// <param name="extraLength">How much to extend the data length by</param>
        /// <param name="fillWith">The value to fill the new bytes with</param>
        /// <returns>`true` if successful</returns>
        public static bool ATDataIncreaseLength(global::AirTurnManager.Api.Foundation.ATDataEnum data, ulong extraLength, byte fillWith)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataIncreaseLength(__arg0, extraLength, fillWith);
            return __ret;
        }

        /// <summary>Copy a data object into a new destination object</summary>
        /// <param name="destination">The destination object</param>
        /// <param name="source">The source object</param>
        /// <returns>`true` if the copy was successful</returns>
        /// <remarks>Will also copy the data buffer to the destination's buffer (as much as will fit in the destination capacity without resizing destination)</remarks>
        public static bool ATDataCopy(global::AirTurnManager.Api.Foundation.ATDataEnum destination, global::AirTurnManager.Api.Foundation.ATDataEnum source)
        {
            var __arg0 = ReferenceEquals(destination, null) ? global::System.IntPtr.Zero : destination.__Instance;
            var __arg1 = ReferenceEquals(source, null) ? global::System.IntPtr.Zero : source.__Instance;
            var __ret = __Internal.ATDataCopy(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Copy a range of data from a data object to a given subdata object</summary>
        /// <param name="data">The data object</param>
        /// <param name="subData">The subdata object to copy into</param>
        /// <param name="offset">The offset to start copying from</param>
        /// <param name="length">The length of data to copy</param>
        /// <returns>`true` if copying was successful</returns>
        /// <remarks>The subdata object must have capacity to contain the full length of data requested</remarks>
        public static bool ATDataSubdataWithRange(global::AirTurnManager.Api.Foundation.ATDataEnum data, global::AirTurnManager.Api.Foundation.ATDataEnum subData, ulong offset, ulong length)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __arg1 = ReferenceEquals(subData, null) ? global::System.IntPtr.Zero : subData.__Instance;
            var __ret = __Internal.ATDataSubdataWithRange(__arg0, __arg1, offset, length);
            return __ret;
        }

        /// <summary>Adopt a range of data into the subData object without copying.</summary>
        /// <param name="data">The data object</param>
        /// <param name="subData">The subdata object to adopt the buffer into</param>
        /// <param name="offset">The offset to start copying from</param>
        /// <param name="length">The length of data to copy</param>
        /// <returns>`true` if adoption was successful</returns>
        /// <remarks>The subData object will simply hold a pointer to the original `data` object's buffer at `offset`.</remarks>
        public static bool ATDataSubdataNoCopyWithRange(global::AirTurnManager.Api.Foundation.ATDataEnum data, global::AirTurnManager.Api.Foundation.ATDataEnum subData, ulong offset, ulong length)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __arg1 = ReferenceEquals(subData, null) ? global::System.IntPtr.Zero : subData.__Instance;
            var __ret = __Internal.ATDataSubdataNoCopyWithRange(__arg0, __arg1, offset, length);
            return __ret;
        }

        /// <summary>Determine if two data objects are equal</summary>
        /// <param name="data1">The first data object</param>
        /// <param name="data2">The second data object</param>
        /// <returns>`true` if the data objects are equal (the bytes in the data buffer are the same and the length is the same)</returns>
        public static bool ATDataIsEqual(global::AirTurnManager.Api.Foundation.ATDataEnum data1, global::AirTurnManager.Api.Foundation.ATDataEnum data2)
        {
            var __arg0 = ReferenceEquals(data1, null) ? global::System.IntPtr.Zero : data1.__Instance;
            var __arg1 = ReferenceEquals(data2, null) ? global::System.IntPtr.Zero : data2.__Instance;
            var __ret = __Internal.ATDataIsEqual(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Determine if a data object owns its storage buffer</summary>
        /// <param name="data">The data object</param>
        /// <returns>`true` if the data object does own its storage</returns>
        public static bool ATDataOwnsStorage(global::AirTurnManager.Api.Foundation.ATDataEnum data)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATDataOwnsStorage(__arg0);
            return __ret;
        }

        public global::AirTurnManager.Api.Foundation.ATBaseUnsafe Base
        {
            get
            {
                return global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__CreateInstance(new global::System.IntPtr(&((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance)->_base));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance)->_base = *(global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)value.__Instance;
            }
        }

        public bool OwnsBytesStorage
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance)->_ownsBytesStorage != 0;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance)->_ownsBytesStorage = (byte)(value ? 1 : 0);
            }
        }

        public ulong Capacity
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance)->capacity;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance)->capacity = value;
            }
        }

        public global::System.IntPtr Bytes
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance)->bytes;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance)->bytes = (global::System.IntPtr)value;
            }
        }

        public ulong Length
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance)->length;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATDataEnum.__Internal*)__Instance)->length = value;
            }
        }
    }
}
