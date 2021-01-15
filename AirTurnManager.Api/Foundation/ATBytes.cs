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
    public unsafe partial class ATBytes : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr bytes;

            [FieldOffset(8)]
            internal ulong length;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATBytes@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBytesDescription")]
            internal static extern global::System.IntPtr ATBytesDescription(global::System.IntPtr data, sbyte* buffer, ulong bufferCapacity);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATBytes> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATBytes>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATBytes __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATBytes(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATBytes __CreateInstance(global::AirTurnManager.Api.Foundation.ATBytes.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATBytes(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATBytes.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBytes.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATBytes.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATBytes(global::AirTurnManager.Api.Foundation.ATBytes.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATBytes(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATBytes()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBytes.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATBytes(global::AirTurnManager.Api.Foundation.ATBytes _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBytes.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATBytes.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATBytes.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATBytes __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public static string ATBytesDescription(global::AirTurnManager.Api.Foundation.ATBytes data, sbyte* buffer, ulong bufferCapacity)
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
                return ((global::AirTurnManager.Api.Foundation.ATBytes.__Internal*)__Instance)->bytes;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBytes.__Internal*)__Instance)->bytes = (global::System.IntPtr)value;
            }
        }

        public ulong Length
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBytes.__Internal*)__Instance)->length;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBytes.__Internal*)__Instance)->length = value;
            }
        }
    }
}
