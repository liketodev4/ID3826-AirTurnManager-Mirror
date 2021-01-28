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
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal IntPtr @string;

            [FieldOffset(8)]
            internal ulong length;
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATStringPointerUnsafe> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATStringPointerUnsafe>();

        protected bool _ownsNativeInstance;

        internal static Foundation.ATStringPointerUnsafe _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Foundation.ATStringPointerUnsafe(native.ToPointer(), skipVTables);
        }

        internal static Foundation.ATStringPointerUnsafe _CreateInstance(Foundation.ATStringPointerUnsafe._Internal native, bool skipVTables = false)
        {
            return new Foundation.ATStringPointerUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(Foundation.ATStringPointerUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Foundation.ATStringPointerUnsafe._Internal));
            *(Foundation.ATStringPointerUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATStringPointerUnsafe(Foundation.ATStringPointerUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATStringPointerUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATStringPointerUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATStringPointerUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATStringPointerUnsafe(Foundation.ATStringPointerUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATStringPointerUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((Foundation.ATStringPointerUnsafe._Internal*)_Instance) = *((Foundation.ATStringPointerUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            Foundation.ATStringPointerUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public string String
        {
            get
            {
                if (((Foundation.ATStringPointerUnsafe._Internal*)_Instance)->@string == IntPtr.Zero)
                    return default(string);
                var _retPtr = (byte*)((Foundation.ATStringPointerUnsafe._Internal*)_Instance)->@string;
                int _length = 0;
                while (*(_retPtr++) != 0) _length += sizeof(byte);
                return Text.Encoding.UTF8.GetString((byte*)((Foundation.ATStringPointerUnsafe._Internal*)_Instance)->@string, _length);
            }

            set
            {
                byte[] _bytes0 = Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* _bytePtr0 = _bytes0)
                {
                    ((Foundation.ATStringPointerUnsafe._Internal*)_Instance)->@string = (IntPtr)new IntPtr(_bytePtr0);
                }
            }
        }

        public ulong Length
        {
            get
            {
                return ((Foundation.ATStringPointerUnsafe._Internal*)_Instance)->length;
            }

            set
            {
                ((Foundation.ATStringPointerUnsafe._Internal*)_Instance)->length = value;
            }
        }
    }
}
