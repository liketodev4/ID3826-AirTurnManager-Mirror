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
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint v;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATSwappedFloat32@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe __CreateInstance(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATSwappedFloat32Unsafe(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATSwappedFloat32Unsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATSwappedFloat32Unsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATSwappedFloat32Unsafe(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint V
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal*)__Instance)->v;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal*)__Instance)->v = value;
            }
        }
    }

    public unsafe partial class ATSwappedFloat64Unsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong v;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATSwappedFloat64@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe __CreateInstance(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATSwappedFloat64Unsafe(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATSwappedFloat64Unsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATSwappedFloat64Unsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATSwappedFloat64Unsafe(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong V
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal*)__Instance)->v;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal*)__Instance)->v = value;
            }
        }
    }

    public unsafe partial class ATEndianUnsafe
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16@@YAGG@Z")]
            internal static extern ushort ATSwapInt16(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32@@YAII@Z")]
            internal static extern uint ATSwapInt32(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16BigToHost@@YAGG@Z")]
            internal static extern ushort ATSwapInt16BigToHost(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32BigToHost@@YAII@Z")]
            internal static extern uint ATSwapInt32BigToHost(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64BigToHost@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64BigToHost(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16HostToBig@@YAGG@Z")]
            internal static extern ushort ATSwapInt16HostToBig(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32HostToBig@@YAII@Z")]
            internal static extern uint ATSwapInt32HostToBig(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64HostToBig@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64HostToBig(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16LittleToHost@@YAGG@Z")]
            internal static extern ushort ATSwapInt16LittleToHost(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32LittleToHost@@YAII@Z")]
            internal static extern uint ATSwapInt32LittleToHost(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64LittleToHost@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64LittleToHost(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt16HostToLittle@@YAGG@Z")]
            internal static extern ushort ATSwapInt16HostToLittle(ushort arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt32HostToLittle@@YAII@Z")]
            internal static extern uint ATSwapInt32HostToLittle(uint arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATSwapInt64HostToLittle@@YA_K_K@Z")]
            internal static extern ulong ATSwapInt64HostToLittle(ulong arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertFloatHostToSwapped@@YA?AUATSwappedFloat32@@M@Z")]
            internal static extern global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal ATConvertFloatHostToSwapped(float arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertFloatSwappedToHost@@YAMUATSwappedFloat32@@@Z")]
            internal static extern float ATConvertFloatSwappedToHost(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertDoubleHostToSwapped@@YA?AUATSwappedFloat64@@N@Z")]
            internal static extern global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal ATConvertDoubleHostToSwapped(double arg);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?ATConvertDoubleSwappedToHost@@YANUATSwappedFloat64@@@Z")]
            internal static extern double ATConvertDoubleSwappedToHost(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal arg);
        }

        public static ushort ATSwapInt16(ushort arg)
        {
            var __ret = __Internal.ATSwapInt16(arg);
            return __ret;
        }

        public static uint ATSwapInt32(uint arg)
        {
            var __ret = __Internal.ATSwapInt32(arg);
            return __ret;
        }

        public static ulong ATSwapInt64(ulong arg)
        {
            var __ret = __Internal.ATSwapInt64(arg);
            return __ret;
        }

        public static ushort ATSwapInt16BigToHost(ushort arg)
        {
            var __ret = __Internal.ATSwapInt16BigToHost(arg);
            return __ret;
        }

        public static uint ATSwapInt32BigToHost(uint arg)
        {
            var __ret = __Internal.ATSwapInt32BigToHost(arg);
            return __ret;
        }

        public static ulong ATSwapInt64BigToHost(ulong arg)
        {
            var __ret = __Internal.ATSwapInt64BigToHost(arg);
            return __ret;
        }

        public static ushort ATSwapInt16HostToBig(ushort arg)
        {
            var __ret = __Internal.ATSwapInt16HostToBig(arg);
            return __ret;
        }

        public static uint ATSwapInt32HostToBig(uint arg)
        {
            var __ret = __Internal.ATSwapInt32HostToBig(arg);
            return __ret;
        }

        public static ulong ATSwapInt64HostToBig(ulong arg)
        {
            var __ret = __Internal.ATSwapInt64HostToBig(arg);
            return __ret;
        }

        public static ushort ATSwapInt16LittleToHost(ushort arg)
        {
            var __ret = __Internal.ATSwapInt16LittleToHost(arg);
            return __ret;
        }

        public static uint ATSwapInt32LittleToHost(uint arg)
        {
            var __ret = __Internal.ATSwapInt32LittleToHost(arg);
            return __ret;
        }

        public static ulong ATSwapInt64LittleToHost(ulong arg)
        {
            var __ret = __Internal.ATSwapInt64LittleToHost(arg);
            return __ret;
        }

        public static ushort ATSwapInt16HostToLittle(ushort arg)
        {
            var __ret = __Internal.ATSwapInt16HostToLittle(arg);
            return __ret;
        }

        public static uint ATSwapInt32HostToLittle(uint arg)
        {
            var __ret = __Internal.ATSwapInt32HostToLittle(arg);
            return __ret;
        }

        public static ulong ATSwapInt64HostToLittle(ulong arg)
        {
            var __ret = __Internal.ATSwapInt64HostToLittle(arg);
            return __ret;
        }

        public static global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe ATConvertFloatHostToSwapped(float arg)
        {
            var __ret = __Internal.ATConvertFloatHostToSwapped(arg);
            return global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__CreateInstance(__ret);
        }

        public static float ATConvertFloatSwappedToHost(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe arg)
        {
            if (ReferenceEquals(arg, null))
                throw new global::System.ArgumentNullException("arg", "Cannot be null because it is passed by value.");
            var __arg0 = arg.__Instance;
            var __ret = __Internal.ATConvertFloatSwappedToHost(*(global::AirTurnManager.Api.Foundation.ATSwappedFloat32Unsafe.__Internal*)__arg0);
            return __ret;
        }

        public static global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe ATConvertDoubleHostToSwapped(double arg)
        {
            var __ret = __Internal.ATConvertDoubleHostToSwapped(arg);
            return global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__CreateInstance(__ret);
        }

        public static double ATConvertDoubleSwappedToHost(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe arg)
        {
            if (ReferenceEquals(arg, null))
                throw new global::System.ArgumentNullException("arg", "Cannot be null because it is passed by value.");
            var __arg0 = arg.__Instance;
            var __ret = __Internal.ATConvertDoubleSwappedToHost(*(global::AirTurnManager.Api.Foundation.ATSwappedFloat64Unsafe.__Internal*)__arg0);
            return __ret;
        }
    }
}
