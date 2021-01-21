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
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr @string;

            [FieldOffset(8)]
            internal ulong length;

            [FieldOffset(16)]
            internal ulong capacity;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATMutableStringPointerAddStringWithFormat")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATMutableStringPointerAddStringWithFormat(global::System.IntPtr @string, [MarshalAs(UnmanagedType.LPUTF8Str)] string format);
        }

        public global::System.IntPtr _Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATMutableStringPointer> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATMutableStringPointer>();

        protected bool _ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATMutableStringPointer _CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATMutableStringPointer(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATMutableStringPointer _CreateInstance(global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATMutableStringPointer(native, skipVTables);
        }

        private static void* _CopyValue(global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal));
            *(global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATMutableStringPointer(global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATMutableStringPointer(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new global::System.IntPtr(native);
        }

        public ATMutableStringPointer()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATMutableStringPointer(global::AirTurnManager.Api.Foundation.ATMutableStringPointer _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal*)_Instance) = *((global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATMutableStringPointer _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public static bool ATMutableStringPointerAddStringWithFormat(global::AirTurnManager.Api.Foundation.ATMutableStringPointer @string, string format)
        {
            var _arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string._Instance;
            var _ret = _Internal.ATMutableStringPointerAddStringWithFormat(_arg0, format);
            return _ret;
        }

        public sbyte* String
        {
            get
            {
                return (sbyte*)((global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal*)_Instance)->@string;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal*)_Instance)->@string = (global::System.IntPtr)value;
            }
        }

        public ulong Length
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal*)_Instance)->length;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal*)_Instance)->length = value;
            }
        }

        public ulong Capacity
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATMutableStringPointer._Internal*)_Instance)->capacity;
            }
        }
    }
}
