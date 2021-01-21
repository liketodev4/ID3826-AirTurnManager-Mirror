using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATPorts : byte
    {
        ATPortsPort1 = 1,
        ATPortsPort2 = 2,
        ATPortsPort3 = 4,
        ATPortsPort4 = 8,
        ATPortsPort5 = 16,
        ATPortsPort6 = 32,
        ATPortsPort7 = 64,
        ATPortsPort8 = 128,
        ATPortsMaskAll = 0xff
    }

    public unsafe partial class ATPortsUnsafe
    {
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Net.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPortsValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPortsValidate(byte ports);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Net.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPortsParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPortsParseData(global::System.IntPtr data, byte* ports);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Net.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPortsGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPortsGetData(global::System.IntPtr data, byte ports);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Net.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPortsIsPortSet")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPortsIsPortSet(byte ports, global::AirTurnManager.Api.DeviceTypes.ATPort port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Net.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPortsGetPortsForPort")]
            internal static extern byte ATPortsGetPortsForPort(global::AirTurnManager.Api.DeviceTypes.ATPort port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Net.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPortsDescription")]
            internal static extern void ATPortsDescription(global::System.IntPtr @string, byte ports);
        }

        /// <summary>Validate a digital port state value</summary>
        /// <param name="ports">The digital port state value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATPortsValidate(byte ports)
        {
            var _ret = _Internal.ATPortsValidate(ports);
            return _ret;
        }

        /// <summary>Get a digital port state value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="ports">On return, contains the digital port state value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATPortsParseData(global::AirTurnManager.Api.Foundation.ATBytesUnsafe data, byte* ports)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            var _ret = _Internal.ATPortsParseData(_arg0, ports);
            return _ret;
        }

        /// <summary>Get the data for a digital port state value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="ports">The digital port state value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATPortsGetData(global::AirTurnManager.Api.Foundation.ATMutableBytes data, byte ports)
        {
            var _arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATPortsGetData(_arg0, ports);
            return _ret;
        }

        /// <summary>Determine if a port is set in the port state</summary>
        /// <param name="ports">The digital port state</param>
        /// <param name="port">The port to check</param>
        /// <returns>`true` if set</returns>
        public static bool ATPortsIsPortSet(byte ports, global::AirTurnManager.Api.DeviceTypes.ATPort port)
        {
            var _ret = _Internal.ATPortsIsPortSet(ports, port);
            return _ret;
        }

        /// <summary>Get the ports value for a port</summary>
        /// <param name="port">The port to get</param>
        /// <returns>`true` if set</returns>
        public static byte ATPortsGetPortsForPort(global::AirTurnManager.Api.DeviceTypes.ATPort port)
        {
            var _ret = _Internal.ATPortsGetPortsForPort(port);
            return _ret;
        }

        /// <summary>Get a description for a digital port state value</summary>
        /// <param name="string">The string to append the description to</param>
        /// <param name="ports">The digital port state value</param>
        public static void ATPortsDescription(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string, byte ports)
        {
            var _arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string._Instance;
            _Internal.ATPortsDescription(_arg0, ports);
        }
    }

}
