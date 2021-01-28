using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATAssociatedModePortDataMaxDataLengthExcludingAssociatedData
    {
        ATAssociatedModePortDataMaxDataLengthExcludingAssociatedData = 2
    }

    public unsafe partial class ATAssociatedModePortDataUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal DeviceTypes.ATMode mode;

            [FieldOffset(1)]
            internal DeviceTypes.ATPortEnum port;

            [FieldOffset(8)]
            internal DeviceTypes.ATBytes._Internal associatedData;
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, DeviceTypes.ATAssociatedModePortDataUnsafe> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, DeviceTypes.ATAssociatedModePortDataUnsafe>();

        protected bool _ownsNativeInstance;

        internal static DeviceTypes.ATAssociatedModePortDataUnsafe _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new DeviceTypes.ATAssociatedModePortDataUnsafe(native.ToPointer(), skipVTables);
        }

        internal static DeviceTypes.ATAssociatedModePortDataUnsafe _CreateInstance(DeviceTypes.ATAssociatedModePortDataUnsafe._Internal native, bool skipVTables = false)
        {
            return new DeviceTypes.ATAssociatedModePortDataUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(DeviceTypes.ATAssociatedModePortDataUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(DeviceTypes.ATAssociatedModePortDataUnsafe._Internal));
            *(DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATAssociatedModePortDataUnsafe(DeviceTypes.ATAssociatedModePortDataUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATAssociatedModePortDataUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATAssociatedModePortDataUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(DeviceTypes.ATAssociatedModePortDataUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATAssociatedModePortDataUnsafe(DeviceTypes.ATAssociatedModePortDataUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(DeviceTypes.ATAssociatedModePortDataUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance) = *((DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            DeviceTypes.ATAssociatedModePortDataUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public DeviceTypes.ATMode Mode
        {
            get
            {
                return ((DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->mode;
            }

            set
            {
                ((DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->mode = value;
            }
        }

        public DeviceTypes.ATPortEnum Port
        {
            get
            {
                return ((DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->port;
            }

            set
            {
                ((DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->port = value;
            }
        }

        public DeviceTypes.ATBytes AssociatedData
        {
            get
            {
                return DeviceTypes.ATBytes._CreateInstance(new IntPtr(&((DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->associatedData));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->associatedData = *(DeviceTypes.ATBytes._Internal*)value._Instance;
            }
        }
    }
}
