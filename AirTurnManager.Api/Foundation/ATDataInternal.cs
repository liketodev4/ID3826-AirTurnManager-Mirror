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
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATDataSubclassNew")]
            internal static extern IntPtr ATDataSubclassNew(IntPtr optionalStorage, Foundation.ATObjectType type);
        }

        /// <summary>Create a new data object, for use in subclasses</summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <param name="type">The type of object we are creating</param>
        /// <returns>A new object subclassing `ATData` of the type and size specified</returns>
        public static Foundation.ATDataUnsafe ATDataSubclassNew(Foundation.ATDataUnsafe optionalStorage, Foundation.ATObjectType type)
        {
            var _arg0 = ReferenceEquals(optionalStorage, null) ? IntPtr.Zero : optionalStorage._Instance;
            var _ret = _Internal.ATDataSubclassNew(_arg0, type);
            Foundation.ATDataUnsafe _result0;
            if (_ret == IntPtr.Zero) _result0 = null;
            else if (Foundation.ATDataUnsafe.NativeToManagedMap.ContainsKey(_ret))
                _result0 = (Foundation.ATDataUnsafe)Foundation.ATDataUnsafe.NativeToManagedMap[_ret];
            else _result0 = Foundation.ATDataUnsafe._CreateInstance(_ret);
            return _result0;
        }
    }
}
