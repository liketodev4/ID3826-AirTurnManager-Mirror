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
                EntryPoint = "?ATSwapInt16@@YAGG@Z")]
            internal static extern ushort ATSwapInt16(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32@@YAII@Z")]
            internal static extern uint ATSwapInt32(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16BigToHost@@YAGG@Z")]
            internal static extern ushort ATSwapInt16BigToHost(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32BigToHost@@YAII@Z")]
            internal static extern uint ATSwapInt32BigToHost(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64BigToHost@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64BigToHost(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16HostToBig@@YAGG@Z")]
            internal static extern ushort ATSwapInt16HostToBig(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32HostToBig@@YAII@Z")]
            internal static extern uint ATSwapInt32HostToBig(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64HostToBig@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64HostToBig(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16LittleToHost@@YAGG@Z")]
            internal static extern ushort ATSwapInt16LittleToHost(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32LittleToHost@@YAII@Z")]
            internal static extern uint ATSwapInt32LittleToHost(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64LittleToHost@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64LittleToHost(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16HostToLittle@@YAGG@Z")]
            internal static extern ushort ATSwapInt16HostToLittle(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32HostToLittle@@YAII@Z")]
            internal static extern uint ATSwapInt32HostToLittle(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64HostToLittle@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64HostToLittle(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertFloatHostToSwapped@@YA?AUATSwappedFloat32@@M@Z")]
            internal static extern global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe._Internal ATConvertFloatHostToSwapped(float arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertFloatSwappedToHost@@YAMUATSwappedFloat32@@@Z")]
            internal static extern float ATConvertFloatSwappedToHost(global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe._Internal arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertDoubleHostToSwapped@@YA?AUATSwappedFloat64@@N@Z")]
            internal static extern global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe._Internal ATConvertDoubleHostToSwapped(double arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertDoubleSwappedToHost@@YANUATSwappedFloat64@@@Z")]
            internal static extern double ATConvertDoubleSwappedToHost(global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe._Internal arg);

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

        public static ushort ATSwapInt16(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16(arg);
            return _ret;
        }

        public static uint ATSwapInt32(uint arg)
        {
            var _ret = _Internal.ATSwapInt32(arg);
            return _ret;
        }

        public static ulong ATSwapInt64(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64(arg);
            return _ret;
        }

        public static ushort ATSwapInt16BigToHost(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16BigToHost(arg);
            return _ret;
        }

        public static uint ATSwapInt32BigToHost(uint arg)
        {
            var _ret = _Internal.ATSwapInt32BigToHost(arg);
            return _ret;
        }

        public static ulong ATSwapInt64BigToHost(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64BigToHost(arg);
            return _ret;
        }

        public static ushort ATSwapInt16HostToBig(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16HostToBig(arg);
            return _ret;
        }

        public static uint ATSwapInt32HostToBig(uint arg)
        {
            var _ret = _Internal.ATSwapInt32HostToBig(arg);
            return _ret;
        }

        public static ulong ATSwapInt64HostToBig(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64HostToBig(arg);
            return _ret;
        }

        public static ushort ATSwapInt16LittleToHost(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16LittleToHost(arg);
            return _ret;
        }

        public static uint ATSwapInt32LittleToHost(uint arg)
        {
            var _ret = _Internal.ATSwapInt32LittleToHost(arg);
            return _ret;
        }

        public static ulong ATSwapInt64LittleToHost(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64LittleToHost(arg);
            return _ret;
        }

        public static ushort ATSwapInt16HostToLittle(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16HostToLittle(arg);
            return _ret;
        }

        public static uint ATSwapInt32HostToLittle(uint arg)
        {
            var _ret = _Internal.ATSwapInt32HostToLittle(arg);
            return _ret;
        }

        public static ulong ATSwapInt64HostToLittle(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64HostToLittle(arg);
            return _ret;
        }

        public static global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe ATConvertFloatHostToSwapped(float arg)
        {
            var _ret = _Internal.ATConvertFloatHostToSwapped(arg);
            return global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe._CreateInstance(_ret);
        }

        public static float ATConvertFloatSwappedToHost(global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe arg)
        {
            if (ReferenceEquals(arg, null))
                throw new global::System.ArgumentNullException("arg", "Cannot be null because it is passed by value.");
            var _arg0 = arg._Instance;
            var _ret = _Internal.ATConvertFloatSwappedToHost(*(global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe._Internal*)_arg0);
            return _ret;
        }

        public static global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe ATConvertDoubleHostToSwapped(double arg)
        {
            var _ret = _Internal.ATConvertDoubleHostToSwapped(arg);
            return global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe._CreateInstance(_ret);
        }

        public static double ATConvertDoubleSwappedToHost(global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe arg)
        {
            if (ReferenceEquals(arg, null))
                throw new global::System.ArgumentNullException("arg", "Cannot be null because it is passed by value.");
            var _arg0 = arg._Instance;
            var _ret = _Internal.ATConvertDoubleSwappedToHost(*(global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe._Internal*)_arg0);
            return _ret;
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
