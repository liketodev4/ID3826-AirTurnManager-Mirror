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
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::AirTurnManager.Api.DeviceTypes.ATMode mode;

            [FieldOffset(1)]
            internal global::AirTurnManager.Api.DeviceTypes.ATPort port;

            [FieldOffset(8)]
            internal global::AirTurnManager.Api.DeviceTypes.ATBytes.__Internal associatedData;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATAssociatedModePortDataStruct@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe __CreateInstance(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal));
            *(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATAssociatedModePortDataUnsafe(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATAssociatedModePortDataUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATAssociatedModePortDataUnsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATAssociatedModePortDataUnsafe(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::AirTurnManager.Api.DeviceTypes.ATMode Mode
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal*)__Instance)->mode;
            }

            set
            {
                ((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal*)__Instance)->mode = value;
            }
        }

        public global::AirTurnManager.Api.DeviceTypes.ATPort Port
        {
            get
            {
                return ((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal*)__Instance)->port;
            }

            set
            {
                ((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal*)__Instance)->port = value;
            }
        }

        public global::AirTurnManager.Api.DeviceTypes.ATBytes AssociatedData
        {
            get
            {
                return global::AirTurnManager.Api.DeviceTypes.ATBytes.__CreateInstance(new global::System.IntPtr(&((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal*)__Instance)->associatedData));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::AirTurnManager.Api.DeviceTypes.ATAssociatedModePortDataUnsafe.__Internal*)__Instance)->associatedData = *(global::AirTurnManager.Api.DeviceTypes.ATBytes.__Internal*)value.__Instance;
            }
        }
    }
}
