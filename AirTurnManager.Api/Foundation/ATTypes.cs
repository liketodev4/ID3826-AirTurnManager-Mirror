using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.Foundation
{
    public unsafe partial class ATTypesUnsafe
    {
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATInitialisePointerArray")]
            internal static extern void ATInitialisePointerArray(IntPtr existingArrayOfSingleType, ulong existingTypeSize, ulong existingArrayCount, IntPtr destinationPointerArray);
        }

        /// <summary>Populate an array of pointers with pointers to elements in an array of items. Used in firmware for defining a local array of object storage, then generating an array of pointers to that storage for passing to the ATSC APIs which generally take an array of pointers to objects.</summary>
        /// <param name="existingArrayOfSingleType">The existing array of a certain type (usually an object)</param>
        /// <param name="existingTypeSize">The size of the elements</param>
        /// <param name="existingArrayCount">The number of elements</param>
        /// <param name="destinationPointerArray">The array of pointers to set element pointers in</param>
        public static void ATInitialisePointerArray(IntPtr existingArrayOfSingleType, ulong existingTypeSize, ulong existingArrayCount, IntPtr destinationPointerArray)
        {
            _Internal.ATInitialisePointerArray(existingArrayOfSingleType, existingTypeSize, existingArrayCount, destinationPointerArray);
        }
    }
}
