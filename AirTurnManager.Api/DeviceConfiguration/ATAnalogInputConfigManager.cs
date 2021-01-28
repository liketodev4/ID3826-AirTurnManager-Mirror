using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceConfiguration
{
    public unsafe partial class ATAnalogInputConfigManagerUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 800)]
        public partial struct _Internal
        {
            // PRIVATE - DO NOT USE
            // The super-struct
            [FieldOffset(0)]
            internal Foundation.ATBaseUnsafe._Internal _base;

            // Stored input configs
            [FieldOffset(8)]
            internal fixed byte _inputConfigsStored[(int)DeviceTypes.ATPort.ATPortMaxNumberOfPorts];

            // flags indicating if input config storage needs updating
            [FieldOffset(392)]
            internal fixed byte _inputConfigStorageNeedsUpdate[(int)DeviceTypes.ATPort.ATPortMaxNumberOfPorts];

            // flags indicating if input port config need clearing
            [FieldOffset(400)]
            internal fixed byte _portConfigNeedsClearing[(int)DeviceTypes.ATPort.ATPortMaxNumberOfPorts];

            // Active input configs
            [FieldOffset(408)]
            internal fixed byte _inputConfigsActive[(int)DeviceTypes.ATPort.ATPortMaxNumberOfPorts];

            // Ports available on this device
            [FieldOffset(792)]
            internal byte _portsAvailable;

            // PUBLIC
            // If true, the input configs need updating in storage
            [FieldOffset(793)]
            internal byte storageNeedsUpdate;

            // The port currently being calibrated
            [FieldOffset(794)]
            internal DeviceTypes.ATPortUnsafe currentlyCalibrating;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerNew")]
            internal static extern global::System.IntPtr ATAnalogInputConfigManagerNew(global::System.IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerInit")]
            internal static extern global::System.IntPtr ATAnalogInputConfigManagerInit(global::System.IntPtr inputConfigManager, byte portsAvailable);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputConfigManagerParseData(global::System.IntPtr inputConfigManager, DeviceTypes.ATPortUnsafe port, global::System.IntPtr data, ulong* lengthParsed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerGetData")]
            internal static extern global::System.IntPtr ATAnalogInputConfigManagerGetData(global::System.IntPtr inputConfigManager, DeviceTypes.ATPortUnsafe port, global::System.IntPtr optionalDataToFill, bool includeLimits);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerParseMultiple")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputConfigManagerParseMultiple(global::System.IntPtr inputConfigManager, global::System.IntPtr data);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerGetDataMultiple")]
            internal static extern global::System.IntPtr ATAnalogInputConfigManagerGetDataMultiple(global::System.IntPtr inputConfigManager, global::System.IntPtr optionalDataToFill, bool includeLimits);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerApplyAnalogAction")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputConfigManagerApplyAnalogAction(global::System.IntPtr inputConfigManager, global::System.IntPtr action, short currentValue);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerGetInputConfig")]
            internal static extern global::System.IntPtr ATAnalogInputConfigManagerGetInputConfig(global::System.IntPtr inputConfigManager, DeviceTypes.ATPortUnsafe port, bool active);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerResetToStored")]
            internal static extern void ATAnalogInputConfigManagerResetToStored(global::System.IntPtr inputConfigManager);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerStorageNeedsUpdate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputConfigManagerStorageNeedsUpdate(global::System.IntPtr inputConfigManager, DeviceTypes.ATPortUnsafe port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerStorageUpdated")]
            internal static extern void ATAnalogInputConfigManagerStorageUpdated(global::System.IntPtr inputConfigManager, DeviceTypes.ATPortUnsafe port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerPortConfigNeedsClearing")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputConfigManagerPortConfigNeedsClearing(global::System.IntPtr inputConfigManager, DeviceTypes.ATPortUnsafe port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputConfigManagerPortConfigCleared")]
            internal static extern void ATAnalogInputConfigManagerPortConfigCleared(global::System.IntPtr inputConfigManager, DeviceTypes.ATPortUnsafe port);
        }

        public global::System.IntPtr _Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, DeviceConfiguration.ATAnalogInputConfigManagerUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, DeviceConfiguration.ATAnalogInputConfigManagerUnsafe>();

        protected bool _ownsNativeInstance;

        internal static DeviceConfiguration.ATAnalogInputConfigManagerUnsafe _CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new DeviceConfiguration.ATAnalogInputConfigManagerUnsafe(native.ToPointer(), skipVTables);
        }

        internal static DeviceConfiguration.ATAnalogInputConfigManagerUnsafe _CreateInstance(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._Internal native, bool skipVTables = false)
        {
            return new DeviceConfiguration.ATAnalogInputConfigManagerUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._Internal));
            *(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private  ATAnalogInputConfigManagerUnsafe(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATAnalogInputConfigManagerUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new global::System.IntPtr(native);
        }

        public ATAnalogInputConfigManagerUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATAnalogInputConfigManagerUnsafe(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._Internal*)_Instance) = *((DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            DeviceConfiguration.ATAnalogInputConfigManagerUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        /// <summary>Create a new analog input config manager object</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        public static DeviceConfiguration.ATAnalogInputConfigManagerUnsafe ATAnalogInputConfigManagerNew(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe optionalStorage)
        {
            var _arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage._Instance;
            var _ret = _Internal.ATAnalogInputConfigManagerNew(_arg0);
            DeviceConfiguration.ATAnalogInputConfigManagerUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (DeviceConfiguration.ATAnalogInputConfigManagerUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (DeviceConfiguration.ATAnalogInputConfigManagerUnsafe)DeviceConfiguration.ATAnalogInputConfigManagerUnsafe.NativeToManagedMap[_ret];
            else _result0 = DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a new analog input config manager object</summary>
        /// <param name="inputConfigManager">The object to initialize. Can be `NULL` so the result from `ATAnalogInputConfigManagerNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="portsAvailable">The ports available on this device</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static DeviceConfiguration.ATAnalogInputConfigManagerUnsafe ATAnalogInputConfigManagerInit(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe inputConfigManager, byte portsAvailable)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            var _ret = _Internal.ATAnalogInputConfigManagerInit(_arg0, portsAvailable);
            DeviceConfiguration.ATAnalogInputConfigManagerUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (DeviceConfiguration.ATAnalogInputConfigManagerUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (DeviceConfiguration.ATAnalogInputConfigManagerUnsafe)DeviceConfiguration.ATAnalogInputConfigManagerUnsafe.NativeToManagedMap[_ret];
            else _result0 = DeviceConfiguration.ATAnalogInputConfigManagerUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Parse data into a analog input config manager object from its binary representation as received from an AirTurn/storage</summary>
        /// <param name="inputConfigManager">The analog input config manager object</param>
        /// <param name="port">The port to parse data for</param>
        /// <param name="data">The data</param>
        /// <param name="lengthParsed">The length of the data</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static bool ATAnalogInputConfigManagerParseData(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe inputConfigManager, DeviceTypes.ATPortUnsafe port, Foundation.ATDataUnsafe data, ref ulong lengthParsed)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            var _arg2 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data._Instance;
            fixed (ulong* _lengthParsed3 = &lengthParsed)
            {
                var _arg3 = _lengthParsed3;
                var _ret = _Internal.ATAnalogInputConfigManagerParseData(_arg0, port, _arg2, _arg3);
                return _ret;
            }
        }

        /// <summary>Get the stored analog analog input config data</summary>
        /// <param name="inputConfigManager">The analog input config</param>
        /// <param name="port">The port to get data for</param>
        /// <param name="optionalDataToFill">An optional data object to fill with the generated data</param>
        /// <returns>The generated data. If `optionalDataToFill` is NULL, returns a data object owned by the analog input config object, otherwise returns `optionalDataToFill`</returns>
        public static Foundation.ATDataUnsafe ATAnalogInputConfigManagerGetData(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe inputConfigManager, DeviceTypes.ATPortUnsafe port, Foundation.ATDataUnsafe optionalDataToFill, bool includeLimits)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            var _arg2 = ReferenceEquals(optionalDataToFill, null) ? global::System.IntPtr.Zero : optionalDataToFill._Instance;
            var _ret = _Internal.ATAnalogInputConfigManagerGetData(_arg0, port, _arg2, includeLimits);
            Foundation.ATDataUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATDataUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Parse data into multiple config objects</summary>
        /// <param name="inputConfigManager">The input config manager</param>
        /// <param name="data">The data to parse</param>
        /// <returns>`true` if successful, otherwise `false`.</returns>
        public static bool ATAnalogInputConfigManagerParseMultiple(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe inputConfigManager, Foundation.ATDataUnsafe data)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            var _arg1 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATAnalogInputConfigManagerParseMultiple(_arg0, _arg1);
            return _ret;
        }

        /// <summary>Get data for multiple configs</summary>
        /// <param name="inputConfigManager">The input config manager</param>
        /// <param name="optionalDataToFill">An optional data object to fill with the generated data</param>
        /// <param name="includeLimits">If `true`, will include the limit values</param>
        /// <returns>`true` if successful, otherwise `false`</returns>
        public static Foundation.ATDataUnsafe ATAnalogInputConfigManagerGetDataMultiple(DeviceConfiguration.ATAnalogInputConfigManagerUnsafe inputConfigManager, Foundation.ATDataUnsafe optionalDataToFill, bool includeLimits)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            var _arg1 = ReferenceEquals(optionalDataToFill, null) ? global::System.IntPtr.Zero : optionalDataToFill._Instance;
            var _ret = _Internal.ATAnalogInputConfigManagerGetDataMultiple(_arg0, _arg1, includeLimits);
            Foundation.ATDataUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATDataUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Apply an analog action to an input config</summary>
        /// <param name="inputConfigManager">The input config manager</param>
        /// <param name="action">The action to apply</param>
        /// <param name="currentValue">The current analog input value for this port, for calibrate now actions. Ignored for other actions</param>
        /// <returns>If successful, `true`, otherwise `false`</returns>
        public static bool ATAnalogInputConfigManagerApplyAnalogAction(.ATAnalogInputConfigManager inputConfigManager, .ATAnalogAction action, short currentValue)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            var _arg1 = ReferenceEquals(action, null) ? global::System.IntPtr.Zero : action._Instance;
            var _ret = _Internal.ATAnalogInputConfigManagerApplyAnalogAction(_arg0, _arg1, currentValue);
            return _ret;
        }

        /// <summary>Get an input config</summary>
        /// <param name="inputConfigManager">The input config manager</param>
        /// <param name="port">The port to get the input config for</param>
        /// <param name="active">If `true`, returns the active input config, otherwise returns the stored input config</param>
        /// <returns>The input config, if port is valid, otherwise `NULL`</returns>
        public static .ATAnalogInputConfig ATAnalogInputConfigManagerGetInputConfig(.ATAnalogInputConfigManager inputConfigManager, .ATPort port, bool active)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            var _ret = _Internal.ATAnalogInputConfigManagerGetInputConfig(_arg0, port, active);
            .ATAnalogInputConfig _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (.ATAnalogInputConfig.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (.ATAnalogInputConfig).ATAnalogInputConfig.NativeToManagedMap[_ret];
            else _result0 = .ATAnalogInputConfig._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Reset all active input configs to the stored configs</summary>
        /// <param name="inputConfigManager">The input config manager</param>
        public static void ATAnalogInputConfigManagerResetToStored(.ATAnalogInputConfigManager inputConfigManager)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            _Internal.ATAnalogInputConfigManagerResetToStored(_arg0);
        }

        /// <summary>Determine if an input config needs updating in storage</summary>
        /// <param name="inputConfigManager">The input config manager</param>
        /// <param name="port">The port</param>
        /// <returns>`true` if storage needs updating for this port</returns>
        public static bool ATAnalogInputConfigManagerStorageNeedsUpdate(.ATAnalogInputConfigManager inputConfigManager, .ATPort port)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            var _ret = _Internal.ATAnalogInputConfigManagerStorageNeedsUpdate(_arg0, port);
            return _ret;
        }

        /// <summary>Inform the input config manager that storage has been updated for a given port</summary>
        /// <param name="inputConfigManager">The input config manager</param>
        /// <param name="port">The port that has been stored</param>
        public static void ATAnalogInputConfigManagerStorageUpdated(.ATAnalogInputConfigManager inputConfigManager, .ATPort port)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            _Internal.ATAnalogInputConfigManagerStorageUpdated(_arg0, port);
        }

        /// <summary>Determine if an input's port config needs clearing in storage</summary>
        /// <param name="inputConfigManager">The input config manager</param>
        /// <param name="port">The port</param>
        /// <returns>`true` if port config needs clearing</returns>
        public static bool ATAnalogInputConfigManagerPortConfigNeedsClearing(.ATAnalogInputConfigManager inputConfigManager, .ATPort port)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            var _ret = _Internal.ATAnalogInputConfigManagerPortConfigNeedsClearing(_arg0, port);
            return _ret;
        }

        /// <summary>Inform the input config manager that a port config has been cleared</summary>
        /// <param name="inputConfigManager">The input config manager</param>
        /// <param name="port">The port</param>
        public static void ATAnalogInputConfigManagerPortConfigCleared(.ATAnalogInputConfigManager inputConfigManager, .ATPort port)
        {
            var _arg0 = ReferenceEquals(inputConfigManager, null) ? global::System.IntPtr.Zero : inputConfigManager._Instance;
            _Internal.ATAnalogInputConfigManagerPortConfigCleared(_arg0, port);
        }

        public .ATBase Base
        {
            get
            {
                return .ATBase._CreateInstance(new global::System.IntPtr(&((.ATAnalogInputConfigManager._Internal*)_Instance)->_base));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((.ATAnalogInputConfigManager._Internal*)_Instance)->_base = *(.ATBase._Internal*)value._Instance;
            }
        }

        public .ATAnalogInputConfig[] InputConfigsStored
        {
            get
            {
                .ATAnalogInputConfig[] _value = null;
                if (((.ATAnalogInputConfigManager._Internal*)_Instance)->_inputConfigsStored != null)
                {
                    _value = new .ATAnalogInputConfig[8];
                    for (int i = 0; i < 8; i++)
                        _value[i] = .ATAnalogInputConfig._CreateInstance(*((.ATAnalogInputConfig._Internal*)&(((.ATAnalogInputConfigManager._Internal*)_Instance)->_inputConfigsStored[i * sizeof(.ATAnalogInputConfig._Internal)])));
                }
                return _value;
            }

            set
            {
                if (value != null)
                {
                    if (value.Length != 8)
                        throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                    for (int i = 0; i < 8; i++)
                        *(.ATAnalogInputConfig._Internal*)&((.ATAnalogInputConfigManager._Internal*)_Instance)->_inputConfigsStored[i * sizeof(.ATAnalogInputConfig._Internal)] = *(.ATAnalogInputConfig._Internal*)value[i]._Instance;
                }
            }
        }

        public bool[] InputConfigStorageNeedsUpdate
        {
            get
            {
                bool[] _value = null;
                if (((.ATAnalogInputConfigManager._Internal*)_Instance)->_inputConfigStorageNeedsUpdate != null)
                {
                    _value = new bool[8];
                    for (int i = 0; i < 8; i++)
                        _value[i] = ((.ATAnalogInputConfigManager._Internal*)_Instance)->_inputConfigStorageNeedsUpdate[i] != 0;
                }
                return _value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 8; i++)
                        ((.ATAnalogInputConfigManager._Internal*)_Instance)->_inputConfigStorageNeedsUpdate[i] = (byte)(value[i] ? 1 : 0);
                }
            }
        }

        public bool[] PortConfigNeedsClearing
        {
            get
            {
                bool[] _value = null;
                if (((.ATAnalogInputConfigManager._Internal*)_Instance)->_portConfigNeedsClearing != null)
                {
                    _value = new bool[8];
                    for (int i = 0; i < 8; i++)
                        _value[i] = ((.ATAnalogInputConfigManager._Internal*)_Instance)->_portConfigNeedsClearing[i] != 0;
                }
                return _value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 8; i++)
                        ((.ATAnalogInputConfigManager._Internal*)_Instance)->_portConfigNeedsClearing[i] = (byte)(value[i] ? 1 : 0);
                }
            }
        }

        public .ATAnalogInputConfig[] InputConfigsActive
        {
            get
            {
                .ATAnalogInputConfig[] _value = null;
                if (((.ATAnalogInputConfigManager._Internal*)_Instance)->_inputConfigsActive != null)
                {
                    _value = new .ATAnalogInputConfig[8];
                    for (int i = 0; i < 8; i++)
                        _value[i] = .ATAnalogInputConfig._CreateInstance(*((.ATAnalogInputConfig._Internal*)&(((.ATAnalogInputConfigManager._Internal*)_Instance)->_inputConfigsActive[i * sizeof(.ATAnalogInputConfig._Internal)])));
                }
                return _value;
            }

            set
            {
                if (value != null)
                {
                    if (value.Length != 8)
                        throw new ArgumentOutOfRangeException("value", "The dimensions of the provided array don't match the required size.");
                    for (int i = 0; i < 8; i++)
                        *(.ATAnalogInputConfig._Internal*)&((.ATAnalogInputConfigManager._Internal*)_Instance)->_inputConfigsActive[i * sizeof(.ATAnalogInputConfig._Internal)] = *(.ATAnalogInputConfig._Internal*)value[i]._Instance;
                }
            }
        }

        public byte PortsAvailable
        {
            get
            {
                return ((.ATAnalogInputConfigManager._Internal*)_Instance)->_portsAvailable;
            }

            set
            {
                ((.ATAnalogInputConfigManager._Internal*)_Instance)->_portsAvailable = value;
            }
        }

        public bool StorageNeedsUpdate
        {
            get
            {
                return ((.ATAnalogInputConfigManager._Internal*)_Instance)->storageNeedsUpdate != 0;
            }

            set
            {
                ((.ATAnalogInputConfigManager._Internal*)_Instance)->storageNeedsUpdate = (byte)(value ? 1 : 0);
            }
        }

        public .ATPort CurrentlyCalibrating
        {
            get
            {
                return ((.ATAnalogInputConfigManager._Internal*)_Instance)->currentlyCalibrating;
            }

            set
            {
                ((.ATAnalogInputConfigManager._Internal*)_Instance)->currentlyCalibrating = value;
            }
        }
    }
}
