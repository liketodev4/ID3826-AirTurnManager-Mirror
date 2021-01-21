using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATAnalogInputValueM
    {
        ATAnalogInputValueMinimum = -32768,
        ATAnalogInputValueMaximum = 32767
    }

    public unsafe partial class ATAnalogInputValueUnsafe
    {
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputValueParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputValueParseData(global::System.IntPtr data, short* analogInputValue);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputValueGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATAnalogInputValueGetData(global::System.IntPtr data, short analogInputValue);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATAnalogInputValueDescription")]
            internal static extern void ATAnalogInputValueDescription(global::System.IntPtr @string, short analogInputValue);
        }

        /// <summary>Get a analog input value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="analogInputValue">On return, contains the analog input value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATAnalogInputValueParseData(global::AirTurnManager.Api.DeviceTypes.ATBytes data, ref short analogInputValue)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            fixed (short* _analogInputValue1 = &analogInputValue)
            {
                var _arg1 = _analogInputValue1;
                var _ret = _Internal.ATAnalogInputValueParseData(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get the data for a analog input value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="analogInputValue">The analog input value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATAnalogInputValueGetData(global::AirTurnManager.Api.DeviceTypes.ATMutableBytes data, short analogInputValue)
        {
            var _arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATAnalogInputValueGetData(_arg0, analogInputValue);
            return _ret;
        }

        /// <summary>Get a description for a analog input value</summary>
        /// <param name="string">The string to append the description to</param>
        /// <param name="analogInputValue">The analog input value</param>
        public static void ATAnalogInputValueDescription(global::AirTurnManager.Api.DeviceTypes.ATString @string, short analogInputValue)
        {
            var _arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string._Instance;
            _Internal.ATAnalogInputValueDescription(_arg0, analogInputValue);
        }
    }
}
