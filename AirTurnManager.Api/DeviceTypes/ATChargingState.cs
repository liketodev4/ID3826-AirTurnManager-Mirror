using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATChargingState : byte
    {
        ATChargingStateDisconnectedDischarging = 0,
        ATChargingStateConnectedCharging = 1,
        ATChargingStateConnectedFullyCharged = 2,
        ATChargingStateConnectedValidation = 3,
        ATChargingStateConnectedFault = 4,
        ATChargingStateMinimum = 0,
        ATChargingStateMaximum = 4
    }

    public unsafe partial class ATChargingStateUnsafe
    {
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATChargingStateValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATChargingStateValidate(DeviceTypes.ATChargingState chargingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATChargingStateParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATChargingStateParseData(IntPtr data, DeviceTypes.ATChargingState* chargingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATChargingStateGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATChargingStateGetData(IntPtr data, DeviceTypes.ATChargingState chargingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATChargingStateDescription")]
            internal static extern IntPtr ATChargingStateDescription(DeviceTypes.ATChargingState chargingState);
        }

        /// <summary>Validate a charging state value</summary>
        /// <param name="chargingState">The charging state value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATChargingStateValidate(DeviceTypes.ATChargingState chargingState)
        {
            var _ret = _Internal.ATChargingStateValidate(chargingState);
            return _ret;
        }

        /// <summary>Get a charging state value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="chargingState">On return, contains the charging state value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATChargingStateParseData(DeviceTypes.ATBytes data, ref DeviceTypes.ATChargingState chargingState)
        {
            if (ReferenceEquals(data, null))
                throw new ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            fixed (DeviceTypes.ATChargingState* _chargingState1 = &chargingState)
            {
                var _arg1 = _chargingState1;
                var _ret = _Internal.ATChargingStateParseData(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get the data for a charging state value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="chargingState">The repeat rate value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATChargingStateGetData(DeviceTypes.ATMutableBytes data, DeviceTypes.ATChargingState chargingState)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATChargingStateGetData(_arg0, chargingState);
            return _ret;
        }

        /// <summary>Get a description for a charging state value</summary>
        /// <param name="chargingState">The charging state value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATChargingStateDescription(DeviceTypes.ATChargingState chargingState)
        {
            var _ret = _Internal.ATChargingStateDescription(chargingState);
            if (_ret == IntPtr.Zero)
                return default(string);
            var _retPtr = (byte*)_ret;
            int _length = 0;
            while (*(_retPtr++) != 0) _length += sizeof(byte);
            return Text.Encoding.UTF8.GetString((byte*)_ret, _length);
        }
    }
}
