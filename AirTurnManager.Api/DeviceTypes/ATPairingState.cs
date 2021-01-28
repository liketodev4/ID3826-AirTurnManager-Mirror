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
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATPairingStateValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPairingStateValidate(DeviceTypes.ATPairingState pairingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATPairingStateParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPairingStateParseData(IntPtr data, DeviceTypes.ATPairingState* pairingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATPairingStateGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATPairingStateGetData(IntPtr data, DeviceTypes.ATPairingState pairingState);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATPairingStateDescription")]
            internal static extern IntPtr ATPairingStateDescription(DeviceTypes.ATPairingState pairingState);
        }

        /// <summary>Validate a pairing state value</summary>
        /// <param name="pairingState">The pairing state value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATPairingStateValidate(DeviceTypes.ATPairingState pairingState)
        {
            var _ret = _Internal.ATPairingStateValidate(pairingState);
            return _ret;
        }

        /// <summary>Get a pairing state value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="pairingState">On return, contains the pairing state value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATPairingStateParseData(Foundation.ATBytes data, ref DeviceTypes.ATPairingState pairingState)
        {
            if (ReferenceEquals(data, null))
                throw new ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            fixed (DeviceTypes.ATPairingState* _pairingState1 = &pairingState)
            {
                var _arg1 = _pairingState1;
                var _ret = _Internal.ATPairingStateParseData(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get the data for a pairing state value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="pairingState">The pairing state value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATPairingStateGetData(Foundation.ATMutableBytes data, DeviceTypes.ATPairingState pairingState)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATPairingStateGetData(_arg0, pairingState);
            return _ret;
        }

        /// <summary>Get a description for a pairing state value</summary>
        /// <param name="pairingState">The pairing state value</param>
        /// <returns>A null-terminated constant string</returns>
        public static string ATPairingStateDescription(DeviceTypes.ATPairingState pairingState)
        {
            var _ret = _Internal.ATPairingStateDescription(pairingState);
            if (_ret == IntPtr.Zero)
                return default(string);
            var _retPtr = (byte*)_ret;
            int _length = 0;
            while (*(_retPtr++) != 0) _length += sizeof(byte);
            return Text.Encoding.UTF8.GetString((byte*)_ret, _length);
        }
    }
}
