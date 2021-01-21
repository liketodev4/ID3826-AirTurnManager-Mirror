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
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeValidate(global::AirTurnManager.Api.DeviceTypes.ATMode mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeParseData(global::System.IntPtr data, global::AirTurnManager.Api.DeviceTypes.ATMode* mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeGetData(global::System.IntPtr data, global::AirTurnManager.Api.DeviceTypes.ATMode mode);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeDescription")]
            internal static extern global::System.IntPtr ATModeDescription(global::AirTurnManager.Api.DeviceTypes.ATMode mode);
        }

        /// <summary>Validate a mode value</summary>
        /// <param name="mode">The mode value to validate</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeValidate(global::AirTurnManager.Api.DeviceTypes.ATMode mode)
        {
            var __ret = __Internal.ATModeValidate(mode);
            return __ret;
        }

        /// <summary>Get a mode value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="mode">On return, contains the mode value</param>
        /// <returns>`true` if valid</returns>
        public static bool ATModeParseData(global::AirTurnManager.Api.DeviceTypes.ATBytes data, ref global::AirTurnManager.Api.DeviceTypes.ATMode mode)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var __arg0 = data.__Instance;
            fixed (global::AirTurnManager.Api.DeviceTypes.ATMode* __mode1 = &mode)
            {
                var __arg1 = __mode1;
                var __ret = __Internal.ATModeParseData(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get the data for a mode value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="mode">The repeat rate value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeGetData(global::AirTurnManager.Api.DeviceTypes.ATMutableBytes data, global::AirTurnManager.Api.DeviceTypes.ATMode mode)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATModeGetData(__arg0, mode);
            return __ret;
        }

        /// <summary>Get a description for a mode value</summary>
        /// <param name="mode">The mode value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATModeDescription(global::AirTurnManager.Api.DeviceTypes.ATMode mode)
        {
            var __ret = __Internal.ATModeDescription(mode);
            if (__ret == global::System.IntPtr.Zero)
                return default(string);
            var __retPtr = (byte*)__ret;
            int __length = 0;
            while (*(__retPtr++) != 0) __length += sizeof(byte);
            return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
        }
    }
}
