using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATMode : byte
    {
        ATModeNone = 0,
        ATMode1 = 1,
        ATMode2 = 2,
        ATMode3 = 3,
        ATMode4 = 4,
        ATMode5 = 5,
        ATMode6 = 6,
        ATMode7 = 7,
        ATMode8 = 8,
        ATModeMinimum = 1,
        ATModeMaximum = 8,
        ATModeMaxNumberOfModes = 8
    }

    public unsafe partial class ATModeUnsafe
    {
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeValidate(DeviceTypes.ATMode mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeParseData(IntPtr data, DeviceTypes.ATMode* mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeGetData(IntPtr data, DeviceTypes.ATMode mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeDescription")]
            internal static extern IntPtr ATModeDescription(DeviceTypes.ATMode mode);
        }

        /// <summary>Validate a mode value</summary>
        /// <param name="mode">The mode value to validate</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeValidate(DeviceTypes.ATMode mode)
        {
            var _ret = _Internal.ATModeValidate(mode);
            return _ret;
        }

        /// <summary>Get a mode value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="mode">On return, contains the mode value</param>
        /// <returns>`true` if valid</returns>
        public static bool ATModeParseData(DeviceTypes.ATBytes data, ref DeviceTypes.ATMode mode)
        {
            if (ReferenceEquals(data, null))
                throw new ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            fixed (DeviceTypes.ATMode* _mode1 = &mode)
            {
                var _arg1 = _mode1;
                var _ret = _Internal.ATModeParseData(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get the data for a mode value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="mode">The repeat rate value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeGetData(DeviceTypes.ATMutableBytes data, DeviceTypes.ATMode mode)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATModeGetData(_arg0, mode);
            return _ret;
        }

        /// <summary>Get a description for a mode value</summary>
        /// <param name="mode">The mode value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATModeDescription(DeviceTypes.ATMode mode)
        {
            var _ret = _Internal.ATModeDescription(mode);
            if (_ret == IntPtr.Zero)
                return default(string);
            var _retPtr = (byte*)_ret;
            int _length = 0;
            while (*(_retPtr++) != 0) _length += sizeof(byte);
            return Text.Encoding.UTF8.GetString((byte*)_ret, _length);
        }
    }
}
