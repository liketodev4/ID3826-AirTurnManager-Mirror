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
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATGenericArraySubclassNew")]
            internal static extern global::System.IntPtr ATGenericArraySubclassNew(global::System.IntPtr optionalStorage, Foundation.ATObjectType type);
        }

        /// <summary>Create a new generic array object, for use in subclasses</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <param name="type">The type of object we are creating</param>
        /// <returns>A new object subclassing `ATData` of the type and size specified</returns>
        public static Foundation.ATGenericArrayUnsafe ATGenericArraySubclassNew(Foundation.ATGenericArrayUnsafe optionalStorage, Foundation.ATObjectType type)
        {
            var _arg0 = ReferenceEquals(optionalStorage, null) ? global::System.IntPtr.Zero : optionalStorage._Instance;
            var _ret = _Internal.ATGenericArraySubclassNew(_arg0, type);
            Foundation.ATGenericArrayUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATGenericArrayUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATGenericArrayUnsafe)Foundation.ATGenericArrayUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATGenericArrayUnsafe._CreateInstance(_ret);
            return _result0;
        }
    }
}
