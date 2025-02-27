﻿using System;
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
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATConnectionControlValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATConnectionControlValidate(DeviceTypes.ATConnectionControl connectionControl);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATConnectionControlParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATConnectionControlParseData(IntPtr data, DeviceTypes.ATConnectionControl* connectionControl);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATConnectionControlGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATConnectionControlGetData(IntPtr data, DeviceTypes.ATConnectionControl connectionControl);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATConnectionControlDescription")]
            internal static extern IntPtr ATConnectionControlDescription(DeviceTypes.ATConnectionControl connectionControl);
        }

        /// <summary>Validate a connection control value</summary>
        /// <param name="connectionControl">The connection control value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATConnectionControlValidate(DeviceTypes.ATConnectionControl connectionControl)
        {
            var _ret = _Internal.ATConnectionControlValidate(connectionControl);
            return _ret;
        }

        /// <summary>Get a connection control value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="connectionControl">On return, contains the connection control value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATConnectionControlParseData(DeviceTypes.ATBytes data, ref DeviceTypes.ATConnectionControl connectionControl)
        {
            if (ReferenceEquals(data, null))
                throw new ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            fixed (DeviceTypes.ATConnectionControl* _connectionControl1 = &connectionControl)
            {
                var _arg1 = _connectionControl1;
                var _ret = _Internal.ATConnectionControlParseData(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get the data for a connection control value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="connectionControl">The connection control value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATConnectionControlGetData(DeviceTypes.ATMutableBytes data, DeviceTypes.ATConnectionControl connectionControl)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATConnectionControlGetData(_arg0, connectionControl);
            return _ret;
        }

        /// <summary>Get a description for a connection control value</summary>
        /// <param name="connectionControl">The connection control value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATConnectionControlDescription(DeviceTypes.ATConnectionControl connectionControl)
        {
            var _ret = _Internal.ATConnectionControlDescription(connectionControl);
            if (_ret == IntPtr.Zero)
                return default(string);
            var _retPtr = (byte*)_ret;
            int _length = 0;
            while (*(_retPtr++) != 0) _length += sizeof(byte);
            return Text.Encoding.UTF8.GetString((byte*)_ret, _length);
        }
    }
}
