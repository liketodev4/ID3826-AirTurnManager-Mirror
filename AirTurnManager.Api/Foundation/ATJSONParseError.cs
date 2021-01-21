using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    /// <summary>Represents various JSON parse errors that might occur</summary>
    public enum ATJSONParseErrorCode : byte
    {
        ATJSONParseErrorCodeNone = 0,
        ATJSONParseErrorCodeInternal = 1,
        ATJSONParseErrorCodeInvalidCharacters = 2,
        ATJSONParseErrorCodeIncompleteJSON = 3,
        ATJSONParseErrorCodeKeyNotExpectedType = 4,
        ATJSONParseErrorCodeKeyInvalid = 5,
        ATJSONParseErrorCodeValueNotExpectedType = 6,
        ATJSONParseErrorCodeValueInvalid = 7,
        ATJSONParseErrorCodeExpectedKeyMissing = 8
    }

    /// <summary>The struct containing the last JSON parse error and a key path that the error occurred at</summary>
    public unsafe partial class ATJSONParseErrorUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 101)]
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte keyPath[100];

            [FieldOffset(100)]
            internal global::AirTurnManager.Api.Foundation.ATJSONParseErrorCode code;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseErrorLastReset")]
            internal static extern void ATJSONParseErrorLastReset();

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseErrorLastPushKeyAtFront")]
            internal static extern void ATJSONParseErrorLastPushKeyAtFront([MarshalAs(UnmanagedType.LPUTF8Str)] string key, uint keyLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseErrorLastPushArrayIndexAtFront")]
            internal static extern void ATJSONParseErrorLastPushArrayIndexAtFront(int arrayIndex);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "_ATJSONParseErrorGetLast")]
            internal static extern global::System.IntPtr ATJSONParseErrorGetLast();
        }

        public global::System.IntPtr _Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe>();

        protected bool _ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe _CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe _CreateInstance(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal));
            *(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATJSONParseErrorUnsafe(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATJSONParseErrorUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new global::System.IntPtr(native);
        }

        public ATJSONParseErrorUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATJSONParseErrorUnsafe(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal*)_Instance) = *((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        /// <summary>Reset the last JSON parse error</summary>
        public static void ATJSONParseErrorLastReset()
        {
            _Internal.ATJSONParseErrorLastReset();
        }

        /// <summary>Push a key at the front of the key path</summary>
        /// <param name="key">The key to push</param>
        /// <param name="keyLength">The length of the key</param>
        public static void ATJSONParseErrorLastPushKeyAtFront(string key, uint keyLength)
        {
            _Internal.ATJSONParseErrorLastPushKeyAtFront(key, keyLength);
        }

        /// <summary>Push an array index at the front of the key path</summary>
        /// <param name="arrayIndex">The array index to push</param>
        public static void ATJSONParseErrorLastPushArrayIndexAtFront(int arrayIndex)
        {
            _Internal.ATJSONParseErrorLastPushArrayIndexAtFront(arrayIndex);
        }

        public sbyte[] KeyPath
        {
            get
            {
                sbyte[] _value = null;
                if (((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal*)_Instance)->keyPath != null)
                {
                    _value = new sbyte[100];
                    for (int i = 0; i < 100; i++)
                        _value[i] = ((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal*)_Instance)->keyPath[i];
                }
                return _value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 100; i++)
                        ((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal*)_Instance)->keyPath[i] = value[i];
                }
            }
        }

        public global::AirTurnManager.Api.Foundation.ATJSONParseErrorCode Code
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal*)_Instance)->code;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._Internal*)_Instance)->code = value;
            }
        }

        /// <summary>Get the last JSON parse error. You should instead use `ATJSONLastParseError` to refer to the parse error</summary>
        /// <returns>The last JSON parse error that occurred on the current thread</returns>
        public static global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe ATJSONParseErrorGetLast
        {
            get
            {
                var _ret = _Internal.ATJSONParseErrorGetLast();
                global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe _result0;
                if (_ret == IntPtr.Zero) _result0 = null;
                else if (global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.NativeToManagedMap.ContainsKey(_ret))
                    _result0 = (global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe)global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.NativeToManagedMap[_ret];
                else _result0 = global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe._CreateInstance(_ret);
                return _result0;
            }
        }
    }
}
