using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    public unsafe partial class ATSwappedFloat32Unsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal uint v;
        }

        public global::System.IntPtr _Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATSwappedFloat32Unsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATSwappedFloat32Unsafe>();

        protected bool _ownsNativeInstance;

        internal static Foundation.ATSwappedFloat32Unsafe _CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Foundation.ATSwappedFloat32Unsafe(native.ToPointer(), skipVTables);
        }

        internal static Foundation.ATSwappedFloat32Unsafe _CreateInstance(Foundation.ATSwappedFloat32Unsafe._Internal native, bool skipVTables = false)
        {
            return new Foundation.ATSwappedFloat32Unsafe(native, skipVTables);
        }

        private static void* _CopyValue(Foundation.ATSwappedFloat32Unsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Foundation.ATSwappedFloat32Unsafe._Internal));
            *(Foundation.ATSwappedFloat32Unsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATSwappedFloat32Unsafe(Foundation.ATSwappedFloat32Unsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATSwappedFloat32Unsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new global::System.IntPtr(native);
        }

        public ATSwappedFloat32Unsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATSwappedFloat32Unsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATSwappedFloat32Unsafe(Foundation.ATSwappedFloat32Unsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATSwappedFloat32Unsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((Foundation.ATSwappedFloat32Unsafe._Internal*)_Instance) = *((Foundation.ATSwappedFloat32Unsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            Foundation.ATSwappedFloat32Unsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public uint V
        {
            get
            {
                return ((Foundation.ATSwappedFloat32Unsafe._Internal*)_Instance)->v;
            }

            set
            {
                ((Foundation.ATSwappedFloat32Unsafe._Internal*)_Instance)->v = value;
            }
        }
    }

    public unsafe partial class ATSwappedFloat64Unsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal ulong v;
        }

        public global::System.IntPtr _Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATSwappedFloat64Unsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATSwappedFloat64Unsafe>();

        protected bool _ownsNativeInstance;

        internal static Foundation.ATSwappedFloat64Unsafe _CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new Foundation.ATSwappedFloat64Unsafe(native.ToPointer(), skipVTables);
        }

        internal static Foundation.ATSwappedFloat64Unsafe _CreateInstance(Foundation.ATSwappedFloat64Unsafe._Internal native, bool skipVTables = false)
        {
            return new Foundation.ATSwappedFloat64Unsafe(native, skipVTables);
        }

        private static void* _CopyValue(Foundation.ATSwappedFloat64Unsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Foundation.ATSwappedFloat64Unsafe._Internal));
            *(Foundation.ATSwappedFloat64Unsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATSwappedFloat64Unsafe(Foundation.ATSwappedFloat64Unsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATSwappedFloat64Unsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new global::System.IntPtr(native);
        }

        public ATSwappedFloat64Unsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATSwappedFloat64Unsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATSwappedFloat64Unsafe(Foundation.ATSwappedFloat64Unsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATSwappedFloat64Unsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((Foundation.ATSwappedFloat64Unsafe._Internal*)_Instance) = *((Foundation.ATSwappedFloat64Unsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            Foundation.ATSwappedFloat64Unsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public ulong V
        {
            get
            {
                return ((Foundation.ATSwappedFloat64Unsafe._Internal*)_Instance)->v;
            }

            set
            {
                ((Foundation.ATSwappedFloat64Unsafe._Internal*)_Instance)->v = value;
            }
        }
    }

    public unsafe partial class ATEndianUnsafe
    {
        public partial struct _Internal
        {

        } 
    }
}
