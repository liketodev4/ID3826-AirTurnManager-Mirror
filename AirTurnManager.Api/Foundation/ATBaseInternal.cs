using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation.Delegates
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void Action_IntPtr(global::System.IntPtr @object);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void Action_IntPtr_IntPtr(global::System.IntPtr @object, global::System.IntPtr @string);
}

namespace AirTurnManager.Api.Foundation
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void ATBaseFreeFunction(global::System.IntPtr @object);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void ATBaseDescriptionFunction(global::System.IntPtr @object, global::System.IntPtr @string);

    public unsafe partial class ATObjectDefinition : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong objectSize;

            [FieldOffset(8)]
            internal global::AirTurnManager.Api.Foundation.ATObjectType superType;

            [FieldOffset(16)]
            internal global::System.IntPtr freeFunction;

            [FieldOffset(24)]
            internal global::System.IntPtr description;

            [FieldOffset(32)]
            internal global::System.IntPtr debugDescription;

            //[SuppressUnmanagedCodeSecurity]
            //[DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            //    EntryPoint = "??0ATObjectDefinition@@QEAA@AEBU0@@Z")]
            //internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATObjectDefinition> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATObjectDefinition>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATObjectDefinition __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATObjectDefinition(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATObjectDefinition __CreateInstance(global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATObjectDefinition(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATObjectDefinition(global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATObjectDefinition(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATObjectDefinition()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATObjectDefinition(global::AirTurnManager.Api.Foundation.ATObjectDefinition _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATObjectDefinition __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong ObjectSize
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance)->objectSize;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance)->objectSize = value;
            }
        }

        public global::AirTurnManager.Api.Foundation.ATObjectType SuperType
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance)->superType;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance)->superType = value;
            }
        }

        public global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr FreeFunction
        {
            get
            {
                var __ptr0 = ((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance)->freeFunction;
                return __ptr0 == IntPtr.Zero ? null : (global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr)Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr));
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance)->freeFunction = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }

        public global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_IntPtr Description
        {
            get
            {
                var __ptr0 = ((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance)->description;
                return __ptr0 == IntPtr.Zero ? null : (global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_IntPtr)Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_IntPtr));
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance)->description = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }

        public global::AirTurnManager.Api.Foundation.Delegates.Action_IntPtr_IntPtr DebugDescription
        {
            get
            {
                var __ptr0 = ((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance)->debugDescription;
                return __ptr0 == IntPtr.Zero ? null : (global::AirTurnManager.Api.Foundation.ATBaseDescriptionFunction)Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::AirTurnManager.Api.Foundation.ATBaseDescriptionFunction));
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATObjectDefinition.__Internal*)__Instance)->debugDescription = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }
    }

    public unsafe partial class ATBase_Internal_
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseSubclassNew")]
            internal static extern global::System.IntPtr ATBaseSubclassNew(global::System.IntPtr optionalStorage, global::AirTurnManager.Api.Foundation.ATObjectType type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseResizeObject")]
            internal static extern global::System.IntPtr ATBaseResizeObject(global::System.IntPtr @object, ulong newSize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseRegisterSubclass")]
            internal static extern void ATBaseRegisterSubclass(global::AirTurnManager.Api.Foundation.ATObjectType type, global::System.IntPtr definition);
        }

        public static global::AirTurnManager.Api.Foundation.ATBaseUnsafe ATBaseSubclassNew(global::AirTurnManager.Api.Foundation.ATBaseUnsafe optionalStorage, global::AirTurnManager.Api.Foundation.ATObjectType type)
        {
            var __arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage.__Instance;
            var __ret = __Internal.ATBaseSubclassNew(__arg0, type);
            global::AirTurnManager.Api.Foundation.ATBaseUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATBaseUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATBaseUnsafe)global::AirTurnManager.Api.Foundation.ATBaseUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        public static global::AirTurnManager.Api.Foundation.ATBaseUnsafe ATBaseResizeObject(global::System.IntPtr @object, ulong newSize)
        {
            var __ret = __Internal.ATBaseResizeObject(@object, newSize);
            global::AirTurnManager.Api.Foundation.ATBaseUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATBaseUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATBaseUnsafe)global::AirTurnManager.Api.Foundation.ATBaseUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATBaseUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        public static void ATBaseRegisterSubclass(global::AirTurnManager.Api.Foundation.ATObjectType type, global::AirTurnManager.Api.Foundation.ATObjectDefinition definition)
        {
            var __arg1 = ReferenceEquals(definition, null) ? global::System.IntPtr.Zero : definition.__Instance;
            __Internal.ATBaseRegisterSubclass(type, __arg1);
        }
    }
}
