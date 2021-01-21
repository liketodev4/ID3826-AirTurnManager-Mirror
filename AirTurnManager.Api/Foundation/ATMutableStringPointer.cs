using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    public unsafe partial class ATMutableStringPointer : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr @string;

            [FieldOffset(8)]
            internal ulong length;

            [FieldOffset(16)]
            internal ulong capacity;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATMutableStringPointer@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATMutableStringPointerAddStringWithFormat")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATMutableStringPointerAddStringWithFormat(global::System.IntPtr @string, [MarshalAs(UnmanagedType.LPUTF8Str)] string format);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATMutableStringPointer> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATMutableStringPointer>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATMutableStringPointer __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATMutableStringPointer(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATMutableStringPointer __CreateInstance(global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATMutableStringPointer(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATMutableStringPointer(global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATMutableStringPointer(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATMutableStringPointer()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATMutableStringPointer(global::AirTurnManager.Api.Foundation.ATMutableStringPointer _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATMutableStringPointer __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public static bool ATMutableStringPointerAddStringWithFormat(global::AirTurnManager.Api.Foundation.ATMutableStringPointer @string, string format)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATMutableStringPointerAddStringWithFormat(__arg0, format);
            return __ret;
        }

        public sbyte* String
        {
            get
            {
                return (sbyte*)((global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal*)__Instance)->@string;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal*)__Instance)->@string = (global::System.IntPtr)value;
            }
        }

        public ulong Length
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal*)__Instance)->length;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal*)__Instance)->length = value;
            }
        }

        public ulong Capacity
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATMutableStringPointer.__Internal*)__Instance)->capacity;
            }
        }
    }
}
