using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATAnalogActionMaxDataLength
    {
        ATAnalogActionMaxDataLength = 3
    }

    public enum ATAnalogActionType : byte
    {
        ATAnalogActionTypeCalibrateCancel = 0,
        ATAnalogActionTypeCalibrateBegin = 1,
        ATAnalogActionTypeCalibrateMaxNow = 2,
        ATAnalogActionTypeCalibrateMinNow = 3,
        ATAnalogActionTypeCalibrateMidNow = 4,
        ATAnalogActionTypeAddAxisAssociation = 5,
        ATAnalogActionTypeSetEnabledPort = 6,
        ATAnalogActionTypeSetEnabledAll = 7,
        ATAnalogActionTypeSetForceProprietaryPort = 8,
        ATAnalogActionTypeSetForceProprietaryAll = 9,
        ATAnalogActionTypeMinimum = 0,
        ATAnalogActionTypeMaximum = 9
    }

    public unsafe partial struct ATAnalogActionParameters
    {
        [StructLayout(LayoutKind.Explicit, Size = 1)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::AirTurnManager.Api.DeviceTypes.ATPort associatedAxis;

            [FieldOffset(0)]
            internal byte enabled;

            [FieldOffset(0)]
            internal byte forceProprietary;

            [FieldOffset(0)]
            internal byte hasMid;
        }

        private ATAnalogActionParameters.__Internal __instance;
        internal ATAnalogActionParameters.__Internal __Instance { get { return __instance; } }

        internal static global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters __CreateInstance(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters(native, skipVTables);
        }

        private ATAnalogActionParameters(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters.__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private ATAnalogActionParameters(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters.__Internal*)native;
        }

        public ATAnalogActionParameters(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters _0)
            : this()
        {
            var ____arg0 = _0.__Instance;
            var __arg0 = new global::System.IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new global::System.IntPtr(__instancePtr), __arg0);
            }
        }

        public global::AirTurnManager.Api.DeviceTypes.ATPort AssociatedAxis
        {
            get
            {
                return __instance.associatedAxis;
            }

            set
            {
                __instance.associatedAxis = value;
            }
        }

        public bool Enabled
        {
            get
            {
                return __instance.enabled != 0;
            }

            set
            {
                __instance.enabled = (byte)(value ? 1 : 0);
            }
        }

        public bool ForceProprietary
        {
            get
            {
                return __instance.forceProprietary != 0;
            }

            set
            {
                __instance.forceProprietary = (byte)(value ? 1 : 0);
            }
        }

        public bool HasMid
        {
            get
            {
                return __instance.hasMid != 0;
            }

            set
            {
                __instance.hasMid = (byte)(value ? 1 : 0);
            }
        }
    }

    public unsafe partial class ATAnalogActionUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 3)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::AirTurnManager.Api.DeviceTypes.ATAnalogActionType action;

            [FieldOffset(1)]
            internal global::AirTurnManager.Api.DeviceTypes.ATPort port;

            [FieldOffset(2)]
            internal global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters.__Internal parameters;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogActionIsPortSpecificAction")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogActionIsPortSpecificAction(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionType actionType);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogActionValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogActionValidate(global::System.IntPtr analogAction);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogActionParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogActionParseData(global::System.IntPtr data, global::System.IntPtr analogAction);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogActionGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogActionGetData(global::System.IntPtr data, global::System.IntPtr analogAction);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogActionDescription")]
            internal static extern void ATAnalogActionDescription(global::System.IntPtr @string, global::System.IntPtr analogAction);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe __CreateInstance(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal));
            *(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATAnalogActionUnsafe(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATAnalogActionUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATAnalogActionUnsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATAnalogActionUnsafe(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Determine if an action type is associated with a specific port</summary>
        /// <param name="actionType">The action type</param>
        /// <returns>`true` if action is associated with a specific port</returns>
        public static bool ATAnalogActionIsPortSpecificAction(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionType actionType)
        {
            var __ret = __Internal.ATAnalogActionIsPortSpecificAction(actionType);
            return __ret;
        }

        /// <summary>Validate an analog action</summary>
        /// <param name="analogAction">The analog action value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATAnalogActionValidate(global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe analogAction)
        {
            var __arg0 = ReferenceEquals(analogAction, null) ? global::System.IntPtr.Zero : analogAction.__Instance;
            var __ret = __Internal.ATAnalogActionValidate(__arg0);
            return __ret;
        }

        /// <summary>Get an analog action from data</summary>
        /// <param name="data">The data</param>
        /// <param name="analogAction">On return, contains the analog action</param>
        /// <returns>`true` if successful</returns>
        public static bool ATAnalogActionParseData(global::AirTurnManager.Api.DeviceTypes.ATBytes data, global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe analogAction)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var __arg0 = data.__Instance;
            var __arg1 = ReferenceEquals(analogAction, null) ? global::System.IntPtr.Zero : analogAction.__Instance;
            var __ret = __Internal.ATAnalogActionParseData(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Get the data for an analog action</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="analogAction">The analog action to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATAnalogActionGetData(global::AirTurnManager.Api.DeviceTypes.ATMutableBytes data, global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe analogAction)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __arg1 = ReferenceEquals(analogAction, null) ? global::System.IntPtr.Zero : analogAction.__Instance;
            var __ret = __Internal.ATAnalogActionGetData(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Get a description for a analog action</summary>
        /// <param name="string">The string to append the description to</param>
        /// <param name="analogAction">The analog action</param>
        public static void ATAnalogActionDescription(global::AirTurnManager.Api.DeviceTypes.ATString @string, global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe analogAction)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __arg1 = ReferenceEquals(analogAction, null) ? global::System.IntPtr.Zero : analogAction.__Instance;
            __Internal.ATAnalogActionDescription(__arg0, __arg1);
        }

        public global::AirTurnManager.Api.DeviceTypes.ATAnalogActionType Action
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal*)__Instance)->action;
            }

            set
            {
                ((global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal*)__Instance)->action = value;
            }
        }

        public global::AirTurnManager.Api.DeviceTypes.ATPort Port
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal*)__Instance)->port;
            }

            set
            {
                ((global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal*)__Instance)->port = value;
            }
        }

        public global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters Parameters
        {
            get
            {
                return global::AirTurnManager.Api.DeviceTypes.ATAnalogActionParameters.__CreateInstance(((global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal*)__Instance)->parameters);
            }

            set
            {
                ((global::AirTurnManager.Api.DeviceTypes.ATAnalogActionUnsafe.__Internal*)__Instance)->parameters = value.__Instance;
            }
        }
    }
}
