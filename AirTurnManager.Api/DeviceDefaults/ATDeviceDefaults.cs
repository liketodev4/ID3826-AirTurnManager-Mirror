using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceDefaults
{
    public unsafe partial class ATDeviceDefaults : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr defaultPortConfig;

            [FieldOffset(8)]
            internal global::AirTurnManager.Api.DeviceTypes.ATModeUnsafe portConfigMinMode;

            [FieldOffset(9)]
            internal byte portConfigNumModes;

            [FieldOffset(10)]
            internal global::AirTurnManager.Api.DeviceTypes.ATPort portConfigMinPort;

            [FieldOffset(11)]
            internal byte portConfigNumPorts;

            [FieldOffset(12)]
            internal byte portConfigBytesLength;

            [FieldOffset(13)]
            internal byte delayBeforeRepeat;

            [FieldOffset(14)]
            internal byte repeatRate;

            [FieldOffset(16)]
            internal ushort idlePowerOff;

            [FieldOffset(18)]
            internal global::AirTurnManager.Api.DeviceDefaults.ATConnectionConfiguration connectionConfiguration;

            [FieldOffset(19)]
            internal global::AirTurnManager.Api.DeviceDefaults.ATPairingMethod pairingMethod;

            [FieldOffset(20)]
            internal ushort debounceTime;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATDeviceDefaults@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr _instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16@@YAGG@Z")]
            internal static extern ushort ATSwapInt16(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32@@YAII@Z")]
            internal static extern uint ATSwapInt32(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16BigToHost@@YAGG@Z")]
            internal static extern ushort ATSwapInt16BigToHost(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32BigToHost@@YAII@Z")]
            internal static extern uint ATSwapInt32BigToHost(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64BigToHost@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64BigToHost(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16HostToBig@@YAGG@Z")]
            internal static extern ushort ATSwapInt16HostToBig(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32HostToBig@@YAII@Z")]
            internal static extern uint ATSwapInt32HostToBig(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64HostToBig@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64HostToBig(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16LittleToHost@@YAGG@Z")]
            internal static extern ushort ATSwapInt16LittleToHost(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32LittleToHost@@YAII@Z")]
            internal static extern uint ATSwapInt32LittleToHost(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64LittleToHost@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64LittleToHost(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16HostToLittle@@YAGG@Z")]
            internal static extern ushort ATSwapInt16HostToLittle(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32HostToLittle@@YAII@Z")]
            internal static extern uint ATSwapInt32HostToLittle(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64HostToLittle@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64HostToLittle(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertFloatHostToSwapped@@YA?AUATSwappedFloat32@@M@Z")]
            internal static extern global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat32._Internal ATConvertFloatHostToSwapped(float arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertFloatSwappedToHost@@YAMUATSwappedFloat32@@@Z")]
            internal static extern float ATConvertFloatSwappedToHost(global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat32._Internal arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertDoubleHostToSwapped@@YA?AUATSwappedFloat64@@N@Z")]
            internal static extern global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat64._Internal ATConvertDoubleHostToSwapped(double arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertDoubleSwappedToHost@@YANUATSwappedFloat64@@@Z")]
            internal static extern double ATConvertDoubleSwappedToHost(global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat64._Internal arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceDefaults.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDeviceDefaultsGetDefaultPortConfig")]
            internal static extern void ATDeviceDefaultsGetDefaultPortConfig(global::System.IntPtr @return, global::System.IntPtr deviceDefaults, global::AirTurnManager.Api.DeviceDefaults.ATMode mode, global::AirTurnManager.Api.DeviceDefaults.ATPort port);
        }

        public global::System.IntPtr _Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults>();

        protected bool _ownsNativeInstance;

        internal static global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults _CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults _CreateInstance(global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults(native, skipVTables);
        }

        private static void* _CopyValue(global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal));
            *(global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATDeviceDefaults(global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATDeviceDefaults(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new global::System.IntPtr(native);
        }

        public ATDeviceDefaults()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATDeviceDefaults(global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance) = *((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public static ushort ATSwapInt16(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16(arg);
            return _ret;
        }

        public static uint ATSwapInt32(uint arg)
        {
            var _ret = _Internal.ATSwapInt32(arg);
            return _ret;
        }

        public static ulong ATSwapInt64(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64(arg);
            return _ret;
        }

        public static ushort ATSwapInt16BigToHost(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16BigToHost(arg);
            return _ret;
        }

        public static uint ATSwapInt32BigToHost(uint arg)
        {
            var _ret = _Internal.ATSwapInt32BigToHost(arg);
            return _ret;
        }

        public static ulong ATSwapInt64BigToHost(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64BigToHost(arg);
            return _ret;
        }

        public static ushort ATSwapInt16HostToBig(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16HostToBig(arg);
            return _ret;
        }

        public static uint ATSwapInt32HostToBig(uint arg)
        {
            var _ret = _Internal.ATSwapInt32HostToBig(arg);
            return _ret;
        }

        public static ulong ATSwapInt64HostToBig(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64HostToBig(arg);
            return _ret;
        }

        public static ushort ATSwapInt16LittleToHost(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16LittleToHost(arg);
            return _ret;
        }

        public static uint ATSwapInt32LittleToHost(uint arg)
        {
            var _ret = _Internal.ATSwapInt32LittleToHost(arg);
            return _ret;
        }

        public static ulong ATSwapInt64LittleToHost(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64LittleToHost(arg);
            return _ret;
        }

        public static ushort ATSwapInt16HostToLittle(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16HostToLittle(arg);
            return _ret;
        }

        public static uint ATSwapInt32HostToLittle(uint arg)
        {
            var _ret = _Internal.ATSwapInt32HostToLittle(arg);
            return _ret;
        }

        public static ulong ATSwapInt64HostToLittle(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64HostToLittle(arg);
            return _ret;
        }

        public static global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat32 ATConvertFloatHostToSwapped(float arg)
        {
            var _ret = _Internal.ATConvertFloatHostToSwapped(arg);
            return global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat32._CreateInstance(_ret);
        }

        public static float ATConvertFloatSwappedToHost(global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat32 arg)
        {
            if (ReferenceEquals(arg, null))
                throw new global::System.ArgumentNullException("arg", "Cannot be null because it is passed by value.");
            var _arg0 = arg._Instance;
            var _ret = _Internal.ATConvertFloatSwappedToHost(*(global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat32._Internal*)_arg0);
            return _ret;
        }

        public static global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat64 ATConvertDoubleHostToSwapped(double arg)
        {
            var _ret = _Internal.ATConvertDoubleHostToSwapped(arg);
            return global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat64._CreateInstance(_ret);
        }

        public static double ATConvertDoubleSwappedToHost(global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat64 arg)
        {
            if (ReferenceEquals(arg, null))
                throw new global::System.ArgumentNullException("arg", "Cannot be null because it is passed by value.");
            var _arg0 = arg._Instance;
            var _ret = _Internal.ATConvertDoubleSwappedToHost(*(global::AirTurnManager.Api.DeviceDefaults.ATSwappedFloat64._Internal*)_arg0);
            return _ret;
        }

        public static global::AirTurnManager.Api.DeviceDefaults.ATBytes ATDeviceDefaultsGetDefaultPortConfig(global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults deviceDefaults, global::AirTurnManager.Api.DeviceDefaults.ATMode mode, global::AirTurnManager.Api.DeviceDefaults.ATPort port)
        {
            var _arg0 = ReferenceEquals(deviceDefaults, null) ? global::System.IntPtr.Zero : deviceDefaults._Instance;
            var _ret = new global::AirTurnManager.Api.DeviceDefaults.ATBytes._Internal();
            _Internal.ATDeviceDefaultsGetDefaultPortConfig(new IntPtr(&_ret), _arg0, mode, port);
            return global::AirTurnManager.Api.DeviceDefaults.ATBytes._CreateInstance(_ret);
        }

        public byte* DefaultPortConfig
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->defaultPortConfig;
            }

            set
            {
                ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->defaultPortConfig = (global::System.IntPtr)value;
            }
        }

        public global::AirTurnManager.Api.DeviceDefaults.ATMode PortConfigMinMode
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->portConfigMinMode;
            }
        }

        public byte PortConfigNumModes
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->portConfigNumModes;
            }
        }

        public global::AirTurnManager.Api.DeviceDefaults.ATPort PortConfigMinPort
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->portConfigMinPort;
            }
        }

        public byte PortConfigNumPorts
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->portConfigNumPorts;
            }
        }

        public byte PortConfigBytesLength
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->portConfigBytesLength;
            }
        }

        public byte DelayBeforeRepeat
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->delayBeforeRepeat;
            }
        }

        public byte RepeatRate
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->repeatRate;
            }
        }

        public ushort IdlePowerOff
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->idlePowerOff;
            }
        }

        public global::AirTurnManager.Api.DeviceDefaults.ATConnectionConfiguration ConnectionConfiguration
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->connectionConfiguration;
            }
        }

        public global::AirTurnManager.Api.DeviceDefaults.ATPairingMethod PairingMethod
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->pairingMethod;
            }
        }

        public ushort DebounceTime
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceDefaults.ATDeviceDefaults._Internal*)_Instance)->debounceTime;
            }
        }
    }
}
