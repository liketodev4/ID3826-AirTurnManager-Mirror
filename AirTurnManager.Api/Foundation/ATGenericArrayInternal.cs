using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    public unsafe partial class ATGenericArrayInternalUnsafe
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("Constants.ATSC_API", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArraySubclassNew")]
            internal static extern global::System.IntPtr ATGenericArraySubclassNew(global::System.IntPtr optionalStorage, global::AirTurnManager.Api.Foundation.ATObjectType type);
        }

        /// <summary>Create a new generic array object, for use in subclasses</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <param name="type">The type of object we are creating</param>
        /// <returns>A new object subclassing `ATData` of the type and size specified</returns>
        public static global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe ATGenericArraySubclassNew(global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe optionalStorage, global::AirTurnManager.Api.Foundation.ATObjectType type)
        {
            var __arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage.__Instance;
            var __ret = __Internal.ATGenericArraySubclassNew(__arg0, type);
            global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe)global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATGenericArrayUnsafe.__CreateInstance(__ret);
            return __result0;
        }
    }
}
