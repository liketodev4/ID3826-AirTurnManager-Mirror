using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATModelID : byte
    {
        // BLE113 models
        ATModelIDPED = 0,
        ATModelIDPEDpro = 1,
        ATModelIDDIGIT3 = 2,
        ATModelIDBT200 = 3,
        ATModelIDBT200S2 = 4,
        ATModelIDBT200S4 = 5,
        ATModelIDBT200S6 = 6,
        ATModelIDQUAD200 = 7,

        // Nordic models
        ATModelIDDevKit = 8,
        ATModelIDBT500 = 9,
        ATModelIDBT500S2 = 10,
        ATModelIDBT500S4 = 11,
        ATModelIDBT500S6 = 12,
        ATModelIDQUAD500 = 13,
        ATModelIDPEDpro500 = 14,
        ATModelIDDIGIT500 = 15,

        ATModelIDMinimum = 0,
        ATModelIDMaximum = 15,
        ATModelIDMaximumBLE113Model = 7,
        ATModelIDMinimumNordicModel = 8,

        ATModelIDInvalid = 255
    }

    public unsafe partial class ATModelIDUnsafe
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModelIDDescription")]
            internal static extern global::System.IntPtr ATModelIDDescription(global::AirTurnManager.Api.DeviceTypes.ATModelID modelID);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModelIDIsBLE113")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModelIDIsBLE113(global::AirTurnManager.Api.DeviceTypes.ATModelID modelID);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModelIDIsNordic")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModelIDIsNordic(global::AirTurnManager.Api.DeviceTypes.ATModelID modelID);
        }

        /// <summary>Get a description for a model ID value</summary>
        /// <param name="modelID">The modelID value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATModelIDDescription(global::AirTurnManager.Api.DeviceTypes.ATModelID modelID)
        {
            var __ret = __Internal.ATModelIDDescription(modelID);
            if (__ret == global::System.IntPtr.Zero)
                return default(string);
            var __retPtr = (byte*)__ret;
            int __length = 0;
            while (*(__retPtr++) != 0) __length += sizeof(byte);
            return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
        }

        /// <summary>Determines if a given model ID is a BLE113 based model</summary>
        /// <param name="modelID">The model ID</param>
        /// <returns>`true` if model is a BLE113 model</returns>
        public static bool ATModelIDIsBLE113(global::AirTurnManager.Api.DeviceTypes.ATModelID modelID)
        {
            var __ret = __Internal.ATModelIDIsBLE113(modelID);
            return __ret;
        }

        /// <summary>Determines if a given model ID is a Nordic based model</summary>
        /// <param name="modelID">The model ID</param>
        /// <returns>`true` if model is a Nordic model</returns>
        public static bool ATModelIDIsNordic(global::AirTurnManager.Api.DeviceTypes.ATModelID modelID)
        {
            var __ret = __Internal.ATModelIDIsNordic(modelID);
            return __ret;
        }
    }
}
