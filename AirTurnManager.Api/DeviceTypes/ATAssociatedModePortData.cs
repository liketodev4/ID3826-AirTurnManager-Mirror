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
            internal global::AirTurnManager.Api.DeviceTypes.ATMode mode;

            [FieldOffset(1)]
            internal global::AirTurnManager.Api.DeviceTypes.ATPort port;

            [FieldOffset(8)]
            internal global::AirTurnManager.Api.DeviceTypes.ATBytes._Internal associatedData;

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATAssociatedModePortDataStruct@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr _instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr _Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe>();

        protected bool _ownsNativeInstance;

        internal static global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe _CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe _CreateInstance(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe(native, skipVTables);
        }

        private static void* _CopyValue(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal));
            *(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATAssociatedModePortDataUnsafe(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATAssociatedModePortDataUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new global::System.IntPtr(native);
        }

        public ATAssociatedModePortDataUnsafe()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATAssociatedModePortDataUnsafe(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance) = *((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public global::AirTurnManager.Api.DeviceTypes.ATMode Mode
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->mode;
            }

            set
            {
                ((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->mode = value;
            }
        }

        public global::AirTurnManager.Api.DeviceTypes.ATPort Port
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->port;
            }

            set
            {
                ((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->port = value;
            }
        }

        public global::AirTurnManager.Api.DeviceTypes.ATBytes AssociatedData
        {
            get
            {
                return global::AirTurnManager.Api.DeviceTypes.ATBytes._CreateInstance(new global::System.IntPtr(&((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->associatedData));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe._Internal*)_Instance)->associatedData = *(global::AirTurnManager.Api.DeviceTypes.ATBytes._Internal*)value._Instance;
            }
        }
    }
}
