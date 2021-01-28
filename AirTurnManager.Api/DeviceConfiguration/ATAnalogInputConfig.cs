using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceConfiguration
{
    [Flags]
    public enum ATAnalogInputConfigOptions : byte
    {
        ATAnalogInputConfigOptionsCalibrated = 1,
        ATAnalogInputConfigOptionsEnabled = 2,
        ATAnalogInputConfigOptionsInverted = 4,
        ATAnalogInputConfigOptionsHasAxisAssociation = 8,
        ATAnalogInputConfigOptionsHasLimits = 16,
        ATAnalogInputConfigOptionsHasMidpoint = 32
    }

    public enum ATAnalogInputConfigCalibrationState : byte
    {
        ATAnalogInputConfigCalibrationStateNone = 0,
        ATAnalogInputConfigCalibrationStateCalibratingMax = 1,
        ATAnalogInputConfigCalibrationStateCalibratingMin = 2,
        ATAnalogInputConfigCalibrationStateCalibratingMid = 3
    }

    [Flags]
    public enum ATAnalogInputConfigMaxDataLength
    {
        ATAnalogInputConfigMaxDataLength = 8
    }

    /// <summary>The struct for ATAnalogInputConfig objects</summary>
    public unsafe partial class ATAnalogInputConfigCalibrationLimitsUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 6)]
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal short min;

            [FieldOffset(2)]
            internal short mid;

            [FieldOffset(4)]
            internal short max;
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe>();

        protected bool _ownsNativeInstance;

        internal static DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe(native.ToPointer(), skipVTables);
        }

        internal static DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe _CreateInstance(DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal native, bool skipVTables = false)
        {
            return new DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal));
            *(DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATAnalogInputConfigCalibrationLimitsUnsafe(DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATAnalogInputConfigCalibrationLimitsUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATAnalogInputConfigCalibrationLimitsUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATAnalogInputConfigCalibrationLimitsUnsafe(DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal*)_Instance) = *((DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public short Min
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal*)_Instance)->min;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal*)_Instance)->min = value;
            }
        }

        public short Mid
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal*)_Instance)->mid;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal*)_Instance)->mid = value;
            }
        }

        public short Max
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal*)_Instance)->max;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal*)_Instance)->max = value;
            }
        }
    }

    /// <summary>The struct for ATAnalogInputConfig objects</summary>
    public unsafe partial class ATAnalogInputConfigUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public partial struct _Internal
        {
            // PRIVATE - DO NOT USE
            // The super-struct
            [FieldOffset(0)]
            internal Foundation.ATBaseUnsafe._Internal _base;

            // The data, if generated
            [FieldOffset(8)]
            internal IntPtr _data;

            // The data without limits, if generated
            [FieldOffset(16)]
            internal IntPtr _dataWithoutLimits;

            // If `true`, has limits set, and can determine hasMidpoint from limits
            [FieldOffset(24)]
            internal byte _hasLimitsSet;

            // PUBLIC
            // If `true`, the analog input is available for configuration. If false, not available, and other properties cannot be set.
            [FieldOffset(25)]
            internal byte available;

            // If `true`, the analog input is fully calibrated
            [FieldOffset(26)]
            internal byte calibrated;

            // If `true`, the analog input is enabled
            [FieldOffset(27)]
            internal byte enabled;

            // If `true`, the input calibration is inverted
            [FieldOffset(28)]
            internal byte inverted;

            // The other port this port is associated with, for example if this was X-axis of joystick, the port that is Y-axis.
            [FieldOffset(29)]
            internal DeviceTypes.ATPortUnsafe axisAssociation;

            // The currently calibrated input limits. Optionally included in data output
            [FieldOffset(30)]
            internal DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal limits;

            // Transient or calculated properties, not included in data output
            // `true` if the current configuration has a midpoint value
            [FieldOffset(36)]
            internal byte hasMidpoint;

            // The current scale factor for the calibrated limits
            [FieldOffset(38)]
            internal ushort scaleFactor;

            // The current input calibration state
            [FieldOffset(40)]
            internal byte calibrationState;

            // If `true`, the analog input is forced to be output to proprietary, even if not calibrated
            [FieldOffset(41)]
            internal byte forceProprietary;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigNew")]
            internal static extern IntPtr ATAnalogInputConfigNew(IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigInit")]
            internal static extern IntPtr ATAnalogInputConfigInit(IntPtr inputConfig);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigInitWithData")]
            internal static extern IntPtr ATAnalogInputConfigInitWithData(IntPtr inputConfig, IntPtr data, ulong* lengthParsed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputConfigParseData(IntPtr inputConfig, IntPtr data, ulong* lengthParsed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigGetData")]
            internal static extern IntPtr ATAnalogInputConfigGetData(IntPtr inputConfig, IntPtr optionalDataToFill, bool includeLimits);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigIsEqual")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputConfigIsEqual(IntPtr inputConfig1, IntPtr inputConfig2);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigCopy")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputConfigCopy(IntPtr destination, IntPtr source);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigParseMultiple")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputConfigParseMultiple(IntPtr data, IntPtr[] configStorage, byte portsAvailable);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigGetDataMultiple")]
            internal static extern IntPtr ATAnalogInputConfigGetDataMultiple(IntPtr optionalDataToFill, IntPtr[] configStorage, byte portsAvailable, bool includeLimits);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigSetAvailable")]
            internal static extern void ATAnalogInputConfigSetAvailable(IntPtr inputConfig, bool available);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigSetCalibrated")]
            internal static extern void ATAnalogInputConfigSetCalibrated(IntPtr inputConfig, bool calibrated);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigSetEnabled")]
            internal static extern void ATAnalogInputConfigSetEnabled(IntPtr inputConfig, bool enabled);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigSetForceProprietary")]
            internal static extern void ATAnalogInputConfigSetForceProprietary(IntPtr inputConfig, bool forceProprietary);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigSetInverted")]
            internal static extern void ATAnalogInputConfigSetInverted(IntPtr inputConfig, bool inverted);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigSetAxisAssociation")]
            internal static extern void ATAnalogInputConfigSetAxisAssociation(IntPtr inputConfig, DeviceTypes.ATPortUnsafe axisAssociation);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigClearAxisAssociation")]
            internal static extern void ATAnalogInputConfigClearAxisAssociation(IntPtr inputConfig);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigSetLimits")]
            internal static extern void ATAnalogInputConfigSetLimits(IntPtr inputConfig, IntPtr limits);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigSetCalibrationState")]
            internal static extern void ATAnalogInputConfigSetCalibrationState(IntPtr inputConfig, byte calibrationState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigApplyAnalogAction")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputConfigApplyAnalogAction(IntPtr inputConfig, IntPtr action, short currentValue);
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, DeviceConfiguration.ATAnalogInputConfigUnsafe> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, DeviceConfiguration.ATAnalogInputConfigUnsafe>();

        protected bool _ownsNativeInstance;

        internal static DeviceConfiguration.ATAnalogInputConfigUnsafe _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new DeviceConfiguration.ATAnalogInputConfigUnsafe(native.ToPointer(), skipVTables);
        }

        internal static DeviceConfiguration.ATAnalogInputConfigUnsafe _CreateInstance(DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal native, bool skipVTables = false)
        {
            return new DeviceConfiguration.ATAnalogInputConfigUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal));
            *(DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATAnalogInputConfigUnsafe(DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATAnalogInputConfigUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATAnalogInputConfigUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATAnalogInputConfigUnsafe(DeviceConfiguration.ATAnalogInputConfigUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance) = *((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            DeviceConfiguration.ATAnalogInputConfigUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        /// <summary>Create a new analog input config object</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        public static DeviceConfiguration.ATAnalogInputConfigUnsafe ATAnalogInputConfigNew(DeviceConfiguration.ATAnalogInputConfigUnsafe optionalStorage)
        {
            var _arg0 = ReferenceEquals(optionalStorage, null) ? IntPtr.Zero : optionalStorage._Instance;
            var _ret = _Internal.ATAnalogInputConfigNew(_arg0);
            DeviceConfiguration.ATAnalogInputConfigUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (DeviceConfiguration.ATAnalogInputConfigUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (DeviceConfiguration.ATAnalogInputConfigUnsafe)DeviceConfiguration.ATAnalogInputConfigUnsafe.NativeToManagedMap[_ret];
            else _result0 = DeviceConfiguration.ATAnalogInputConfigUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new analog input config object</summary>
        /// <param name="inputConfig">The object to initialize. Can be `NULL` so the result from `ATAnalogInputConfigNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static DeviceConfiguration.ATAnalogInputConfigUnsafe ATAnalogInputConfigInit(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            var _ret = _Internal.ATAnalogInputConfigInit(_arg0);
            DeviceConfiguration.ATAnalogInputConfigUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (DeviceConfiguration.ATAnalogInputConfigUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (DeviceConfiguration.ATAnalogInputConfigUnsafe)DeviceConfiguration.ATAnalogInputConfigUnsafe.NativeToManagedMap[_ret];
            else _result0 = DeviceConfiguration.ATAnalogInputConfigUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new analog input config object from its binary representation as received from an AirTurn</summary>
        /// <param name="inputConfig">The analog input config object</param>
        /// <param name="data">The data</param>
        /// <param name="lengthParsed">The length of the data</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static DeviceConfiguration.ATAnalogInputConfigUnsafe ATAnalogInputConfigInitWithData(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, Foundation.ATDataUnsafe data, ref ulong lengthParsed)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            var _arg1 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            fixed (ulong* _lengthParsed2 = &lengthParsed)
            {
                var _arg2 = _lengthParsed2;
                var _ret = _Internal.ATAnalogInputConfigInitWithData(_arg0, _arg1, _arg2);
                DeviceConfiguration.ATAnalogInputConfigUnsafe _result0;
                if (_ret == IntPtr.Zero) _result0 = null;
                else if (DeviceConfiguration.ATAnalogInputConfigUnsafe.NativeToManagedMap.ContainsKey(_ret))
                    _result0 = (DeviceConfiguration.ATAnalogInputConfigUnsafe)DeviceConfiguration.ATAnalogInputConfigUnsafe.NativeToManagedMap[_ret];
                else _result0 = DeviceConfiguration.ATAnalogInputConfigUnsafe._CreateInstance(_ret);
                return _result0;
            }
        }

        /// <summary>Parse data into a analog input config object from its binary representation as received from an AirTurn</summary>
        /// <param name="inputConfig">The analog input config object</param>
        /// <param name="data">The data</param>
        /// <param name="lengthParsed">The length of the data</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static bool ATAnalogInputConfigParseData(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, Foundation.ATDataUnsafe data, ref ulong lengthParsed)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            var _arg1 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            fixed (ulong* _lengthParsed2 = &lengthParsed)
            {
                var _arg2 = _lengthParsed2;
                var _ret = _Internal.ATAnalogInputConfigParseData(_arg0, _arg1, _arg2);
                return _ret;
            }
        }

        /// <summary>Get the analog analog input config data</summary>
        /// <param name="inputConfig">The analog input config</param>
        /// <param name="optionalDataToFill">An optional data object to fill with the generated data</param>
        /// <returns>The generated data. On failure, returns `NULL`. Otherwise, if `optionalDataToFill` is NULL, returns a data object owned by the analog input config object, otherwise returns `optionalDataToFill`</returns>
        public static Foundation.ATDataUnsafe ATAnalogInputConfigGetData(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, Foundation.ATDataUnsafe optionalDataToFill, bool includeLimits)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            var _arg1 = ReferenceEquals(optionalDataToFill, null) ? IntPtr.Zero : optionalDataToFill._Instance;
            var _ret = _Internal.ATAnalogInputConfigGetData(_arg0, _arg1, includeLimits);
            Foundation.ATDataUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATDataUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Determine if two analog input config objects are equal</summary>
        /// <param name="inputConfig1">The first analog input config</param>
        /// <param name="inputConfig2">The second analog input config</param>
        /// <returns>`true` if the analog input configs are equal</returns>
        public static bool ATAnalogInputConfigIsEqual(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig1, DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig2)
        {
            var _arg0 = ReferenceEquals(inputConfig1, null) ? IntPtr.Zero : inputConfig1._Instance;
            var _arg1 = ReferenceEquals(inputConfig2, null) ? IntPtr.Zero : inputConfig2._Instance;
            var _ret = _Internal.ATAnalogInputConfigIsEqual(_arg0, _arg1);
            return _ret;
        }

        /// <summary>Copy a analog input config, retaining all items for the destination</summary>
        /// <param name="destination">The destination analog input config object to copy into</param>
        /// <param name="source">The source analog input config object</param>
        /// <returns>`true` if successful</returns>
        public static bool ATAnalogInputConfigCopy(DeviceConfiguration.ATAnalogInputConfigUnsafe destination, DeviceConfiguration.ATAnalogInputConfigUnsafe source)
        {
            var _arg0 = ReferenceEquals(destination, null) ? IntPtr.Zero : destination._Instance;
            var _arg1 = ReferenceEquals(source, null) ? IntPtr.Zero : source._Instance;
            var _ret = _Internal.ATAnalogInputConfigCopy(_arg0, _arg1);
            return _ret;
        }

        /// <summary>Parse data into multiple config objects</summary>
        /// <param name="data">The data to parse</param>
        /// <param name="configStorage">An array of pointers to config objects, already initiated.</param>
        /// <param name="portsAvailable">The ports that are currently available. If a port is not available, no data will be parsed for that port and the config object's `available` property will be set to false</param>
        /// <returns>`true` if successful, otherwise `false`.</returns>
        public static bool ATAnalogInputConfigParseMultiple(Foundation.ATDataUnsafe data, DeviceConfiguration.ATAnalogInputConfigUnsafe[] configStorage, byte portsAvailable)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            if (configStorage == null || configStorage.Length != 8)
                throw new ArgumentOutOfRangeException("configStorage", "The dimensions of the provided array don't match the required size.");
            IntPtr[] _configStorage;
            if (ReferenceEquals(configStorage, null))
                _configStorage = null;
            else
            {
                _configStorage = new IntPtr[configStorage.Length];
                for (int i = 0; i < _configStorage.Length; i++)
                {
                    var _element = configStorage[i];
                    _configStorage[i] = ReferenceEquals(_element, null) ? IntPtr.Zero : _element._Instance;
                }
            }
            var _arg1 = _configStorage;
            var _ret = _Internal.ATAnalogInputConfigParseMultiple(_arg0, _arg1, portsAvailable);
            return _ret;
        }

        /// <summary>Get data for multiple configs</summary>
        /// <param name="optionalDataToFill">An optional data object to fill with the generated data</param>
        /// <param name="configStorage">An array of pointers to config objects, already initiated.</param>
        /// <param name="portsAvailable">The ports that are currently available. If a port is not available, no data will be generated for that port</param>
        /// <param name="includeLimits">If `true`, will include the limit values</param>
        /// <returns>The generated data. On failure, returns `NULL`. Otherwise, if `optionalDataToFill` is NULL, returns a data object owned by caller with retain count 1, otherwise returns `optionalDataToFill`</returns>
        public static Foundation.ATDataUnsafe ATAnalogInputConfigGetDataMultiple(Foundation.ATDataUnsafe optionalDataToFill, DeviceConfiguration.ATAnalogInputConfigUnsafe[] configStorage, byte portsAvailable, bool includeLimits)
        {
            var _arg0 = ReferenceEquals(optionalDataToFill, null) ? IntPtr.Zero : optionalDataToFill._Instance;
            if (configStorage == null || configStorage.Length != 8)
                throw new ArgumentOutOfRangeException("configStorage", "The dimensions of the provided array don't match the required size.");
            IntPtr[] _configStorage;
            if (ReferenceEquals(configStorage, null))
                _configStorage = null;
            else
            {
                _configStorage = new IntPtr[configStorage.Length];
                for (int i = 0; i < _configStorage.Length; i++)
                {
                    var _element = configStorage[i];
                    _configStorage[i] = ReferenceEquals(_element, null) ? IntPtr.Zero : _element._Instance;
                }
            }
            var _arg1 = _configStorage;
            var _ret = _Internal.ATAnalogInputConfigGetDataMultiple(_arg0, _arg1, portsAvailable, includeLimits);
            Foundation.ATDataUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATDataUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Set the analog input config available property</summary>
        /// <param name="inputConfig">The analog input config</param>
        /// <param name="available">The new available value</param>
        public static void ATAnalogInputConfigSetAvailable(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, bool available)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            _Internal.ATAnalogInputConfigSetAvailable(_arg0, available);
        }

        /// <summary>Set the analog input config calibrated property</summary>
        /// <param name="inputConfig">The analog input config</param>
        /// <param name="calibrated">The new calibrated value</param>
        public static void ATAnalogInputConfigSetCalibrated(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, bool calibrated)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            _Internal.ATAnalogInputConfigSetCalibrated(_arg0, calibrated);
        }

        /// <summary>Set the analog input config enabled property</summary>
        /// <param name="inputConfig">The analog input config</param>
        /// <param name="enabled">The new enabled value</param>
        public static void ATAnalogInputConfigSetEnabled(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, bool enabled)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            _Internal.ATAnalogInputConfigSetEnabled(_arg0, enabled);
        }

        /// <summary>Set the analog input config force proprietary property</summary>
        /// <param name="inputConfig">The analog input config</param>
        /// <param name="forceProprietary">The new force proprietary value</param>
        public static void ATAnalogInputConfigSetForceProprietary(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, bool forceProprietary)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            _Internal.ATAnalogInputConfigSetForceProprietary(_arg0, forceProprietary);
        }

        /// <summary>Set the analog input config inverted property</summary>
        /// <param name="inputConfig">The analog input config</param>
        /// <param name="inverted">The new inverted value</param>
        public static void ATAnalogInputConfigSetInverted(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, bool inverted)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            _Internal.ATAnalogInputConfigSetInverted(_arg0, inverted);
        }

        /// <summary>Set the analog input config axis association property</summary>
        /// <param name="inputConfig">The analog input config</param>
        /// <param name="axisAssociation">The new axis association value</param>
        public static void ATAnalogInputConfigSetAxisAssociation(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, DeviceTypes.ATPortUnsafe axisAssociation)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            _Internal.ATAnalogInputConfigSetAxisAssociation(_arg0, axisAssociation);
        }

        /// <summary>Clear the axis association for this input</summary>
        /// <param name="inputConfig">The analog input config</param>
        public static void ATAnalogInputConfigClearAxisAssociation(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            _Internal.ATAnalogInputConfigClearAxisAssociation(_arg0);
        }

        /// <summary>Set the analog input config limits property</summary>
        /// <param name="inputConfig">The analog input config</param>
        /// <param name="limits">The new limits value</param>
        public static void ATAnalogInputConfigSetLimits(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe limits)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            var _arg1 = ReferenceEquals(limits, null) ? IntPtr.Zero : limits._Instance;
            _Internal.ATAnalogInputConfigSetLimits(_arg0, _arg1);
        }

        /// <summary>Set the analog input config calibration state</summary>
        /// <param name="inputConfig">The analog input config</param>
        /// <param name="calibrationState">The new is calibration state</param>
        public static void ATAnalogInputConfigSetCalibrationState(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, byte calibrationState)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            _Internal.ATAnalogInputConfigSetCalibrationState(_arg0, calibrationState);
        }

        /// <summary>Apply an analog action to the input config</summary>
        /// <param name="inputConfig">The input config to apply the action to</param>
        /// <param name="action">The action to apply</param>
        /// <param name="currentValue">The current analog input value for this port, for calibrate now actions. Ignored for other actions</param>
        /// <returns>If successful, `true`, otherwise `false`</returns>
        public static bool ATAnalogInputConfigApplyAnalogAction(DeviceConfiguration.ATAnalogInputConfigUnsafe inputConfig, DeviceTypes.ATAnalogActionUnsafe action, short currentValue)
        {
            var _arg0 = ReferenceEquals(inputConfig, null) ? IntPtr.Zero : inputConfig._Instance;
            var _arg1 = ReferenceEquals(action, null) ? IntPtr.Zero : action._Instance;
            var _ret = _Internal.ATAnalogInputConfigApplyAnalogAction(_arg0, _arg1, currentValue);
            return _ret;
        }

        public Foundation.ATBaseUnsafe Base
        {
            get
            {
                return Foundation.ATBaseUnsafe._CreateInstance(new IntPtr(&((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_base));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_base = *(Foundation.ATBaseUnsafe._Internal*)value._Instance;
            }
        }

        public Foundation.ATBaseUnsafe Data
        {
            get
            {
                Foundation.ATDataUnsafe _result0;
                if (((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_data == IntPtr.Zero) _result0 = null;
                else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_data))
                    _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_data];
                else _result0 = Foundation.ATDataUnsafe._CreateInstance(((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_data);
                return _result0;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_data = ReferenceEquals(value, null) ? IntPtr.Zero : value._Instance;
            }
        }

        public Foundation.ATDataUnsafe DataWithoutLimits
        {
            get
            {
                Foundation.ATDataUnsafe _result0;
                if (((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_dataWithoutLimits == IntPtr.Zero) _result0 = null;
                else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_dataWithoutLimits))
                    _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_dataWithoutLimits];
                else _result0 = Foundation.ATDataUnsafe._CreateInstance(((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_dataWithoutLimits);
                return _result0;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_dataWithoutLimits = ReferenceEquals(value, null) ? IntPtr.Zero : value._Instance;
            }
        }

        public bool HasLimitsSet
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_hasLimitsSet != 0;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->_hasLimitsSet = (byte)(value ? 1 : 0);
            }
        }

        public bool Available
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->available != 0;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->available = (byte)(value ? 1 : 0);
            }
        }

        public bool Calibrated
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->calibrated != 0;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->calibrated = (byte)(value ? 1 : 0);
            }
        }

        public bool Enabled
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->enabled != 0;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->enabled = (byte)(value ? 1 : 0);
            }
        }

        public bool Inverted
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->inverted != 0;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->inverted = (byte)(value ? 1 : 0);
            }
        }

        public DeviceTypes.ATPortUnsafe AxisAssociation
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->axisAssociation;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->axisAssociation = value;
            }
        }

        public DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe Limits
        {
            get
            {
                return DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._CreateInstance(new IntPtr(&((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->limits));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->limits = *(DeviceConfiguration.ATAnalogInputConfigCalibrationLimitsUnsafe._Internal*)value._Instance;
            }
        }

        public bool HasMidpoint
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->hasMidpoint != 0;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->hasMidpoint = (byte)(value ? 1 : 0);
            }
        }

        public ushort ScaleFactor
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->scaleFactor;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->scaleFactor = value;
            }
        }

        public byte CalibrationState
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->calibrationState;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->calibrationState = value;
            }
        }

        public bool ForceProprietary
        {
            get
            {
                return ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->forceProprietary != 0;
            }

            set
            {
                ((DeviceConfiguration.ATAnalogInputConfigUnsafe._Internal*)_Instance)->forceProprietary = (byte)(value ? 1 : 0);
            }
        }
    }
}
