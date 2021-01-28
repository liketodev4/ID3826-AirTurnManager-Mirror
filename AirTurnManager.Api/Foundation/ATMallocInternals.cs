using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    public unsafe partial class ATMallocInternalsUnsafe
    {
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATWeakPointerFreePointerReferencesArray")]
            internal static extern void ATWeakPointerFreePointerReferencesArray();
        }

        public static void ATWeakPointerFreePointerReferencesArray()
        {
            _Internal.ATWeakPointerFreePointerReferencesArray();
        }
    }
}
