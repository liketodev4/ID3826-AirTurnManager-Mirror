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
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal IntPtr domain;

            [FieldOffset(8)]
            internal int code;
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATErrorUnsafe> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATErrorUnsafe>();

        protected bool _ownsNativeInstance;

        internal static Foundation.ATErrorUnsafe _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Foundation.ATErrorUnsafe(native.ToPointer(), skipVTables);
        }

        internal static Foundation.ATErrorUnsafe _CreateInstance(Foundation.ATErrorUnsafe._Internal native, bool skipVTables = false)
        {
            return new Foundation.ATErrorUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(Foundation.ATErrorUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Foundation.ATErrorUnsafe._Internal));
            *(Foundation.ATErrorUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATErrorUnsafe(Foundation.ATErrorUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATErrorUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATErrorUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATErrorUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATErrorUnsafe(Foundation.ATErrorUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATErrorUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((Foundation.ATErrorUnsafe._Internal*)_Instance) = *((Foundation.ATErrorUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            Foundation.ATErrorUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public string Domain
        {
            get
            {
                if (((Foundation.ATErrorUnsafe._Internal*)_Instance)->domain == IntPtr.Zero)
                    return default(string);
                var _retPtr = (byte*)((Foundation.ATErrorUnsafe._Internal*)_Instance)->domain;
                int _length = 0;
                while (*(_retPtr++) != 0) _length += sizeof(byte);
                return Text.Encoding.UTF8.GetString((byte*)((Foundation.ATErrorUnsafe._Internal*)_Instance)->domain, _length);
            }

            set
            {
                byte[] _bytes0 = Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* _bytePtr0 = _bytes0)
                {
                    ((Foundation.ATErrorUnsafe._Internal*)_Instance)->domain = (IntPtr)new IntPtr(_bytePtr0);
                }
            }
        }

        public int Code
        {
            get
            {
                return ((Foundation.ATErrorUnsafe._Internal*)_Instance)->code;
            }

            set
            {
                ((Foundation.ATErrorUnsafe._Internal*)_Instance)->code = value;
            }
        }
    }
}
