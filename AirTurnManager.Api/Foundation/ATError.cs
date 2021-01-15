using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    public unsafe partial class ATErrorUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr domain;

            [FieldOffset(8)]
            internal int code;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATError@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATErrorUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATErrorUnsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATErrorUnsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATErrorUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATErrorUnsafe __CreateInstance(global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATErrorUnsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATErrorUnsafe(global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATErrorUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATErrorUnsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATErrorUnsafe(global::AirTurnManager.Api.Foundation.ATErrorUnsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATErrorUnsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public string Domain
        {
            get
            {
                if (((global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal*)__Instance)->domain == global::System.IntPtr.Zero)
                    return default(string);
                var __retPtr = (byte*)((global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal*)__Instance)->domain;
                int __length = 0;
                while (*(__retPtr++) != 0) __length += sizeof(byte);
                return global::System.Text.Encoding.UTF8.GetString((byte*)((global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal*)__Instance)->domain, __length);
            }

            set
            {
                byte[] __bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* __bytePtr0 = __bytes0)
                {
                    ((global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal*)__Instance)->domain = (global::System.IntPtr)new global::System.IntPtr(__bytePtr0);
                }
            }
        }

        public int Code
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal*)__Instance)->code;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATErrorUnsafe.__Internal*)__Instance)->code = value;
            }
        }
    }
}
