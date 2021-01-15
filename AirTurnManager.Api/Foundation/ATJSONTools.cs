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
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16@@YAGG@Z")]
            internal static extern ushort ATSwapInt16(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32@@YAII@Z")]
            internal static extern uint ATSwapInt32(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16BigToHost@@YAGG@Z")]
            internal static extern ushort ATSwapInt16BigToHost(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32BigToHost@@YAII@Z")]
            internal static extern uint ATSwapInt32BigToHost(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64BigToHost@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64BigToHost(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16HostToBig@@YAGG@Z")]
            internal static extern ushort ATSwapInt16HostToBig(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32HostToBig@@YAII@Z")]
            internal static extern uint ATSwapInt32HostToBig(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64HostToBig@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64HostToBig(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16LittleToHost@@YAGG@Z")]
            internal static extern ushort ATSwapInt16LittleToHost(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32LittleToHost@@YAII@Z")]
            internal static extern uint ATSwapInt32LittleToHost(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64LittleToHost@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64LittleToHost(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16HostToLittle@@YAGG@Z")]
            internal static extern ushort ATSwapInt16HostToLittle(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32HostToLittle@@YAII@Z")]
            internal static extern uint ATSwapInt32HostToLittle(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64HostToLittle@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64HostToLittle(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertFloatHostToSwapped@@YA?AUATSwappedFloat32@@M@Z")]
            internal static extern global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe.__Internal ATConvertFloatHostToSwapped(float arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertFloatSwappedToHost@@YAMUATSwappedFloat32@@@Z")]
            internal static extern float ATConvertFloatSwappedToHost(global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe.__Internal arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertDoubleHostToSwapped@@YA?AUATSwappedFloat64@@N@Z")]
            internal static extern global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe.__Internal ATConvertDoubleHostToSwapped(double arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertDoubleSwappedToHost@@YANUATSwappedFloat64@@@Z")]
            internal static extern double ATConvertDoubleSwappedToHost(global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe.__Internal arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseBool")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseBool([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, bool* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONStringEquals")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONStringEquals([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr tok, [MarshalAs(UnmanagedType.LPUTF8Str)] string s);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseUInt8")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseUInt8([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, byte* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseUInt16")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseUInt16([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, ushort* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseInt8")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseInt8([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, sbyte* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseInt16")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseInt16([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, short* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseLong")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseLong([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, long* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseHexBytes")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParseHexBytes([MarshalAs(UnmanagedType.LPUTF8Str)] string json, global::System.IntPtr token, byte* bytes, ulong maxSize, ulong* parsedBytesLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONNumTokensInValue")]
            internal static extern int ATJSONNumTokensInValue(global::System.IntPtr token);
        }

        public static ushort ATSwapInt16(ushort arg)
        {
            var __ret = __Internal.ATSwapInt16(arg);
            return __ret;
        }

        public static uint ATSwapInt32(uint arg)
        {
            var __ret = __Internal.ATSwapInt32(arg);
            return __ret;
        }

        public static ulong ATSwapInt64(ulong arg)
        {
            var __ret = __Internal.ATSwapInt64(arg);
            return __ret;
        }

        public static ushort ATSwapInt16BigToHost(ushort arg)
        {
            var __ret = __Internal.ATSwapInt16BigToHost(arg);
            return __ret;
        }

        public static uint ATSwapInt32BigToHost(uint arg)
        {
            var __ret = __Internal.ATSwapInt32BigToHost(arg);
            return __ret;
        }

        public static ulong ATSwapInt64BigToHost(ulong arg)
        {
            var __ret = __Internal.ATSwapInt64BigToHost(arg);
            return __ret;
        }

        public static ushort ATSwapInt16HostToBig(ushort arg)
        {
            var __ret = __Internal.ATSwapInt16HostToBig(arg);
            return __ret;
        }

        public static uint ATSwapInt32HostToBig(uint arg)
        {
            var __ret = __Internal.ATSwapInt32HostToBig(arg);
            return __ret;
        }

        public static ulong ATSwapInt64HostToBig(ulong arg)
        {
            var __ret = __Internal.ATSwapInt64HostToBig(arg);
            return __ret;
        }

        public static ushort ATSwapInt16LittleToHost(ushort arg)
        {
            var __ret = __Internal.ATSwapInt16LittleToHost(arg);
            return __ret;
        }

        public static uint ATSwapInt32LittleToHost(uint arg)
        {
            var __ret = __Internal.ATSwapInt32LittleToHost(arg);
            return __ret;
        }

        public static ulong ATSwapInt64LittleToHost(ulong arg)
        {
            var __ret = __Internal.ATSwapInt64LittleToHost(arg);
            return __ret;
        }

        public static ushort ATSwapInt16HostToLittle(ushort arg)
        {
            var __ret = __Internal.ATSwapInt16HostToLittle(arg);
            return __ret;
        }

        public static uint ATSwapInt32HostToLittle(uint arg)
        {
            var __ret = __Internal.ATSwapInt32HostToLittle(arg);
            return __ret;
        }

        public static ulong ATSwapInt64HostToLittle(ulong arg)
        {
            var __ret = __Internal.ATSwapInt64HostToLittle(arg);
            return __ret;
        }

        public static global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe ATConvertFloatHostToSwapped(float arg)
        {
            var __ret = __Internal.ATConvertFloatHostToSwapped(arg);
            return global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe.__CreateInstance(__ret);
        }

        public static float ATConvertFloatSwappedToHost(global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe arg)
        {
            if (ReferenceEquals(arg, null))
                throw new global::System.ArgumentNullException("arg", "Cannot be null because it is passed by value.");
            var __arg0 = arg.__Instance;
            var __ret = __Internal.ATConvertFloatSwappedToHost(*(global::AirTurnManager.Api.Helpers.ATSwappedFloat32Unsafe.__Internal*)__arg0);
            return __ret;
        }

        public static global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe ATConvertDoubleHostToSwapped(double arg)
        {
            var __ret = __Internal.ATConvertDoubleHostToSwapped(arg);
            return global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe.__CreateInstance(__ret);
        }

        public static double ATConvertDoubleSwappedToHost(global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe arg)
        {
            if (ReferenceEquals(arg, null))
                throw new global::System.ArgumentNullException("arg", "Cannot be null because it is passed by value.");
            var __arg0 = arg.__Instance;
            var __ret = __Internal.ATConvertDoubleSwappedToHost(*(global::AirTurnManager.Api.Helpers.ATSwappedFloat64Unsafe.__Internal*)__arg0);
            return __ret;
        }

        public static bool ATJSONParseBool(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, ref bool val)
        {
            var __arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token.__Instance;
            fixed (bool* __val2 = &val)
            {
                var __arg2 = __val2;
                var __ret = __Internal.ATJSONParseBool(json, __arg1, __arg2);
                return __ret;
            }
        }

        public static bool ATJSONStringEquals(string json, global::AirTurnManager.Api.Foundation.Jsmntok tok, string s)
        {
            var __arg1 = ReferenceEquals(tok, null) ? global::System.IntPtr.Zero : tok.__Instance;
            var __ret = __Internal.ATJSONStringEquals(json, __arg1, s);
            return __ret;
        }

        public static bool ATJSONParseUInt8(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, byte* val)
        {
            var __arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token.__Instance;
            var __ret = __Internal.ATJSONParseUInt8(json, __arg1, val);
            return __ret;
        }

        public static bool ATJSONParseUInt16(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, ref ushort val)
        {
            var __arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token.__Instance;
            fixed (ushort* __val2 = &val)
            {
                var __arg2 = __val2;
                var __ret = __Internal.ATJSONParseUInt16(json, __arg1, __arg2);
                return __ret;
            }
        }

        public static bool ATJSONParseInt8(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, sbyte* val)
        {
            var __arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token.__Instance;
            var __ret = __Internal.ATJSONParseInt8(json, __arg1, val);
            return __ret;
        }

        public static bool ATJSONParseInt16(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, ref short val)
        {
            var __arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token.__Instance;
            fixed (short* __val2 = &val)
            {
                var __arg2 = __val2;
                var __ret = __Internal.ATJSONParseInt16(json, __arg1, __arg2);
                return __ret;
            }
        }

        public static bool ATJSONParseLong(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, ref long val)
        {
            var __arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token.__Instance;
            fixed (long* __val2 = &val)
            {
                var __arg2 = __val2;
                var __ret = __Internal.ATJSONParseLong(json, __arg1, __arg2);
                return __ret;
            }
        }

        public static bool ATJSONParseHexBytes(string json, global::AirTurnManager.Api.Foundation.Jsmntok token, byte* bytes, ulong maxSize, ref ulong parsedBytesLength)
        {
            var __arg1 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token.__Instance;
            fixed (ulong* __parsedBytesLength4 = &parsedBytesLength)
            {
                var __arg4 = __parsedBytesLength4;
                var __ret = __Internal.ATJSONParseHexBytes(json, __arg1, bytes, maxSize, __arg4);
                return __ret;
            }
        }

        public static int ATJSONNumTokensInValue(global::AirTurnManager.Api.Foundation.Jsmntok token)
        {
            var __arg0 = ReferenceEquals(token, null) ? global::System.IntPtr.Zero : token.__Instance;
            var __ret = __Internal.ATJSONNumTokensInValue(__arg0);
            return __ret;
        }
    }
}
