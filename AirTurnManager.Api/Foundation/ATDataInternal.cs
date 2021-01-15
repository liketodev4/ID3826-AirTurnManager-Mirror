using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    public unsafe partial class ATDataInternalUnsafe
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataSubclassNew")]
            internal static extern global::System.IntPtr ATDataSubclassNew(global::System.IntPtr optionalStorage, global::AirTurnManager.Api.Foundation.ATObjectType type);
        }

        /// <summary>Create a new data object, for use in subclasses</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <param name="type">The type of object we are creating</param>
        /// <returns>A new object subclassing `ATData` of the type and size specified</returns>
        public static global::AirTurnManager.Api.Foundation.ATData ATDataSubclassNew(global::AirTurnManager.Api.Foundation.ATData optionalStorage, global::AirTurnManager.Api.Foundation.ATObjectType type)
        {
            var __arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage.__Instance;
            var __ret = __Internal.ATDataSubclassNew(__arg0, type);
            global::AirTurnManager.Api.Foundation.ATData __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::AirTurnManager.Api.Foundation.ATData.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::AirTurnManager.Api.Foundation.ATData)global::AirTurnManager.Api.Foundation.ATData.NativeToManagedMap[__ret];
            else __result0 = global::AirTurnManager.Api.Foundation.ATData.__CreateInstance(__ret);
            return __result0;
        }
    }
}
