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
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte keyPath[100];

            [FieldOffset(100)]
            internal global::AirTurnManager.Api.Foundation.ATJSONParseErrorCode code;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATJSONParseError@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseErrorLastReset")]
            internal static extern void ATJSONParseErrorLastReset();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseErrorLastPushKeyAtFront")]
            internal static extern void ATJSONParseErrorLastPushKeyAtFront([MarshalAs(UnmanagedType.LPUTF8Str)] string key, uint keyLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATJSONParseErrorLastPushArrayIndexAtFront")]
            internal static extern void ATJSONParseErrorLastPushArrayIndexAtFront(int arrayIndex);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "_ATJSONParseErrorGetLast")]
            internal static extern global::System.IntPtr ATJSONParseErrorGetLast();
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe __CreateInstance(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATJSONParseErrorUnsafe(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATJSONParseErrorUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATJSONParseErrorUnsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATJSONParseErrorUnsafe(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Reset the last JSON parse error</summary>
        public static void ATJSONParseErrorLastReset()
        {
            __Internal.ATJSONParseErrorLastReset();
        }

        /// <summary>Push a key at the front of the key path</summary>
        /// <param name="key">The key to push</param>
        /// <param name="keyLength">The length of the key</param>
        public static void ATJSONParseErrorLastPushKeyAtFront(string key, uint keyLength)
        {
            __Internal.ATJSONParseErrorLastPushKeyAtFront(key, keyLength);
        }

        /// <summary>Push an array index at the front of the key path</summary>
        /// <param name="arrayIndex">The array index to push</param>
        public static void ATJSONParseErrorLastPushArrayIndexAtFront(int arrayIndex)
        {
            __Internal.ATJSONParseErrorLastPushArrayIndexAtFront(arrayIndex);
        }

        public sbyte[] KeyPath
        {
            get
            {
                sbyte[] __value = null;
                if (((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal*)__Instance)->keyPath != null)
                {
                    __value = new sbyte[100];
                    for (int i = 0; i < 100; i++)
                        __value[i] = ((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal*)__Instance)->keyPath[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 100; i++)
                        ((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal*)__Instance)->keyPath[i] = value[i];
                }
            }
        }

        public global::AirTurnManager.Api.Foundation.ATJSONParseErrorCode Code
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal*)__Instance)->code;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__Internal*)__Instance)->code = value;
            }
        }

        /// <summary>Get the last JSON parse error. You should instead use `ATJSONLastParseError` to refer to the parse error</summary>
        /// <returns>The last JSON parse error that occurred on the current thread</returns>
        public static global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe ATJSONParseErrorGetLast
        {
            get
            {
                var __ret = __Internal.ATJSONParseErrorGetLast();
                global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe)global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.NativeToManagedMap[__ret];
                else __result0 = global::AirTurnManager.Api.Foundation.ATJSONParseErrorUnsafe.__CreateInstance(__ret);
                return __result0;
            }
        }
    }
}
