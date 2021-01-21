using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATPort : byte
    {
        ATPortNone = 0,
        ATPort1 = 1,
        ATPort2 = 2,
        ATPort3 = 3,
        ATPort4 = 4,
        ATPort5 = 5,
        ATPort6 = 6,
        ATPort7 = 7,
        ATPort8 = 8,
        ATPortMinimum = 1,
        ATPortMaximum = 8,
        ATPortMaxNumberOfPorts = 8
    }

    public unsafe partial class ATPortUnsafe
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPortValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPortValidate(global::AirTurnManager.Api.DeviceTypes.ATPort port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPortParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPortParseData(global::System.IntPtr data, global::AirTurnManager.Api.DeviceTypes.ATPort* port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPortGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPortGetData(global::System.IntPtr data, global::AirTurnManager.Api.DeviceTypes.ATPort port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPortDescription")]
            internal static extern global::System.IntPtr ATPortDescription(global::AirTurnManager.Api.DeviceTypes.ATPort port);
        }

        /// <summary>Validate a port value</summary>
        /// <param name="port">The port value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATPortValidate(global::AirTurnManager.Api.DeviceTypes.ATPort port)
        {
            var __ret = __Internal.ATPortValidate(port);
            return __ret;
        }

        /// <summary>Get a port value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="port">On return, contains the port value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATPortParseData(global::AirTurnManager.Api.DeviceTypes.ATBytes data, ref global::AirTurnManager.Api.DeviceTypes.ATPort port)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var __arg0 = data.__Instance;
            fixed (global::AirTurnManager.Api.DeviceTypes.ATPort* __port1 = &port)
            {
                var __arg1 = __port1;
                var __ret = __Internal.ATPortParseData(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get the data for a port value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="port">The port value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATPortGetData(global::AirTurnManager.Api.DeviceTypes.ATMutableBytes data, global::AirTurnManager.Api.DeviceTypes.ATPort port)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATPortGetData(__arg0, port);
            return __ret;
        }

        /// <summary>Get a description for a port value</summary>
        /// <param name="port">The port value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATPortDescription(global::AirTurnManager.Api.DeviceTypes.ATPort port)
        {
            var __ret = __Internal.ATPortDescription(port);
            if (__ret == global::System.IntPtr.Zero)
                return default(string);
            var __retPtr = (byte*)__ret;
            int __length = 0;
            while (*(__retPtr++) != 0) __length += sizeof(byte);
            return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
        }
    }
}
