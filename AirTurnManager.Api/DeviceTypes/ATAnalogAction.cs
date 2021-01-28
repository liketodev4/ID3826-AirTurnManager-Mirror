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
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal DeviceTypes.ATPortEnum associatedAxis;

            [FieldOffset(0)]
            internal byte enabled;

            [FieldOffset(0)]
            internal byte forceProprietary;

            [FieldOffset(0)]
            internal byte hasMid;
        }

        private ATAnalogActionParameters._Internal _instance;
        internal ATAnalogActionParameters._Internal _Instance { get { return _instance; } }

        internal static DeviceTypes.ATAnalogActionParameters _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new DeviceTypes.ATAnalogActionParameters(native.ToPointer(), skipVTables);
        }

        internal static DeviceTypes.ATAnalogActionParameters _CreateInstance(DeviceTypes.ATAnalogActionParameters._Internal native, bool skipVTables = false)
        {
            return new DeviceTypes.ATAnalogActionParameters(native, skipVTables);
        }

        private ATAnalogActionParameters(DeviceTypes.ATAnalogActionParameters._Internal native, bool skipVTables = false)
            : this()
        {
            _instance = native;
        }

        private ATAnalogActionParameters(void* native, bool skipVTables = false) : this()
        {
            _instance = *(DeviceTypes.ATAnalogActionParameters._Internal*)native;
        }

        public ATAnalogActionParameters(DeviceTypes.ATAnalogActionParameters _0)
            : this()
        {
            var _arg0 = _0._Instance;
            var _arg0 = new IntPtr(&_arg0);
            fixed (_Internal* _instancePtr = &_instance)
            {
                _Internal.cctor(new IntPtr(_instancePtr), _arg0);
            }
        }

        public DeviceTypes.ATPortEnum AssociatedAxis
        {
            get
            {
                return _instance.associatedAxis;
            }

            set
            {
                _instance.associatedAxis = value;
            }
        }

        public bool Enabled
        {
            get
            {
                return _instance.enabled != 0;
            }

            set
            {
                _instance.enabled = (byte)(value ? 1 : 0);
            }
        }

        public bool ForceProprietary
        {
            get
            {
                return _instance.forceProprietary != 0;
            }

            set
            {
                _instance.forceProprietary = (byte)(value ? 1 : 0);
            }
        }

        public bool HasMid
        {
            get
            {
                return _instance.hasMid != 0;
            }

            set
            {
                _instance.hasMid = (byte)(value ? 1 : 0);
            }
        }
    }

    public unsafe partial class ATAnalogActionUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 3)]
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal DeviceTypes.ATAnalogActionType action;

            [FieldOffset(1)]
            internal DeviceTypes.ATPortEnum port;

            [FieldOffset(2)]
            internal DeviceTypes.ATAnalogActionParameters._Internal parameters;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogActionIsPortSpecificAction")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogActionIsPortSpecificAction(DeviceTypes.ATAnalogActionType actionType);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogActionValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogActionValidate(IntPtr analogAction);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogActionParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogActionParseData(IntPtr data, IntPtr analogAction);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogActionGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogActionGetData(IntPtr data, IntPtr analogAction);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogActionDescription")]
            internal static extern void ATAnalogActionDescription(IntPtr @string, IntPtr analogAction);
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, DeviceTypes.ATAnalogActionUnsafe> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, DeviceTypes.ATAnalogActionUnsafe>();

        protected bool _ownsNativeInstance;

        internal static DeviceTypes.ATAnalogActionUnsafe _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new DeviceTypes.ATAnalogActionUnsafe(native.ToPointer(), skipVTables);
        }

        internal static DeviceTypes.ATAnalogActionUnsafe _CreateInstance(DeviceTypes.ATAnalogActionUnsafe._Internal native, bool skipVTables = false)
        {
            return new DeviceTypes.ATAnalogActionUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(DeviceTypes.ATAnalogActionUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(DeviceTypes.ATAnalogActionUnsafe._Internal));
            *(DeviceTypes.ATAnalogActionUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATAnalogActionUnsafe(DeviceTypes.ATAnalogActionUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATAnalogActionUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATAnalogActionUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(DeviceTypes.ATAnalogActionUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATAnalogActionUnsafe(DeviceTypes.ATAnalogActionUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(DeviceTypes.ATAnalogActionUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((DeviceTypes.ATAnalogActionUnsafe._Internal*)_Instance) = *((DeviceTypes.ATAnalogActionUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            DeviceTypes.ATAnalogActionUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        /// <summary>Determine if an action type is associated with a specific port</summary>
        /// <param name="actionType">The action type</param>
        /// <returns>`true` if action is associated with a specific port</returns>
        public static bool ATAnalogActionIsPortSpecificAction(DeviceTypes.ATAnalogActionType actionType)
        {
            var _ret = _Internal.ATAnalogActionIsPortSpecificAction(actionType);
            return _ret;
        }

        /// <summary>Validate an analog action</summary>
        /// <param name="analogAction">The analog action value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATAnalogActionValidate(DeviceTypes.ATAnalogActionUnsafe analogAction)
        {
            var _arg0 = ReferenceEquals(analogAction, null) ? IntPtr.Zero : analogAction._Instance;
            var _ret = _Internal.ATAnalogActionValidate(_arg0);
            return _ret;
        }

        /// <summary>Get an analog action from data</summary>
        /// <param name="data">The data</param>
        /// <param name="analogAction">On return, contains the analog action</param>
        /// <returns>`true` if successful</returns>
        public static bool ATAnalogActionParseData(DeviceTypes.ATBytes data, DeviceTypes.ATAnalogActionUnsafe analogAction)
        {
            if (ReferenceEquals(data, null))
                throw new ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            var _arg1 = ReferenceEquals(analogAction, null) ? IntPtr.Zero : analogAction._Instance;
            var _ret = _Internal.ATAnalogActionParseData(_arg0, _arg1);
            return _ret;
        }

        /// <summary>Get the data for an analog action</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="analogAction">The analog action to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATAnalogActionGetData(DeviceTypes.ATMutableBytes data, DeviceTypes.ATAnalogActionUnsafe analogAction)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _arg1 = ReferenceEquals(analogAction, null) ? IntPtr.Zero : analogAction._Instance;
            var _ret = _Internal.ATAnalogActionGetData(_arg0, _arg1);
            return _ret;
        }

        /// <summary>Get a description for a analog action</summary>
        /// <param name="string">The string to append the description to</param>
        /// <param name="analogAction">The analog action</param>
        public static void ATAnalogActionDescription(DeviceTypes.ATString @string, DeviceTypes.ATAnalogActionUnsafe analogAction)
        {
            var _arg0 = ReferenceEquals(@string, null) ? IntPtr.Zero : @string._Instance;
            var _arg1 = ReferenceEquals(analogAction, null) ? IntPtr.Zero : analogAction._Instance;
            _Internal.ATAnalogActionDescription(_arg0, _arg1);
        }

        public DeviceTypes.ATAnalogActionType Action
        {
            get
            {
                return ((DeviceTypes.ATAnalogActionUnsafe._Internal*)_Instance)->action;
            }

            set
            {
                ((DeviceTypes.ATAnalogActionUnsafe._Internal*)_Instance)->action = value;
            }
        }

        public DeviceTypes.ATPortEnum Port
        {
            get
            {
                return ((DeviceTypes.ATAnalogActionUnsafe._Internal*)_Instance)->port;
            }

            set
            {
                ((DeviceTypes.ATAnalogActionUnsafe._Internal*)_Instance)->port = value;
            }
        }

        public DeviceTypes.ATAnalogActionParameters Parameters
        {
            get
            {
                return DeviceTypes.ATAnalogActionParameters._CreateInstance(((DeviceTypes.ATAnalogActionUnsafe._Internal*)_Instance)->parameters);
            }

            set
            {
                ((DeviceTypes.ATAnalogActionUnsafe._Internal*)_Instance)->parameters = value._Instance;
            }
        }
    }
}
