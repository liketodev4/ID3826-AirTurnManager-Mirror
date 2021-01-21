using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    /// <summary>Enum for all types of ATSharedComponent Objects</summary>
    public enum ATObjectType : byte
    {
        ATObjectTypeInvalid = 0,
        ATObjectTypeATBase = 1,
        ATObjectTypeATData = 2,
        ATObjectTypeATString = 3,
        ATObjectTypeATGenericArray = 4,
        ATObjectTypeATBaseArray = 5,
        ATObjectTypeATPortConfigItemValue = 6,
        ATObjectTypeATPortConfigItem = 7,
        ATObjectTypeATPortConfig = 8,
        ATObjectTypeATConfig = 9,
        ATObjectTypeATAnalogPortConfig = 10,
        ATObjectTypeATAnalogInputConfig = 11,
        ATObjectTypeATAnalogInputConfigManager = 12,
        ATObjectTypeExternal = 13
    }

    /// <summary>A generic pointer reference representing any object derived from ATBase</summary>
    /// <summary>The ATBase Structure, the root struct of all objects based on ATBase. Do not access any properties directly from external code, use the helper functions below.</summary>
    public unsafe partial class ATBaseUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            // A predefined static signature, the value is the same between all objects. Used to determine if a pointer is to an ATBase object or if an ATBase object has been corrupted.
            [FieldOffset(0)]
            internal byte _signature;

            // The retain count of the object. On creating a new object this is 1. Retaining the object increases the retain count, releasing decreases the count. When 0, object is free'd
            [FieldOffset(1)]
            internal byte _retainCount;

            // If the struct storage is owned by the object then it will be free'd when the retain count is 0
            [FieldOffset(2)]
            internal byte _ownsMemory;

            // true if init has completed
            [FieldOffset(2)]
            internal byte _hasInitCompleted;

            // The type of the object
            [FieldOffset(3)]
            internal global::AirTurnManager.Api.Foundation.ATObjectType _type;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseNew")]
            internal static extern global::System.IntPtr ATBaseNew(global::System.IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseInit")]
            internal static extern global::System.IntPtr ATBaseInit(global::System.IntPtr @base);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseCopy")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATBaseCopy(global::System.IntPtr destination, global::System.IntPtr source);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATRetain")]
            internal static extern global::System.IntPtr ATRetain(global::System.IntPtr @object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATRelease")]
            internal static extern global::System.IntPtr ATRelease(global::System.IntPtr @object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGetType")]
            internal static extern global::AirTurnManager.Api.Foundation.ATObjectType ATGetType(global::System.IntPtr @object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGetRetainCount")]
            internal static extern byte ATGetRetainCount(global::System.IntPtr @object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATObjectIsInitialized")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATObjectIsInitialized(global::System.IntPtr @object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATObjectIsShared")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATObjectIsShared(global::System.IntPtr @object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGetDescriptionForType")]
            internal static extern global::System.IntPtr ATGetDescriptionForType(global::AirTurnManager.Api.Foundation.ATObjectType type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGetDescription")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATGetDescription(global::System.IntPtr @object, global::System.IntPtr @string);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGetDebugDescription")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATGetDebugDescription(global::System.IntPtr @object, global::System.IntPtr @string);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPrintDescription")]
            internal static extern void ATPrintDescription(global::System.IntPtr @object);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPrintDebugDescription")]
            internal static extern void ATPrintDebugDescription(global::System.IntPtr @object);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATBaseUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATBaseUnsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATBaseUnsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATBaseUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATBaseUnsafe __CreateInstance(global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATBaseUnsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATBaseUnsafe(global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATBaseUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATBaseUnsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATBaseUnsafe(global::AirTurnManager.Api.Foundation.ATBaseUnsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATBaseUnsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Create a new object</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        public static global::AirTurnManager.Api.Foundation.ATBaseUnsafe ATBaseNew(global::AirTurnManager.Api.Foundation.ATBaseUnsafe optionalStorage)
        {
            var __arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage.__Instance;
            var __ret = __Internal.ATBaseNew(__arg0);
            global::AirTurnManager.Api.Foundation.ATBaseUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATBaseUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATBaseUnsafe)global::AirTurnManager.Api.Foundation.ATBaseUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a new object</summary>
        /// <param name="base">The object to initialize. Can be `NULL` so the result from `ATBaseNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATBaseUnsafe ATBaseInit(global::AirTurnManager.Api.Foundation.ATBaseUnsafe @base)
        {
            var __arg0 = ReferenceEquals(@base, null) ? global::System.IntPtr.Zero : @base.__Instance;
            var __ret = __Internal.ATBaseInit(__arg0);
            global::AirTurnManager.Api.Foundation.ATBaseUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATBaseUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATBaseUnsafe)global::AirTurnManager.Api.Foundation.ATBaseUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Copy an `ATBase` object</summary>
        /// <param name="destination">The destination storage to copy into</param>
        /// <param name="source">The source object to copy from</param>
        /// <returns>`true` if copying was successful. Will fail if either pointer is `NULL` or the type of the objects is not the same.</returns>
        public static bool ATBaseCopy(global::AirTurnManager.Api.Foundation.ATBaseUnsafe destination, global::AirTurnManager.Api.Foundation.ATBaseUnsafe source)
        {
            var __arg0 = ReferenceEquals(destination, null) ? global::System.IntPtr.Zero : destination.__Instance;
            var __arg1 = ReferenceEquals(source, null) ? global::System.IntPtr.Zero : source.__Instance;
            var __ret = __Internal.ATBaseCopy(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Retain an object for storage in your own code</summary>
        /// <param name="object">The object to retain, or NULL (for convenience)</param>
        /// <returns>The object, or NULL if the passed object was NULL or not an ATBase object</returns>
        public static global::System.IntPtr ATRetain(global::System.IntPtr @object)
        {
            var __ret = __Internal.ATRetain(@object);
            return __ret;
        }

        /// <summary>Release an object when you have finished using it in your own code</summary>
        /// <param name="object">The object to release, or NULL (for convenience)</param>
        /// <returns>Always NULL for convenience (e.g. storedVar = ATRelease(storedVar) to ensure storedVar is NULL and released)</returns>
        public static global::System.IntPtr ATRelease(global::System.IntPtr @object)
        {
            var __ret = __Internal.ATRelease(@object);
            return __ret;
        }

        /// <summary>Get the type of an object</summary>
        /// <param name="object">The object</param>
        /// <returns>The type of the object</returns>
        public static global::AirTurnManager.Api.Foundation.ATObjectType ATGetType(global::System.IntPtr @object)
        {
            var __ret = __Internal.ATGetType(@object);
            return __ret;
        }

        /// <summary>Get the current retain count of the object</summary>
        /// <param name="object">The object</param>
        /// <returns>The object's retain count</returns>
        public static byte ATGetRetainCount(global::System.IntPtr @object)
        {
            var __ret = __Internal.ATGetRetainCount(@object);
            return __ret;
        }

        /// <summary>Determine if the object has been initialized and is ready to use</summary>
        /// <param name="object">The object</param>
        /// <returns>`true` if the object has been initiated</returns>
        public static bool ATObjectIsInitialized(global::System.IntPtr @object)
        {
            var __ret = __Internal.ATObjectIsInitialized(@object);
            return __ret;
        }

        /// <summary>Determine if an object is shared, i.e. it owns its memory and was not given storage to use during creation.</summary>
        /// <param name="object">The object</param>
        /// <returns>`true` if the object is shared and owns its own memory</returns>
        /// <remarks>If an object is shared you can depend on the object to exist throughout the duration of the application as long as its retain count is above 0. If it is not shared, the storage of the object may be free'd by the application elsewhere, or the storage may be removed from the stack.</remarks>
        public static bool ATObjectIsShared(global::System.IntPtr @object)
        {
            var __ret = __Internal.ATObjectIsShared(@object);
            return __ret;
        }

        /// <summary>Get a description for an object type</summary>
        /// <param name="type">The object type</param>
        /// <returns>A description of the type, or NULL if unknown type</returns>
        public static string ATGetDescriptionForType(global::AirTurnManager.Api.Foundation.ATObjectType type)
        {
            var __ret = __Internal.ATGetDescriptionForType(type);
            if (__ret == global::System.IntPtr.Zero)
                return default(string);
            var __retPtr = (byte*)__ret;
            int __length = 0;
            while (*(__retPtr++) != 0) __length += sizeof(byte);
            return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
        }

        /// <summary>Get a description for an object</summary>
        /// <param name="object">The object</param>
        /// <param name="string">The string to populate with a description</param>
        /// <returns>`true` if the object could be described successfully</returns>
        public static bool ATGetDescription(global::System.IntPtr @object, global::AirTurnManager.Api.Foundation.ATStringUnsafe @string)
        {
            var __arg1 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATGetDescription(@object, __arg1);
            return __ret;
        }

        /// <summary>Get a debug description for an object</summary>
        /// <param name="object">The object</param>
        /// <param name="string">The string to populate with a description</param>
        /// <returns>`true` if the object could be described successfully</returns>
        public static bool ATGetDebugDescription(global::System.IntPtr @object, global::AirTurnManager.Api.Foundation.ATStringUnsafe @string)
        {
            var __arg1 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATGetDebugDescription(@object, __arg1);
            return __ret;
        }

        /// <summary>Print a description of an object to stdout</summary>
        /// <param name="object">The object</param>
        public static void ATPrintDescription(global::System.IntPtr @object)
        {
            __Internal.ATPrintDescription(@object);
        }

        /// <summary>Print a debug description of an object to stdout</summary>
        /// <param name="object">The object</param>
        public static void ATPrintDebugDescription(global::System.IntPtr @object)
        {
            __Internal.ATPrintDebugDescription(@object);
        }

        public byte Signature
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance)->_signature;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance)->_signature = value;
            }
        }

        public byte RetainCount
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance)->_retainCount;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance)->_retainCount = value;
            }
        }

        public bool OwnsMemory
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance)->_ownsMemory != 0;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance)->_ownsMemory = (byte)(value ? 1 : 0);
            }
        }

        public bool HasInitCompleted
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance)->_hasInitCompleted != 0;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance)->_hasInitCompleted = (byte)(value ? 1 : 0);
            }
        }

        public global::AirTurnManager.Api.Foundation.ATObjectType Type
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance)->_type;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)__Instance)->_type = value;
            }
        }
    }
}
