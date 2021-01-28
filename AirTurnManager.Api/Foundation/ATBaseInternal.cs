using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation.Delegates
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void Action_IntPtr(IntPtr @object);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void Action_IntPtr_IntPtr(IntPtr @object, IntPtr @string);
}

namespace AirTurnManager.Api.Foundation
{
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ATBaseFreeFunction(IntPtr @object);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void ATBaseDescriptionFunction(IntPtr @object, IntPtr @string);

    public unsafe partial class ATObjectDefinition : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 40)]
        public partial struct _Internal
        {
            [FieldOffset(0)]
            internal ulong objectSize;

            [FieldOffset(8)]
            internal Foundation.ATObjectType superType;

            [FieldOffset(16)]
            internal IntPtr freeFunction;

            [FieldOffset(24)]
            internal IntPtr description;

            [FieldOffset(32)]
            internal IntPtr debugDescription;
        }

        public IntPtr _Instance { get; protected set; }

        internal static readonly Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATObjectDefinition> NativeToManagedMap = new Collections.Concurrent.ConcurrentDictionary<IntPtr, Foundation.ATObjectDefinition>();

        protected bool _ownsNativeInstance;

        internal static Foundation.ATObjectDefinition _CreateInstance(IntPtr native, bool skipVTables = false)
        {
            return new Foundation.ATObjectDefinition(native.ToPointer(), skipVTables);
        }

        internal static Foundation.ATObjectDefinition _CreateInstance(Foundation.ATObjectDefinition._Internal native, bool skipVTables = false)
        {
            return new Foundation.ATObjectDefinition(native, skipVTables);
        }

        private static void* _CopyValue(Foundation.ATObjectDefinition._Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(Foundation.ATObjectDefinition._Internal));
            *(Foundation.ATObjectDefinition._Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATObjectDefinition(Foundation.ATObjectDefinition._Internal native, bool skipVTables = false)
            : this(_CopyValue(native), skipVTables)
        {
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        protected ATObjectDefinition(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            _Instance = new IntPtr(native);
        }

        public ATObjectDefinition()
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATObjectDefinition._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
        }

        public ATObjectDefinition(Foundation.ATObjectDefinition _0)
        {
            _Instance = Marshal.AllocHGlobal(sizeof(Foundation.ATObjectDefinition._Internal));
            _ownsNativeInstance = true;
            NativeToManagedMap[_Instance] = this;
            *((Foundation.ATObjectDefinition._Internal*)_Instance) = *((Foundation.ATObjectDefinition._Internal*)_0._Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (_Instance == IntPtr.Zero)
                return;
            Foundation.ATObjectDefinition _dummy;
            NativeToManagedMap.TryRemove(_Instance, out _dummy);
            if (_ownsNativeInstance)
                Marshal.FreeHGlobal(_Instance);
            _Instance = IntPtr.Zero;
        }

        public ulong ObjectSize
        {
            get
            {
                return ((Foundation.ATObjectDefinition._Internal*)_Instance)->objectSize;
            }

            set
            {
                ((Foundation.ATObjectDefinition._Internal*)_Instance)->objectSize = value;
            }
        }

        public Foundation.ATObjectType SuperType
        {
            get
            {
                return ((Foundation.ATObjectDefinition._Internal*)_Instance)->superType;
            }

            set
            {
                ((Foundation.ATObjectDefinition._Internal*)_Instance)->superType = value;
            }
        }

        public Foundation.Delegates.Action_IntPtr FreeFunction
        {
            get
            {
                var _ptr0 = ((Foundation.ATObjectDefinition._Internal*)_Instance)->freeFunction;
                return _ptr0 == IntPtr.Zero ? null : (Foundation.Delegates.Action_IntPtr)Marshal.GetDelegateForFunctionPointer(_ptr0, typeof(Foundation.Delegates.Action_IntPtr));
            }

            set
            {
                ((Foundation.ATObjectDefinition._Internal*)_Instance)->freeFunction = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }

        public Foundation.Delegates.Action_IntPtr_IntPtr Description
        {
            get
            {
                var _ptr0 = ((Foundation.ATObjectDefinition._Internal*)_Instance)->description;
                return _ptr0 == IntPtr.Zero ? null : (Foundation.Delegates.Action_IntPtr_IntPtr)Marshal.GetDelegateForFunctionPointer(_ptr0, typeof(Foundation.Delegates.Action_IntPtr_IntPtr));
            }

            set
            {
                ((Foundation.ATObjectDefinition._Internal*)_Instance)->description = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }

        public Foundation.Delegates.Action_IntPtr_IntPtr DebugDescription
        {
            get
            {
                // TODO WTF?
                var _ptr0 = ((Foundation.ATObjectDefinition._Internal*)_Instance)->debugDescription;
                return _ptr0 == IntPtr.Zero ? null : (Foundation.ATBaseDescriptionFunction)Marshal.GetDelegateForFunctionPointer(_ptr0, typeof(Foundation.ATBaseDescriptionFunction));
            }

            set
            {
                ((Foundation.ATObjectDefinition._Internal*)_Instance)->debugDescription = value == null ? IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }
    }

    public unsafe partial class ATBase_Internal_
    {
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseSubclassNew")]
            internal static extern IntPtr ATBaseSubclassNew(IntPtr optionalStorage, Foundation.ATObjectType type);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseResizeObject")]
            internal static extern IntPtr ATBaseResizeObject(IntPtr @object, ulong newSize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATBaseRegisterSubclass")]
            internal static extern void ATBaseRegisterSubclass(Foundation.ATObjectType type, IntPtr definition);
        }

        public static Foundation.ATBaseUnsafe ATBaseSubclassNew(Foundation.ATBaseUnsafe optionalStorage, Foundation.ATObjectType type)
        {
            var _arg0 = ReferenceEquals(optionalStorage, null) ? IntPtr.Zero : optionalStorage._Instance;
            var _ret = _Internal.ATBaseSubclassNew(_arg0, type);
            Foundation.ATBaseUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATBaseUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATBaseUnsafe)Foundation.ATBaseUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATBaseUnsafe._CreateInstance(_ret);
            return _result0;
        }

        public static Foundation.ATBaseUnsafe ATBaseResizeObject(IntPtr @object, ulong newSize)
        {
            var _ret = _Internal.ATBaseResizeObject(@object, newSize);
            Foundation.ATBaseUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATBaseUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATBaseUnsafe)Foundation.ATBaseUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATBaseUnsafe._CreateInstance(_ret);
            return _result0;
        }

        public static void ATBaseRegisterSubclass(Foundation.ATObjectType type, Foundation.ATObjectDefinition definition)
        {
            var _arg1 = ReferenceEquals(definition, null) ? IntPtr.Zero : definition._Instance;
            _Internal.ATBaseRegisterSubclass(type, _arg1);
        }
    }
}
