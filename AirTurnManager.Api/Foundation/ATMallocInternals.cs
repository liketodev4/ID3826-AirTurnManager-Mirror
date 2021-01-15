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
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.Foundation.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATWeakPointerFreePointerReferencesArray")]
            internal static extern void ATWeakPointerFreePointerReferencesArray();
        }

        public static void ATWeakPointerFreePointerReferencesArray()
        {
            __Internal.ATWeakPointerFreePointerReferencesArray();
        }
    }
}
