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
            internal IntPtr @string;

            [FieldOffset(8)]
            internal ulong length;

            [FieldOffset(16)]
            internal ulong capacity;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATMutableStringPointerAddStringWithFormat")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATMutableStringPointerAddStringWithFormat(IntPtr @string, [MarshalAs(UnmanagedType.LPUTF8Str)] string format);
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATMutableStringPointer> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATMutableStringPointer>();

        protected bool _ownsNativeInstance;

        internal static Foundation.ATMutableStringPointer _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Foundation.ATMutableStringPointer(native.ToPointer(), skipVTables);
        }

        internal static Foundation.ATMutableStringPointer _CreateInstance(Foundation.ATMutableStringPointer._Internal native, bool skipVTables = false)
        {
            return new Foundation.ATMutableStringPointer(native, skipVTables);
        }

        private static void* _CopyValue(Foundation.ATMutableStringPointer._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Foundation.ATMutableStringPointer._Internal));
            *(Foundation.ATMutableStringPointer._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATMutableStringPointer(Foundation.ATMutableStringPointer._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATMutableStringPointer(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATMutableStringPointer()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATMutableStringPointer._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATMutableStringPointer(Foundation.ATMutableStringPointer _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATMutableStringPointer._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((Foundation.ATMutableStringPointer._Internal*)_Instance) = *((Foundation.ATMutableStringPointer._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            Foundation.ATMutableStringPointer _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public static bool ATMutableStringPointerAddStringWithFormat(Foundation.ATMutableStringPointer @string, string format)
        {
            var _arg0 = ReferenceEquals(@string, null) ? IntPtr.Zero : @string._Instance;
            var _ret = _Internal.ATMutableStringPointerAddStringWithFormat(_arg0, format);
            return _ret;
        }

        public sbyte* String
        {
            get
            {
                return (sbyte*)((Foundation.ATMutableStringPointer._Internal*)_Instance)->@string;
            }

            set
            {
                ((Foundation.ATMutableStringPointer._Internal*)_Instance)->@string = (IntPtr)value;
            }
        }

        public ulong Length
        {
            get
            {
                return ((Foundation.ATMutableStringPointer._Internal*)_Instance)->length;
            }

            set
            {
                ((Foundation.ATMutableStringPointer._Internal*)_Instance)->length = value;
            }
        }

        public ulong Capacity
        {
            get
            {
                return ((Foundation.ATMutableStringPointer._Internal*)_Instance)->capacity;
            }
        }
    }
}
