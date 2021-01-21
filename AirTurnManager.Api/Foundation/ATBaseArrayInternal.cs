using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    public unsafe partial class ATBaseArrayInternalUnsafe
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATBaseArraySubclassNew")]
            internal static extern global::System.IntPtr ATBaseArraySubclassNew(global::System.IntPtr optionalStorage, global::AirTurnManager.Api.Foundation.ATObjectType type);
        }

        /// <summary>Create a new base array object, for use in subclasses</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <param name="type">The type of object we are creating</param>
        /// <returns>A new object subclassing `ATData` of the type and size specified</returns>
        public static global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe ATBaseArraySubclassNew(global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe optionalStorage, global::AirTurnManager.Api.Foundation.ATObjectType type)
        {
            var __arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage.__Instance;
            var __ret = __Internal.ATBaseArraySubclassNew(__arg0, type);
            global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe)global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATBaseArrayUnsafe.__CreateInstance(__ret);
            return __result0;
        }
    }
}
