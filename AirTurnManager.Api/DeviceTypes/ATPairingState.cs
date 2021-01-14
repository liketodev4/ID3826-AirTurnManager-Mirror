using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATPairingState : byte
    {
        ATPairingStateNotPaired = 0,
        ATPairingStatePaired = 1,
        ATPairingStateMinimum = 0,
        ATPairingStateMaximum = 1
    }

    public unsafe partial class ATPairingStateUnsafe
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPairingStateValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPairingStateValidate(global::AirTurnManager.Api.DeviceTypes.ATPairingState pairingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPairingStateParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPairingStateParseData(global::System.IntPtr data, global::AirTurnManager.Api.DeviceTypes.ATPairingState* pairingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPairingStateGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPairingStateGetData(global::System.IntPtr data, global::AirTurnManager.Api.DeviceTypes.ATPairingState pairingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATPairingStateDescription")]
            internal static extern global::System.IntPtr ATPairingStateDescription(global::AirTurnManager.Api.DeviceTypes.ATPairingState pairingState);
        }

        /// <summary>Validate a pairing state value</summary>
        /// <param name="pairingState">The pairing state value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATPairingStateValidate(global::AirTurnManager.Api.DeviceTypes.ATPairingState pairingState)
        {
            var __ret = __Internal.ATPairingStateValidate(pairingState);
            return __ret;
        }

        /// <summary>Get a pairing state value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="pairingState">On return, contains the pairing state value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATPairingStateParseData(global::AirTurnManager.Api.DeviceTypes.ATBytes data, ref global::AirTurnManager.Api.DeviceTypes.ATPairingState pairingState)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var __arg0 = data.__Instance;
            fixed (global::AirTurnManager.Api.DeviceTypes.ATPairingState* __pairingState1 = &pairingState)
            {
                var __arg1 = __pairingState1;
                var __ret = __Internal.ATPairingStateParseData(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get the data for a pairing state value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="pairingState">The pairing state value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATPairingStateGetData(global::AirTurnManager.Api.DeviceTypes.ATMutableBytes data, global::AirTurnManager.Api.DeviceTypes.ATPairingState pairingState)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATPairingStateGetData(__arg0, pairingState);
            return __ret;
        }

        /// <summary>Get a description for a pairing state value</summary>
        /// <param name="pairingState">The pairing state value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATPairingStateDescription(global::AirTurnManager.Api.DeviceTypes.ATPairingState pairingState)
        {
            var __ret = __Internal.ATPairingStateDescription(pairingState);
            if (__ret == global::System.IntPtr.Zero)
                return default(string);
            var __retPtr = (byte*)__ret;
            int __length = 0;
            while (*(__retPtr++) != 0) __length += sizeof(byte);
            return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
        }
    }
}
