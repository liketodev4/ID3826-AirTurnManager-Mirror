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
            internal global::System.IntPtr @string;

            [FieldOffset(8)]
            internal ulong length;
        }

        public global::System.IntPtr _Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe>();

        protected bool _ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe _CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe _CreateInstance(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal));
            *(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATStringPointerUnsafe(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATStringPointerUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new global::System.IntPtr(native);
        }

        public ATStringPointerUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATStringPointerUnsafe(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal*)_Instance) = *((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public string String
        {
            get
            {
                if (((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal*)_Instance)->@string == global::System.IntPtr.Zero)
                    return default(string);
                var _retPtr = (byte*)((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal*)_Instance)->@string;
                int _length = 0;
                while (*(_retPtr++) != 0) _length += sizeof(byte);
                return global::System.Text.Encoding.UTF8.GetString((byte*)((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal*)_Instance)->@string, _length);
            }

            set
            {
                byte[] _bytes0 = global::System.Text.Encoding.UTF8.GetBytes(value);
                fixed (byte* _bytePtr0 = _bytes0)
                {
                    ((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal*)_Instance)->@string = (global::System.IntPtr)new global::System.IntPtr(_bytePtr0);
                }
            }
        }

        public ulong Length
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal*)_Instance)->length;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATStringPointerUnsafe._Internal*)_Instance)->length = value;
            }
        }
    }
}
