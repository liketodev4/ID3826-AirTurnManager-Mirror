using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    /// <summary>The struct for ATString objects</summary>
    /// <summary>A forward declaration of ATString so it can be used in these functions</summary>
    public unsafe partial class ATStringUnsafe : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::AirTurnManager.Api.Foundation.ATDataUnsafe.__Internal _base;

            [FieldOffset(32)]
            internal byte _dynamicAllocation;

            [FieldOffset(40)]
            internal ulong maxLength;

            [FieldOffset(48)]
            internal ulong length;

            [FieldOffset(56)]
            internal global::System.IntPtr @string;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ATString@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr __instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringNew")]
            internal static extern global::System.IntPtr ATStringNew(global::System.IntPtr optionalStorage);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringInitWithDynamicAllocation")]
            internal static extern global::System.IntPtr ATStringInitWithDynamicAllocation(global::System.IntPtr @string);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringInit")]
            internal static extern global::System.IntPtr ATStringInit(global::System.IntPtr @string, ulong maxLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringInitWithStringBuffer")]
            internal static extern global::System.IntPtr ATStringInitWithStringBuffer(global::System.IntPtr @string, [MarshalAs(UnmanagedType.LPUTF8Str)] string existingString, ulong length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringInitWithStringBufferNoCopy")]
            internal static extern global::System.IntPtr ATStringInitWithStringBufferNoCopy(global::System.IntPtr @string, sbyte* existingString, ulong length, ulong capacity);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringResizeMaxLength")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATStringResizeMaxLength(global::System.IntPtr @string, ulong newMaxLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringResize")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATStringResize(global::System.IntPtr @string, ulong newLength);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringResizeMaxLengthToFit")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATStringResizeMaxLengthToFit(global::System.IntPtr @string);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringResetToEmpty")]
            internal static extern void ATStringResetToEmpty(global::System.IntPtr @string);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringAppendFormat")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATStringAppendFormat(global::System.IntPtr @string, [MarshalAs(UnmanagedType.LPUTF8Str)] string format);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringAppendStringWithLength")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATStringAppendStringWithLength(global::System.IntPtr @string, [MarshalAs(UnmanagedType.LPUTF8Str)] string stringToAppend, ulong length);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringAppendString")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATStringAppendString(global::System.IntPtr @string, [MarshalAs(UnmanagedType.LPUTF8Str)] string stringToAppend);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringAppendATString")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATStringAppendATString(global::System.IntPtr @string, global::System.IntPtr stringToAppend);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringCopy")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATStringCopy(global::System.IntPtr destination, global::System.IntPtr source);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATStringIsEqual")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATStringIsEqual(global::System.IntPtr string1, global::System.IntPtr string2);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATStringUnsafe> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::AirTurnManager.Api.Foundation.ATStringUnsafe>();

        protected bool __ownsNativeInstance;

        internal static global::AirTurnManager.Api.Foundation.ATStringUnsafe __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATStringUnsafe(native.ToPointer(), skipVTables);
        }

        internal static global::AirTurnManager.Api.Foundation.ATStringUnsafe __CreateInstance(global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal native, bool skipVTables = false)
        {
            return new global::AirTurnManager.Api.Foundation.ATStringUnsafe(native, skipVTables);
        }

        private static void* __CopyValue(global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal));
            *(global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private ATStringUnsafe(global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected ATStringUnsafe(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public ATStringUnsafe()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public ATStringUnsafe(global::AirTurnManager.Api.Foundation.ATStringUnsafe _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance) = *((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::AirTurnManager.Api.Foundation.ATStringUnsafe __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        /// <summary>Create a new string</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        public static global::AirTurnManager.Api.Foundation.ATStringUnsafe ATStringNew(global::AirTurnManager.Api.Foundation.ATStringUnsafe optionalStorage)
        {
            var __arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage.__Instance;
            var __ret = __Internal.ATStringNew(__arg0);
            global::AirTurnManager.Api.Foundation.ATStringUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATStringUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATStringUnsafe)global::AirTurnManager.Api.Foundation.ATStringUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATStringUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a string object with dynamic allocation</summary>
        /// <param name="string">The object to initialize. Can be `NULL` so the result from `ATStringNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        /// <remarks>Dynamic allocation means the object will automatically allocate more space when appending a string that is beyond its capacity</remarks>
        public static global::AirTurnManager.Api.Foundation.ATStringUnsafe ATStringInitWithDynamicAllocation(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATStringInitWithDynamicAllocation(__arg0);
            global::AirTurnManager.Api.Foundation.ATStringUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATStringUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATStringUnsafe)global::AirTurnManager.Api.Foundation.ATStringUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATStringUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a string object</summary>
        /// <param name="string">The object to initialize. Can be `NULL` so the result from `ATStringNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="maxLength">The maximum length of the string</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATStringUnsafe ATStringInit(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string, ulong maxLength)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATStringInit(__arg0, maxLength);
            global::AirTurnManager.Api.Foundation.ATStringUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATStringUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATStringUnsafe)global::AirTurnManager.Api.Foundation.ATStringUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATStringUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a string object from an existing string</summary>
        /// <param name="string">The object to initialize. Can be `NULL` so the result from `ATStringNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingString">The existing string buffer</param>
        /// <param name="length">The existing string length excluding terminating null</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATStringUnsafe ATStringInitWithStringBuffer(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string, string existingString, ulong length)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATStringInitWithStringBuffer(__arg0, existingString, length);
            global::AirTurnManager.Api.Foundation.ATStringUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATStringUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATStringUnsafe)global::AirTurnManager.Api.Foundation.ATStringUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATStringUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Initialize a string object from an existing string using the existing buffer without copying</summary>
        /// <param name="string">The object to initialize. Can be `NULL` so the result from `ATStringNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <param name="existingString">The existing string buffer</param>
        /// <param name="length">The existing string length excluding terminating null</param>
        /// <param name="capacity">The maximum capacity of the existing string buffer</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        public static global::AirTurnManager.Api.Foundation.ATStringUnsafe ATStringInitWithStringBufferNoCopy(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string, sbyte* existingString, ulong length, ulong capacity)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATStringInitWithStringBufferNoCopy(__arg0, existingString, length, capacity);
            global::AirTurnManager.Api.Foundation.ATStringUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATStringUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATStringUnsafe)global::AirTurnManager.Api.Foundation.ATStringUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATStringUnsafe.__CreateInstance(__ret);
            return __result0;
        }

        /// <summary>Resize a string object's capacity, reallocating memory</summary>
        /// <param name="string">The string object</param>
        /// <param name="newMaxLength">The new max length. If less than the current length, the string will be shortened to max length</param>
        /// <returns>`true` if successful</returns>
        public static bool ATStringResizeMaxLength(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string, ulong newMaxLength)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATStringResizeMaxLength(__arg0, newMaxLength);
            return __ret;
        }

        /// <summary>Resize a string length</summary>
        /// <param name="string">The string object</param>
        /// <param name="newLength">The new length. If greater than current capacity, the string buffer will be resized if possible</param>
        /// <returns>`true` if successful, or false if string buffer could not be resized when required</returns>
        public static bool ATStringResize(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string, ulong newLength)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATStringResize(__arg0, newLength);
            return __ret;
        }

        /// <summary>Resize the string to fit its length</summary>
        /// <param name="string">The string object</param>
        /// <returns>`true` if successful</returns>
        public static bool ATStringResizeMaxLengthToFit(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATStringResizeMaxLengthToFit(__arg0);
            return __ret;
        }

        /// <summary>Reset the string to be empty. Does not reduce the string capacity</summary>
        /// <param name="string">The string object</param>
        public static void ATStringResetToEmpty(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            __Internal.ATStringResetToEmpty(__arg0);
        }

        /// <summary>Append a string of a given format, like `sprintf`</summary>
        /// <param name="string">The string object</param>
        /// <param name="format">The format of the string to append</param>
        /// <param name="...">All string formatting parameters</param>
        /// <returns>`true` if successful</returns>
        public static bool ATStringAppendFormat(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string, string format)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATStringAppendFormat(__arg0, format);
            return __ret;
        }

        /// <summary>Append a constant string with a given length</summary>
        /// <param name="string">The string object</param>
        /// <param name="stringToAppend">The string to append</param>
        /// <param name="length">The length to append</param>
        /// <returns>`true` if successful</returns>
        public static bool ATStringAppendStringWithLength(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string, string stringToAppend, ulong length)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATStringAppendStringWithLength(__arg0, stringToAppend, length);
            return __ret;
        }

        /// <summary>Append a constant string</summary>
        /// <param name="string">The string object</param>
        /// <param name="stringToAppend">The string to append</param>
        /// <returns>`true` if successful</returns>
        /// <remarks>Will determine the length of the string by finding the null terminating character</remarks>
        public static bool ATStringAppendString(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string, string stringToAppend)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __ret = __Internal.ATStringAppendString(__arg0, stringToAppend);
            return __ret;
        }

        /// <summary>Append an ATString object</summary>
        /// <param name="string">The string object</param>
        /// <param name="stringToAppend">The string object to append</param>
        /// <returns>`true` if successful</returns>
        public static bool ATStringAppendATString(global::AirTurnManager.Api.Foundation.ATStringUnsafe @string, global::AirTurnManager.Api.Foundation.ATStringUnsafe stringToAppend)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            var __arg1 = ReferenceEquals(stringToAppend, null) ? global::System.IntPtr.Zero : stringToAppend.__Instance;
            var __ret = __Internal.ATStringAppendATString(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Copy a string object</summary>
        /// <param name="destination">The destination string object to copy into</param>
        /// <param name="source">The source string object</param>
        /// <returns>`true` if successful</returns>
        public static bool ATStringCopy(global::AirTurnManager.Api.Foundation.ATStringUnsafe destination, global::AirTurnManager.Api.Foundation.ATStringUnsafe source)
        {
            var __arg0 = ReferenceEquals(destination, null) ? global::System.IntPtr.Zero : destination.__Instance;
            var __arg1 = ReferenceEquals(source, null) ? global::System.IntPtr.Zero : source.__Instance;
            var __ret = __Internal.ATStringCopy(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Determine if two string objects are equal</summary>
        /// <param name="string1">The first string</param>
        /// <param name="string2">The second string</param>
        /// <returns>`true` if the strings are equal</returns>
        public static bool ATStringIsEqual(global::AirTurnManager.Api.Foundation.ATStringUnsafe string1, global::AirTurnManager.Api.Foundation.ATStringUnsafe string2)
        {
            var __arg0 = ReferenceEquals(string1, null) ? global::System.IntPtr.Zero : string1.__Instance;
            var __arg1 = ReferenceEquals(string2, null) ? global::System.IntPtr.Zero : string2.__Instance;
            var __ret = __Internal.ATStringIsEqual(__arg0, __arg1);
            return __ret;
        }

        public global::AirTurnManager.Api.Foundation.ATDataUnsafe Base
        {
            get
            {
                return global::AirTurnManager.Api.Foundation.ATDataUnsafe.__CreateInstance(new global::System.IntPtr(&((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance)->_base));
            }

            set
            {
                if (ReferenceEquals(value, null))
                    throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                ((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance)->_base = *(global::AirTurnManager.Api.Foundation.ATDataUnsafe.__Internal*)value.__Instance;
            }
        }

        public bool DynamicAllocation
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance)->_dynamicAllocation != 0;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance)->_dynamicAllocation = (byte)(value ? 1 : 0);
            }
        }

        public ulong MaxLength
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance)->maxLength;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance)->maxLength = value;
            }
        }

        public ulong Length
        {
            get
            {
                return ((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance)->length;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance)->length = value;
            }
        }

        public sbyte* String
        {
            get
            {
                return (sbyte*)((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance)->@string;
            }

            set
            {
                ((global::AirTurnManager.Api.Foundation.ATStringUnsafe.__Internal*)__Instance)->@string = (global::System.IntPtr)value;
            }
        }
    }
}
