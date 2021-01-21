using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    /// <summary>Represents an element type</summary>
    public enum ATJSONParserElementType : byte
    {
        ATJSONParserElementTypePrimitive = 0,
        ATJSONParserElementTypeString = 1,
        ATJSONParserElementTypeObject = 2,
        ATJSONParserElementTypeArray = 3,
        ATJSONParserElementTypeEnd = 4
    }

    /// <summary>Represents a parent element type</summary>
    public enum ATJSONParserParentType : byte
    {
        ATJSONParserParentTypeNone = 0,
        ATJSONParserParentTypeObject = 1,
        ATJSONParserParentTypeArray = 2
    }

    /// <summary>The struct for ATJSONParser objects</summary>
    public unsafe partial class ATJSONParserUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 224)]
        public partial struct __Internal
        {
            // PRIVATE - DO NOT USE
            // The super-struct
            [FieldOffset(0)]
            internal global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal _base;

            // A pointer to all tokens
            [FieldOffset(8)]
            internal global::System.IntPtr _tokens;

            // The number of tokens
            [FieldOffset(16)]
            internal uint _numTokens;

            // The current token offset
            [FieldOffset(20)]
            internal uint _tokenOffset;

            // The current array/object depth
            [FieldOffset(24)]
            internal uint _level;

            // The offset for the parents at each level
            [FieldOffset(28)]
            internal fixed uint _levelParentOffsets[10];

            // The index in the parent at each level
            [FieldOffset(68)]
            internal fixed uint _levelIndexes[10];

            // Contains all the active locks (each element indicates the level that is locked)
            [FieldOffset(108)]
            internal fixed uint _levelLock[10];

            // The index in _levelLock currently active
            [FieldOffset(148)]
            internal uint _levelLockIndex;

            // The JSON string
            [FieldOffset(152)]
            internal global::System.IntPtr _string;

            // PUBLIC
            // The parent element type
            [FieldOffset(160)]
            internal global::AirTurnManager.Api.Foundation.ATJSONParserParentType parentType;

            // The number of elements in the parent
            [FieldOffset(164)]
            internal uint parentElementCount;

            // The index of the current element in its parent
            [FieldOffset(168)]
            internal uint indexInParent;

            // The current object key, if in an object (otherwise `NULL`)
            [FieldOffset(176)]
            internal global::System.IntPtr objectKey;

            // The current object key length
            [FieldOffset(184)]
            internal ulong objectKeyLength;

            // The current element value type
            [FieldOffset(192)]
            internal global::AirTurnManager.Api.Foundation.ATJSONParserElementType valueElementType;

            // The current element value
            [FieldOffset(200)]
            internal global::System.IntPtr value;

            // The current element value length
            [FieldOffset(208)]
            internal ulong valueLength;

            // The current element value element count (if array or object type)
            [FieldOffset(216)]
            internal uint valueElementCount;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATJSONParser@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserNew")]
            internal static extern global::System.IntPtr ATJSONParserNew(global::System.IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserInitWithString")]
            internal static extern global::System.IntPtr ATJSONParserInitWithString(global::System.IntPtr parser, [MarshalAs(UnmanagedType.LPUTF8Str)] string jsonString, ulong jsonStringLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserKeyEquals")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserKeyEquals(global::System.IntPtr parser, [MarshalAs(UnmanagedType.LPUTF8Str)] string key);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserPushKeysToError")]
            internal static extern void ATJSONParserPushKeysToError(global::System.IntPtr parser);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserNextElement")]
            internal static extern void ATJSONParserNextElement(global::System.IntPtr parser);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserEnterObjectOrArray")]
            internal static extern void ATJSONParserEnterObjectOrArray(global::System.IntPtr parser);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGoToObjectOrArrayEnd")]
            internal static extern void ATJSONParserGoToObjectOrArrayEnd(global::System.IntPtr parser);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserLockLevel")]
            internal static extern uint ATJSONParserLockLevel(global::System.IntPtr parser);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserUnlockLevel")]
            internal static extern void ATJSONParserUnlockLevel(global::System.IntPtr parser, uint levelLock);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserUnlockLevelAndMoveToEnd")]
            internal static extern void ATJSONParserUnlockLevelAndMoveToEnd(global::System.IntPtr parser, uint levelLock);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetBoolValue")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetBoolValue(global::System.IntPtr parser, bool* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetUInt8Value")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetUInt8Value(global::System.IntPtr parser, byte* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetUInt16Value")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetUInt16Value(global::System.IntPtr parser, ushort* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetInt8Value")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetInt8Value(global::System.IntPtr parser, sbyte* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetInt16Value")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetInt16Value(global::System.IntPtr parser, short* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetLongValue")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetLongValue(global::System.IntPtr parser, long* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetHexBytesValue")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetHexBytesValue(global::System.IntPtr parser, byte* bytes, ulong maxSize, ulong* parsedBytesLength);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe __CreateInstance(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATJSONParserUnsafe(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATJSONParserUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATJSONParserUnsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATJSONParserUnsafe(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Create a new JSON parser</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        public static global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe ATJSONParserNew(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe optionalStorage)
        {
            var __arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage.__Instance;
            var __ret = __Internal.ATJSONParserNew(__arg0);
            global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe)global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a JSON parser object</summary>
        /// <param name="parser">The object to initialize. Can be `NULL` so the result from `ATJSONParserNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="jsonString">The JSON string to parse</param>
        /// <param name="jsonStringLength">The length of the JSON string</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe ATJSONParserInitWithString(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, string jsonString, ulong jsonStringLength)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            var __ret = __Internal.ATJSONParserInitWithString(__arg0, jsonString, jsonStringLength);
            global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe)global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Determine if the current object key equals a given string</summary>
        /// <param name="parser">The JSON parser</param>
        /// <param name="key">The key to compare with</param>
        /// <returns>`true` if the key is equal</returns>
        public static bool ATJSONParserKeyEquals(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, string key)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            var __ret = __Internal.ATJSONParserKeyEquals(__arg0, key);
            return __ret;
        }

        /// <summary>Push the current key path to the last json parse error. Call if an error has occurred parsing.</summary>
        /// <param name="parser">The parser</param>
        public static void ATJSONParserPushKeysToError(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            __Internal.ATJSONParserPushKeysToError(__arg0);
        }

        /// <summary>Move the parser to the next element</summary>
        /// <param name="parser">The parser</param>
        public static void ATJSONParserNextElement(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            __Internal.ATJSONParserNextElement(__arg0);
        }

        /// <summary>Enter an object or array. Call when the current value is an object or array which you want to iterate through</summary>
        /// <param name="parser">The parser</param>
        public static void ATJSONParserEnterObjectOrArray(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            __Internal.ATJSONParserEnterObjectOrArray(__arg0);
        }

        /// <summary>Go to the end of the current object or array. The next call to `ATJSONParserNextElement` will move to the next element in the parent</summary>
        /// <param name="parser">The parser</param>
        public static void ATJSONParserGoToObjectOrArrayEnd(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            __Internal.ATJSONParserGoToObjectOrArrayEnd(__arg0);
        }

        /// <summary>Lock the current level. Use when passing the parser to code which should only have access to the current level, not higher levels. Will prevent progression beyond the end of the current parent</summary>
        /// <param name="parser">The parser</param>
        /// <returns>An integer required to unlock the level</returns>
        public static uint ATJSONParserLockLevel(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            var __ret = __Internal.ATJSONParserLockLevel(__arg0);
            return __ret;
        }

        /// <summary>Unlock the current level to allow progression beyond the current parent</summary>
        /// <param name="parser">The parser</param>
        /// <param name="levelLock">The level lock returned from `ATJSONParserLockLevel`</param>
        public static void ATJSONParserUnlockLevel(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, uint levelLock)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            __Internal.ATJSONParserUnlockLevel(__arg0, levelLock);
        }

        /// <summary>Unlock the current level to allow progression beyond the current parent and move the parser to the end of the previously locked level. Useful for ensuring that if child code has not traversed all the elements in the locked level, the parent code is not affected</summary>
        /// <param name="parser">The parser</param>
        /// <param name="levelLock">The level lock returned from `ATJSONParserLockLevel`</param>
        public static void ATJSONParserUnlockLevelAndMoveToEnd(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, uint levelLock)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            __Internal.ATJSONParserUnlockLevelAndMoveToEnd(__arg0, levelLock);
        }

        /// <summary>Get the bool value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into bool</returns>
        public static bool ATJSONParserGetBoolValue(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, ref bool val)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            fixed (bool* __val1 = &val)
            {
                var __arg1 = __val1;
                var __ret = __Internal.ATJSONParserGetBoolValue(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get the uint8_t value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into uint8_t</returns>
        public static bool ATJSONParserGetUInt8Value(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, byte* val)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            var __ret = __Internal.ATJSONParserGetUInt8Value(__arg0, val);
            return __ret;
        }

        /// <summary>Get the uint16_t value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into uint16_t</returns>
        public static bool ATJSONParserGetUInt16Value(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, ref ushort val)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            fixed (ushort* __val1 = &val)
            {
                var __arg1 = __val1;
                var __ret = __Internal.ATJSONParserGetUInt16Value(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get the int8_t value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into int8_t</returns>
        public static bool ATJSONParserGetInt8Value(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, sbyte* val)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            var __ret = __Internal.ATJSONParserGetInt8Value(__arg0, val);
            return __ret;
        }

        /// <summary>Get the int16_t value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into int16_t</returns>
        public static bool ATJSONParserGetInt16Value(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, ref short val)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            fixed (short* __val1 = &val)
            {
                var __arg1 = __val1;
                var __ret = __Internal.ATJSONParserGetInt16Value(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get the long value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into long</returns>
        public static bool ATJSONParserGetLongValue(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, ref long val)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            fixed (long* __val1 = &val)
            {
                var __arg1 = __val1;
                var __ret = __Internal.ATJSONParserGetLongValue(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get bytes from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="bytes">A pointer to storage</param>
        /// <param name="maxSize">The maximum size that can be stored in bytes</param>
        /// <param name="parsedBytesLength">On return, the number of bytes copied into `bytes` will be stored in this</param>
        /// <returns>`true` if the current element value could be successfully parsed into the bytes buffer</returns>
        public static bool ATJSONParserGetHexBytesValue(global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe parser, byte* bytes, ulong maxSize, ref ulong parsedBytesLength)
        {
            var __arg0 = ReferenceEquals(parser, null) ? global::System.IntPtr.Zero : parser.__Instance;
            fixed (ulong* __parsedBytesLength3 = &parsedBytesLength)
            {
                var __arg3 = __parsedBytesLength3;
                var __ret = __Internal.ATJSONParserGetHexBytesValue(__arg0, bytes, maxSize, __arg3);
                return __ret;
            }
        }

        public global::AirTurnManager.Api.Foundation.ATBaseUnsafe Base
        {
            get
            {
                return global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__CreateInstance(new global::System.IntPtr(&((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_base));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_base = *(global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__Internal*)value.__Instance;
            }
        }

        public global::System.IntPtr Tokens
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_tokens;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_tokens = (global::System.IntPtr)value;
            }
        }

        public uint NumTokens
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_numTokens;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_numTokens = value;
            }
        }

        public uint TokenOffset
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_tokenOffset;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_tokenOffset = value;
            }
        }

        public uint Level
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_level;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_level = value;
            }
        }

        public uint[] LevelParentOffsets
        {
            get
            {
                uint[] __value = null;
                if (((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelParentOffsets != null)
                {
                    __value = new uint[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelParentOffsets[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelParentOffsets[i] = value[i];
                }
            }
        }

        public uint[] LevelIndexes
        {
            get
            {
                uint[] __value = null;
                if (((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelIndexes != null)
                {
                    __value = new uint[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelIndexes[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelIndexes[i] = value[i];
                }
            }
        }

        public uint[] LevelLock
        {
            get
            {
                uint[] __value = null;
                if (((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelLock != null)
                {
                    __value = new uint[10];
                    for (int i = 0; i < 10; i++)
                        __value[i] = ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelLock[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelLock[i] = value[i];
                }
            }
        }

        public uint LevelLockIndex
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelLockIndex;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_levelLockIndex = value;
            }
        }

        public string String
        {
            get
            {
                if (((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_string == global::System.IntPtr.Zero)
                    return default(string);
                var __retPtr = (byte*)((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_string;
                int __length = 0;
                while (*(__retPtr++) != 0) __length += sizeof(byte);
                return global::System.Text.Encoding.UTF8.GetString((byte*)((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_string, __length);
            }

            set
            {
                byte[] __bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* __bytePtr0 = __bytes0)
                {
                    ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->_string = (global::System.IntPtr)new global::System.IntPtr(__bytePtr0);
                }
            }
        }

        public global::AirTurnManager.Api.Foundation.ATJSONParserParentType ParentType
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->parentType;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->parentType = value;
            }
        }

        public uint ParentElementCount
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->parentElementCount;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->parentElementCount = value;
            }
        }

        public uint IndexInParent
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->indexInParent;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->indexInParent = value;
            }
        }

        public string ObjectKey
        {
            get
            {
                if (((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->objectKey == global::System.IntPtr.Zero)
                    return default(string);
                var __retPtr = (byte*)((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->objectKey;
                int __length = 0;
                while (*(__retPtr++) != 0) __length += sizeof(byte);
                return global::System.Text.Encoding.UTF8.GetString((byte*)((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->objectKey, __length);
            }

            set
            {
                byte[] __bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* __bytePtr0 = __bytes0)
                {
                    ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->objectKey = (global::System.IntPtr)new global::System.IntPtr(__bytePtr0);
                }
            }
        }

        public ulong ObjectKeyLength
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->objectKeyLength;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->objectKeyLength = value;
            }
        }

        public global::AirTurnManager.Api.Foundation.ATJSONParserElementType ValueElementType
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->valueElementType;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->valueElementType = value;
            }
        }

        public string Value
        {
            get
            {
                if (((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->value == global::System.IntPtr.Zero)
                    return default(string);
                var __retPtr = (byte*)((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->value;
                int __length = 0;
                while (*(__retPtr++) != 0) __length += sizeof(byte);
                return global::System.Text.Encoding.UTF8.GetString((byte*)((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->value, __length);
            }

            set
            {
                byte[] __bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* __bytePtr0 = __bytes0)
                {
                    ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->value = (global::System.IntPtr)new global::System.IntPtr(__bytePtr0);
                }
            }
        }

        public ulong ValueLength
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->valueLength;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->valueLength = value;
            }
        }

        public uint ValueElementCount
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->valueElementCount;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParserUnsafe.__Internal*)__Instance)->valueElementCount = value;
            }
        }
    }
}
