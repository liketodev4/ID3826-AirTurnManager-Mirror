using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    public unsafe partial class ATJSONToolsUnsafe
    {
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseBool")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseBool([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, bool* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONStringEquals")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONStringEquals([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr tok, [MarshalAs(UnmanagedType.LPUTF8Str)] string s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseUInt8")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseUInt8([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, byte* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseUInt16")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseUInt16([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, ushort* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseInt8")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseInt8([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, sbyte* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseInt16")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseInt16([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, short* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseLong")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseLong([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, long* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseHexBytes")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseHexBytes([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, byte* bytes, ulong maxSize, ulong* parsedBytesLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONNumTokensInValue")]
            internal static extern int ATJSONNumTokensInValue(global::System.IntPtr token);
        }

        public static bool ATJSONParseBool(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, ref bool val)
        {
            var _arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token._Instance;
            fixed (bool* _val2 = &val)
            {
                var _arg2 = _val2;
                var _ret = _Internal.ATJSONParseBool(json, _arg1, _arg2);
                return _ret;
            }
        }

        public static bool ATJSONStringEquals(string json, global::AirTurnManager.Api.Foundation.Jsmntok tok, string s)
        {
            var _arg1 = ReferenceEquals(tok, null) ? global::System.IntPtr.Zero : tok._Instance;
            var _ret = _Internal.ATJSONStringEquals(json, _arg1, s);
            return _ret;
        }

        public static bool ATJSONParseUInt8(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, byte* val)
        {
            var _arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token._Instance;
            var _ret = _Internal.ATJSONParseUInt8(json, _arg1, val);
            return _ret;
        }

        public static bool ATJSONParseUInt16(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, ref ushort val)
        {
            var _arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token._Instance;
            fixed (ushort* _val2 = &val)
            {
                var _arg2 = _val2;
                var _ret = _Internal.ATJSONParseUInt16(json, _arg1, _arg2);
                return _ret;
            }
        }

        public static bool ATJSONParseInt8(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, sbyte* val)
        {
            var _arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token._Instance;
            var _ret = _Internal.ATJSONParseInt8(json, _arg1, val);
            return _ret;
        }

        public static bool ATJSONParseInt16(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, ref short val)
        {
            var _arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token._Instance;
            fixed (short* _val2 = &val)
            {
                var _arg2 = _val2;
                var _ret = _Internal.ATJSONParseInt16(json, _arg1, _arg2);
                return _ret;
            }
        }

        public static bool ATJSONParseLong(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, ref long val)
        {
            var _arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token._Instance;
            fixed (long* _val2 = &val)
            {
                var _arg2 = _val2;
                var _ret = _Internal.ATJSONParseLong(json, _arg1, _arg2);
                return _ret;
            }
        }

        public static bool ATJSONParseHexBytes(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, byte* bytes, ulong maxSize, ref ulong parsedBytesLength)
        {
            var _arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token._Instance;
            fixed (ulong* _parsedBytesLength4 = &parsedBytesLength)
            {
                var _arg4 = _parsedBytesLength4;
                var _ret = _Internal.ATJSONParseHexBytes(json, _arg1, bytes, maxSize, _arg4);
                return _ret;
            }
        }

        public static int ATJSONNumTokensInValue(global::AirTurnManager.Api.Foundation.Jsmntok token)
        {
            var _arg0 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token._Instance;
            var _ret = _Internal.ATJSONNumTokensInValue(_arg0);
            return _ret;
        }
    }
}
