using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATPortEnum : byte
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
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATPortValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPortValidate(DeviceTypes.ATPortEnum port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATPortParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPortParseData(IntPtr data, DeviceTypes.ATPortEnum* port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATPortGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPortGetData(IntPtr data, DeviceTypes.ATPortEnum port);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATPortDescription")]
            internal static extern IntPtr ATPortDescription(DeviceTypes.ATPortEnum port);
        }

        /// <summary>Validate a port value</summary>
        /// <param name="port">The port value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATPortValidate(DeviceTypes.ATPortEnum port)
        {
            var _ret = _Internal.ATPortValidate(port);
            return _ret;
        }

        /// <summary>Get a port value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="port">On return, contains the port value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATPortParseData(Foundation.ATBytesUnsafe data, ref DeviceTypes.ATPortEnum port)
        {
            if (ReferenceEquals(data, null))
                throw new ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            fixed (DeviceTypes.ATPortEnum* _port1 = &port)
            {
                var _arg1 = _port1;
                var _ret = _Internal.ATPortParseData(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get the data for a port value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="port">The port value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATPortGetData(Foundation.ATMutableBytes data, DeviceTypes.ATPortEnum port)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATPortGetData(_arg0, port);
            return _ret;
        }

        /// <summary>Get a description for a port value</summary>
        /// <param name="port">The port value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATPortDescription(DeviceTypes.ATPortEnum port)
        {
            var _ret = _Internal.ATPortDescription(port);
            if (_ret == IntPtr.Zero)
                return default(string);
            var _retPtr = (byte*)_ret;
            int _length = 0;
            while (*(_retPtr++) != 0) _length += sizeof(byte);
            return Text.Encoding.UTF8.GetString((byte*)_ret, _length);
        }
    }
}
