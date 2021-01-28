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
        public partial struct _Internal
        {
            // PRIVATE - DO NOT USE
            // The super-struct
            [FieldOffset(0)]
            internal Foundation.ATBaseUnsafe._Internal _base;

            // A pointer to all tokens
            [FieldOffset(8)]
            internal IntPtr _tokens;

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
            internal IntPtr _string;

            // PUBLIC
            // The parent element type
            [FieldOffset(160)]
            internal Foundation.ATJSONParserParentType parentType;

            // The number of elements in the parent
            [FieldOffset(164)]
            internal uint parentElementCount;

            // The index of the current element in its parent
            [FieldOffset(168)]
            internal uint indexInParent;

            // The current object key, if in an object (otherwise `NULL`)
            [FieldOffset(176)]
            internal IntPtr objectKey;

            // The current object key length
            [FieldOffset(184)]
            internal ulong objectKeyLength;

            // The current element value type
            [FieldOffset(192)]
            internal Foundation.ATJSONParserElementType valueElementType;

            // The current element value
            [FieldOffset(200)]
            internal IntPtr value;

            // The current element value length
            [FieldOffset(208)]
            internal ulong valueLength;

            // The current element value element count (if array or object type)
            [FieldOffset(216)]
            internal uint valueElementCount;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserNew")]
            internal static extern IntPtr ATJSONParserNew(IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserInitWithString")]
            internal static extern IntPtr ATJSONParserInitWithString(IntPtr parser, [MarshalAs(UnmanagedType.LPUTF8Str)] string jsonString, ulong jsonStringLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserKeyEquals")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserKeyEquals(IntPtr parser, [MarshalAs(UnmanagedType.LPUTF8Str)] string key);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserPushKeysToError")]
            internal static extern void ATJSONParserPushKeysToError(IntPtr parser);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserNextElement")]
            internal static extern void ATJSONParserNextElement(IntPtr parser);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserEnterObjectOrArray")]
            internal static extern void ATJSONParserEnterObjectOrArray(IntPtr parser);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGoToObjectOrArrayEnd")]
            internal static extern void ATJSONParserGoToObjectOrArrayEnd(IntPtr parser);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserLockLevel")]
            internal static extern uint ATJSONParserLockLevel(IntPtr parser);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserUnlockLevel")]
            internal static extern void ATJSONParserUnlockLevel(IntPtr parser, uint levelLock);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserUnlockLevelAndMoveToEnd")]
            internal static extern void ATJSONParserUnlockLevelAndMoveToEnd(IntPtr parser, uint levelLock);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetBoolValue")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetBoolValue(IntPtr parser, bool* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetUInt8Value")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetUInt8Value(IntPtr parser, byte* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetUInt16Value")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetUInt16Value(IntPtr parser, ushort* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetInt8Value")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetInt8Value(IntPtr parser, sbyte* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetInt16Value")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetInt16Value(IntPtr parser, short* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetLongValue")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetLongValue(IntPtr parser, long* val);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATJSONParserGetHexBytesValue")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATJSONParserGetHexBytesValue(IntPtr parser, byte* bytes, ulong maxSize, ulong* parsedBytesLength);
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATJSONParserUnsafe> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATJSONParserUnsafe>();

        protected bool _ownsNativeInstance;

        internal static Foundation.ATJSONParserUnsafe _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Foundation.ATJSONParserUnsafe(native.ToPointer(), skipVTables);
        }

        internal static Foundation.ATJSONParserUnsafe _CreateInstance(Foundation.ATJSONParserUnsafe._Internal native, bool skipVTables = false)
        {
            return new Foundation.ATJSONParserUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(Foundation.ATJSONParserUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Foundation.ATJSONParserUnsafe._Internal));
            *(Foundation.ATJSONParserUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATJSONParserUnsafe(Foundation.ATJSONParserUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATJSONParserUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATJSONParserUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATJSONParserUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATJSONParserUnsafe(Foundation.ATJSONParserUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATJSONParserUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((Foundation.ATJSONParserUnsafe._Internal*)_Instance) = *((Foundation.ATJSONParserUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            Foundation.ATJSONParserUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        /// <summary>Create a new JSON parser</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        public static Foundation.ATJSONParserUnsafe ATJSONParserNew(Foundation.ATJSONParserUnsafe optionalStorage)
        {
            var _arg0 = ReferenceEquals(optionalStorage, null) ? IntPtr.Zero : optionalStorage._Instance;
            var _ret = _Internal.ATJSONParserNew(_arg0);
            Foundation.ATJSONParserUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATJSONParserUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATJSONParserUnsafe)Foundation.ATJSONParserUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATJSONParserUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Initialize a JSON parser object</summary>
        /// <param name="parser">The object to initialize. Can be `NULL` so the result from `ATJSONParserNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="jsonString">The JSON string to parse</param>
        /// <param name="jsonStringLength">The length of the JSON string</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static Foundation.ATJSONParserUnsafe ATJSONParserInitWithString(Foundation.ATJSONParserUnsafe parser, string jsonString, ulong jsonStringLength)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            var _ret = _Internal.ATJSONParserInitWithString(_arg0, jsonString, jsonStringLength);
            Foundation.ATJSONParserUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATJSONParserUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATJSONParserUnsafe)Foundation.ATJSONParserUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATJSONParserUnsafe._CreateInstance(_ret);
            return _result0;
        }

        /// <summary>Determine if the current object key equals a given string</summary>
        /// <param name="parser">The JSON parser</param>
        /// <param name="key">The key to compare with</param>
        /// <returns>`true` if the key is equal</returns>
        public static bool ATJSONParserKeyEquals(Foundation.ATJSONParserUnsafe parser, string key)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            var _ret = _Internal.ATJSONParserKeyEquals(_arg0, key);
            return _ret;
        }

        /// <summary>Push the current key path to the last json parse error. Call if an error has occurred parsing.</summary>
        /// <param name="parser">The parser</param>
        public static void ATJSONParserPushKeysToError(Foundation.ATJSONParserUnsafe parser)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            _Internal.ATJSONParserPushKeysToError(_arg0);
        }

        /// <summary>Move the parser to the next element</summary>
        /// <param name="parser">The parser</param>
        public static void ATJSONParserNextElement(Foundation.ATJSONParserUnsafe parser)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            _Internal.ATJSONParserNextElement(_arg0);
        }

        /// <summary>Enter an object or array. Call when the current value is an object or array which you want to iterate through</summary>
        /// <param name="parser">The parser</param>
        public static void ATJSONParserEnterObjectOrArray(Foundation.ATJSONParserUnsafe parser)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            _Internal.ATJSONParserEnterObjectOrArray(_arg0);
        }

        /// <summary>Go to the end of the current object or array. The next call to `ATJSONParserNextElement` will move to the next element in the parent</summary>
        /// <param name="parser">The parser</param>
        public static void ATJSONParserGoToObjectOrArrayEnd(Foundation.ATJSONParserUnsafe parser)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            _Internal.ATJSONParserGoToObjectOrArrayEnd(_arg0);
        }

        /// <summary>Lock the current level. Use when passing the parser to code which should only have access to the current level, not higher levels. Will prevent progression beyond the end of the current parent</summary>
        /// <param name="parser">The parser</param>
        /// <returns>An integer required to unlock the level</returns>
        public static uint ATJSONParserLockLevel(Foundation.ATJSONParserUnsafe parser)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            var _ret = _Internal.ATJSONParserLockLevel(_arg0);
            return _ret;
        }

        /// <summary>Unlock the current level to allow progression beyond the current parent</summary>
        /// <param name="parser">The parser</param>
        /// <param name="levelLock">The level lock returned from `ATJSONParserLockLevel`</param>
        public static void ATJSONParserUnlockLevel(Foundation.ATJSONParserUnsafe parser, uint levelLock)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            _Internal.ATJSONParserUnlockLevel(_arg0, levelLock);
        }

        /// <summary>Unlock the current level to allow progression beyond the current parent and move the parser to the end of the previously locked level. Useful for ensuring that if child code has not traversed all the elements in the locked level, the parent code is not affected</summary>
        /// <param name="parser">The parser</param>
        /// <param name="levelLock">The level lock returned from `ATJSONParserLockLevel`</param>
        public static void ATJSONParserUnlockLevelAndMoveToEnd(Foundation.ATJSONParserUnsafe parser, uint levelLock)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            _Internal.ATJSONParserUnlockLevelAndMoveToEnd(_arg0, levelLock);
        }

        /// <summary>Get the bool value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into bool</returns>
        public static bool ATJSONParserGetBoolValue(Foundation.ATJSONParserUnsafe parser, ref bool val)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            fixed (bool* _val1 = &val)
            {
                var _arg1 = _val1;
                var _ret = _Internal.ATJSONParserGetBoolValue(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get the uint8_t value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into uint8_t</returns>
        public static bool ATJSONParserGetUInt8Value(Foundation.ATJSONParserUnsafe parser, byte* val)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            var _ret = _Internal.ATJSONParserGetUInt8Value(_arg0, val);
            return _ret;
        }

        /// <summary>Get the uint16_t value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into uint16_t</returns>
        public static bool ATJSONParserGetUInt16Value(Foundation.ATJSONParserUnsafe parser, ref ushort val)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            fixed (ushort* _val1 = &val)
            {
                var _arg1 = _val1;
                var _ret = _Internal.ATJSONParserGetUInt16Value(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get the int8_t value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into int8_t</returns>
        public static bool ATJSONParserGetInt8Value(Foundation.ATJSONParserUnsafe parser, sbyte* val)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            var _ret = _Internal.ATJSONParserGetInt8Value(_arg0, val);
            return _ret;
        }

        /// <summary>Get the int16_t value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into int16_t</returns>
        public static bool ATJSONParserGetInt16Value(Foundation.ATJSONParserUnsafe parser, ref short val)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            fixed (short* _val1 = &val)
            {
                var _arg1 = _val1;
                var _ret = _Internal.ATJSONParserGetInt16Value(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get the long value from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="val">The value will be written to this pointer</param>
        /// <returns>`true` if the current element value could be successfully parsed into long</returns>
        public static bool ATJSONParserGetLongValue(Foundation.ATJSONParserUnsafe parser, ref long val)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            fixed (long* _val1 = &val)
            {
                var _arg1 = _val1;
                var _ret = _Internal.ATJSONParserGetLongValue(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get bytes from the current element value</summary>
        /// <param name="parser">The parser</param>
        /// <param name="bytes">A pointer to storage</param>
        /// <param name="maxSize">The maximum size that can be stored in bytes</param>
        /// <param name="parsedBytesLength">On return, the number of bytes copied into `bytes` will be stored in this</param>
        /// <returns>`true` if the current element value could be successfully parsed into the bytes buffer</returns>
        public static bool ATJSONParserGetHexBytesValue(Foundation.ATJSONParserUnsafe parser, byte* bytes, ulong maxSize, ref ulong parsedBytesLength)
        {
            var _arg0 = ReferenceEquals(parser, null) ? IntPtr.Zero : parser._Instance;
            fixed (ulong* _parsedBytesLength3 = &parsedBytesLength)
            {
                var _arg3 = _parsedBytesLength3;
                var _ret = _Internal.ATJSONParserGetHexBytesValue(_arg0, bytes, maxSize, _arg3);
                return _ret;
            }
        }

        public Foundation.ATBaseUnsafe Base
        {
            get
            {
                return Foundation.ATBaseUnsafe._CreateInstance(new IntPtr(&((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_base));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_base = *(Foundation.ATBaseUnsafe._Internal*)value._Instance;
            }
        }

        public IntPtr Tokens
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_tokens;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_tokens = (IntPtr)value;
            }
        }

        public uint NumTokens
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_numTokens;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_numTokens = value;
            }
        }

        public uint TokenOffset
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_tokenOffset;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_tokenOffset = value;
            }
        }

        public uint Level
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_level;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_level = value;
            }
        }

        public uint[] LevelParentOffsets
        {
            get
            {
                uint[] _value = null;
                if (((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelParentOffsets != null)
                {
                    _value = new uint[10];
                    for (int i = 0; i < 10; i++)
                        _value[i] = ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelParentOffsets[i];
                }
                return _value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelParentOffsets[i] = value[i];
                }
            }
        }

        public uint[] LevelIndexes
        {
            get
            {
                uint[] _value = null;
                if (((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelIndexes != null)
                {
                    _value = new uint[10];
                    for (int i = 0; i < 10; i++)
                        _value[i] = ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelIndexes[i];
                }
                return _value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelIndexes[i] = value[i];
                }
            }
        }

        public uint[] LevelLock
        {
            get
            {
                uint[] _value = null;
                if (((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelLock != null)
                {
                    _value = new uint[10];
                    for (int i = 0; i < 10; i++)
                        _value[i] = ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelLock[i];
                }
                return _value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 10; i++)
                        ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelLock[i] = value[i];
                }
            }
        }

        public uint LevelLockIndex
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelLockIndex;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_levelLockIndex = value;
            }
        }

        public string String
        {
            get
            {
                if (((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_string == IntPtr.Zero)
                    return default(string);
                var _retPtr = (byte*)((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_string;
                int _length = 0;
                while (*(_retPtr++) != 0) _length += sizeof(byte);
                return Text.Encoding.UTF8.GetString((byte*)((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_string, _length);
            }

            set
            {
                byte[] _bytes0 = Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* _bytePtr0 = _bytes0)
                {
                    ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->_string = (IntPtr)new IntPtr(_bytePtr0);
                }
            }
        }

        public Foundation.ATJSONParserParentType ParentType
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->parentType;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->parentType = value;
            }
        }

        public uint ParentElementCount
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->parentElementCount;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->parentElementCount = value;
            }
        }

        public uint IndexInParent
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->indexInParent;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->indexInParent = value;
            }
        }

        public string ObjectKey
        {
            get
            {
                if (((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->objectKey == IntPtr.Zero)
                    return default(string);
                var _retPtr = (byte*)((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->objectKey;
                int _length = 0;
                while (*(_retPtr++) != 0) _length += sizeof(byte);
                return Text.Encoding.UTF8.GetString((byte*)((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->objectKey, _length);
            }

            set
            {
                byte[] _bytes0 = Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* _bytePtr0 = _bytes0)
                {
                    ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->objectKey = (IntPtr)new IntPtr(_bytePtr0);
                }
            }
        }

        public ulong ObjectKeyLength
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->objectKeyLength;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->objectKeyLength = value;
            }
        }

        public Foundation.ATJSONParserElementType ValueElementType
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->valueElementType;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->valueElementType = value;
            }
        }

        public string Value
        {
            get
            {
                if (((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->value == IntPtr.Zero)
                    return default(string);
                var _retPtr = (byte*)((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->value;
                int _length = 0;
                while (*(_retPtr++) != 0) _length += sizeof(byte);
                return Text.Encoding.UTF8.GetString((byte*)((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->value, _length);
            }

            set
            {
                byte[] _bytes0 = Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* _bytePtr0 = _bytes0)
                {
                    ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->value = (IntPtr)new IntPtr(_bytePtr0);
                }
            }
        }

        public ulong ValueLength
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->valueLength;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->valueLength = value;
            }
        }

        public uint ValueElementCount
        {
            get
            {
                return ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->valueElementCount;
            }

            set
            {
                ((Foundation.ATJSONParserUnsafe._Internal*)_Instance)->valueElementCount = value;
            }
        }
    }
}
