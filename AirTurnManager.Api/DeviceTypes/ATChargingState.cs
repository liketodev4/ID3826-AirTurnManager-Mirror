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
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATChargingStateValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATChargingStateValidate(global::AirTurnManager.Api.DeviceTypes.ATChargingState chargingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATChargingStateParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATChargingStateParseData(global::System.IntPtr data, global::AirTurnManager.Api.DeviceTypes.ATChargingState* chargingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATChargingStateGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATChargingStateGetData(global::System.IntPtr data, global::AirTurnManager.Api.DeviceTypes.ATChargingState chargingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATChargingStateDescription")]
            internal static extern global::System.IntPtr ATChargingStateDescription(global::AirTurnManager.Api.DeviceTypes.ATChargingState chargingState);
        }

        /// <summary>Validate a charging state value</summary>
        /// <param name="chargingState">The charging state value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATChargingStateValidate(global::AirTurnManager.Api.DeviceTypes.ATChargingState chargingState)
        {
            var __ret = __Internal.ATChargingStateValidate(chargingState);
            return __ret;
        }

        /// <summary>Get a charging state value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="chargingState">On return, contains the charging state value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATChargingStateParseData(global::AirTurnManager.Api.DeviceTypes.ATBytes data, ref global::AirTurnManager.Api.DeviceTypes.ATChargingState chargingState)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var __arg0 = data.__Instance;
            fixed (global::AirTurnManager.Api.DeviceTypes.ATChargingState* __chargingState1 = &chargingState)
            {
                var __arg1 = __chargingState1;
                var __ret = __Internal.ATChargingStateParseData(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get the data for a charging state value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="chargingState">The repeat rate value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATChargingStateGetData(global::AirTurnManager.Api.DeviceTypes.ATMutableBytes data, global::AirTurnManager.Api.DeviceTypes.ATChargingState chargingState)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATChargingStateGetData(__arg0, chargingState);
            return __ret;
        }

        /// <summary>Get a description for a charging state value</summary>
        /// <param name="chargingState">The charging state value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATChargingStateDescription(global::AirTurnManager.Api.DeviceTypes.ATChargingState chargingState)
        {
            var __ret = __Internal.ATChargingStateDescription(chargingState);
            if (__ret == global::System.IntPtr.Zero)
                return default(string);
            var __retPtr = (byte*)__ret;
            int __length = 0;
            while (*(__retPtr++) != 0) __length += sizeof(byte);
            return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
        }
    }
}
