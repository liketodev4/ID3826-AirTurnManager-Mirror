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
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr bytes;

            [FieldOffset(8)]
            internal ulong length;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBytesDescription")]
            internal static extern global::System.IntPtr ATBytesDescription(global::System.IntPtr data, sbyte* buffer, ulong bufferCapacity);
        }

        public global::System.IntPtr _Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATBytesUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATBytesUnsafe>();

        protected bool _ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATBytesUnsafe _CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATBytesUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATBytesUnsafe _CreateInstance(global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATBytesUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal));
            *(global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATBytesUnsafe(global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATBytesUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new global::System.IntPtr(native);
        }

        public ATBytesUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATBytesUnsafe(global::AirTurnManager.Api.Foundation.ATBytesUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal*)_Instance) = *((global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATBytesUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public static string ATBytesDescription(global::AirTurnManager.Api.Foundation.ATBytesUnsafe data, sbyte* buffer, ulong bufferCapacity)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            var _ret = _Internal.ATBytesDescription(_arg0, buffer, bufferCapacity);
            if (_ret == global::System.IntPtr.Zero)
                return default(string);
            var _retPtr = (byte*)_ret;
            int _length = 0;
            while (*(_retPtr++) != 0) _length += sizeof(byte);
            return global::System.Text.Encoding.UTF8.GetString((byte*)_ret, _length);
        }

        public byte* Bytes
        {
            get
            {
                return (byte*)((global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal*)_Instance)->bytes;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal*)_Instance)->bytes = (global::System.IntPtr)value;
            }
        }

        public ulong Length
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal*)_Instance)->length;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATBytesUnsafe._Internal*)_Instance)->length = value;
            }
        }
    }
}
