using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    public unsafe partial class ATStringPointerUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr @string;

            [FieldOffset(8)]
            internal ulong length;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATStringPointer@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe __CreateInstance(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATStringPointerUnsafe(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATStringPointerUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATStringPointerUnsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATStringPointerUnsafe(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public string String
        {
            get
            {
                if (((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal*)__Instance)->@string == global::System.IntPtr.Zero)
                    return default(string);
                var __retPtr = (byte*)((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal*)__Instance)->@string;
                int __length = 0;
                while (*(__retPtr++) != 0) __length += sizeof(byte);
                return global::System.Text.Encoding.UTF8.GetString((byte*)((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal*)__Instance)->@string, __length);
            }

            set
            {
                byte[] __bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* __bytePtr0 = __bytes0)
                {
                    ((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal*)__Instance)->@string = (global::System.IntPtr)new global::System.IntPtr(__bytePtr0);
                }
            }
        }

        public ulong Length
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal*)__Instance)->length;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe.__Internal*)__Instance)->length = value;
            }
        }
    }
}
