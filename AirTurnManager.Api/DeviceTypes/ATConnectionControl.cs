using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATConnectionControl : byte
    {
        ATConnectionControlDiscovery = 0,
        ATConnectionControlNormal = 1,
        ATConnectionControlMinimum = 0,
        ATConnectionControlMaximum = 1
    }

    public unsafe partial class ATConnectionControlUnsafe
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATConnectionControlValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATConnectionControlValidate(global::AirTurnManager.Api.DeviceTypes.ATConnectionControl connectionControl);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATConnectionControlParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATConnectionControlParseData(global::System.IntPtr data, global::AirTurnManager.Api.DeviceTypes.ATConnectionControl* connectionControl);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATConnectionControlGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATConnectionControlGetData(global::System.IntPtr data, global::AirTurnManager.Api.DeviceTypes.ATConnectionControl connectionControl);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATConnectionControlDescription")]
            internal static extern global::System.IntPtr ATConnectionControlDescription(global::AirTurnManager.Api.DeviceTypes.ATConnectionControl connectionControl);
        }

        /// <summary>Validate a connection control value</summary>
        /// <param name="connectionControl">The connection control value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATConnectionControlValidate(global::AirTurnManager.Api.DeviceTypes.ATConnectionControl connectionControl)
        {
            var __ret = __Internal.ATConnectionControlValidate(connectionControl);
            return __ret;
        }

        /// <summary>Get a connection control value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="connectionControl">On return, contains the connection control value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATConnectionControlParseData(global::AirTurnManager.Api.DeviceTypes.ATBytes data, ref global::AirTurnManager.Api.DeviceTypes.ATConnectionControl connectionControl)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var __arg0 = data.__Instance;
            fixed (global::AirTurnManager.Api.DeviceTypes.ATConnectionControl* __connectionControl1 = &connectionControl)
            {
                var __arg1 = __connectionControl1;
                var __ret = __Internal.ATConnectionControlParseData(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get the data for a connection control value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="connectionControl">The connection control value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATConnectionControlGetData(global::AirTurnManager.Api.DeviceTypes.ATMutableBytes data, global::AirTurnManager.Api.DeviceTypes.ATConnectionControl connectionControl)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATConnectionControlGetData(__arg0, connectionControl);
            return __ret;
        }

        /// <summary>Get a description for a connection control value</summary>
        /// <param name="connectionControl">The connection control value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATConnectionControlDescription(global::AirTurnManager.Api.DeviceTypes.ATConnectionControl connectionControl)
        {
            var __ret = __Internal.ATConnectionControlDescription(connectionControl);
            if (__ret == global::System.IntPtr.Zero)
                return default(string);
            var __retPtr = (byte*)__ret;
            int __length = 0;
            while (*(__retPtr++) != 0) __length += sizeof(byte);
            return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
        }
    }
}
