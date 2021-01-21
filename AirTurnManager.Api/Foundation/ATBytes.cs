using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    /// <summary>A constant data struct without the overhead of ATData</summary>
    public unsafe partial class ATBytesUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr bytes;

            [FieldOffset(8)]
            internal ulong length;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATBytes@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBytesDescription")]
            internal static extern global::System.IntPtr ATBytesDescription(global::System.IntPtr data, sbyte* buffer, ulong bufferCapacity);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATBytesUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATBytesUnsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATBytesUnsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATBytesUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATBytesUnsafe __CreateInstance(global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATBytesUnsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATBytesUnsafe(global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATBytesUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATBytesUnsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATBytesUnsafe(global::AirTurnManager.Api.Foundation.ATBytesUnsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATBytesUnsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public static string ATBytesDescription(global::AirTurnManager.Api.Foundation.ATBytesUnsafe data, sbyte* buffer, ulong bufferCapacity)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var __arg0 = data.__Instance;
            var __ret = __Internal.ATBytesDescription(__arg0, buffer, bufferCapacity);
            if (__ret == global::System.IntPtr.Zero)
                return default(string);
            var __retPtr = (byte*)__ret;
            int __length = 0;
            while (*(__retPtr++) != 0) __length += sizeof(byte);
            return global::System.Text.Encoding.UTF8.GetString((byte*)__ret, __length);
        }

        public byte* Bytes
        {
            get
            {
                return (byte*)((global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal*)__Instance)->bytes;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal*)__Instance)->bytes = (global::System.IntPtr)value;
            }
        }

        public ulong Length
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal*)__Instance)->length;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBytesUnsafe.__Internal*)__Instance)->length = value;
            }
        }
    }
}
