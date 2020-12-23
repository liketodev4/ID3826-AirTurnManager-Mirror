using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using uint8_t = System.Char;
using _ATBaseSignature = System.Char;
using System.Runtime.InteropServices;

namespace AirTurnManager.AtscApiWrapper.Foundation
{
    [StructLayout(LayoutKind.Sequential)]
    public class ATBase
    {
        /// A predefined static signature, the value is the same between all objects. Used to determine if a pointer is to an ATBase object or if an ATBase object has been corrupted.
        _ATBaseSignature _signature;
        /// The retain count of the object. On creating a new object this is 1. Retaining the object increases the retain count, releasing decreases the count. When 0, object is free'd
        uint8_t _retainCount;
        /// If the struct storage is owned by the object then it will be free'd when the retain count is 0
        bool _ownsMemory = true;
        /// true if init has completed
        bool _hasInitCompleted = true;
        /// The type of the object
        ATObjectType _type;

        // Enum for all types of ATSharedComponent Objects
        public enum ATObjectType
        {
            ATObjectTypeInvalid,
            ATObjectTypeATBase,
            ATObjectTypeATData,
            ATObjectTypeATString,
            ATObjectTypeATGenericArray,
            ATObjectTypeATBaseArray,
            ATObjectTypeATPortConfigItemValue,
            ATObjectTypeATPortConfigItem,
            ATObjectTypeATPortConfig,
            ATObjectTypeATConfig,
            ATObjectTypeATAnalogPortConfig,
            ATObjectTypeATAnalogInputConfig,
            ATObjectTypeATAnalogInputConfigManager,
            ATObjectTypeExternal
        }
    }
    
    internal static class ATBaseMethods
    {
        /// <summary>
        /// Create a new object
        /// </summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        /// <remarks>ATSC_API ATBase *_Nullable ATBaseNew(ATBase *_Nullable optionalStorage)</remarks>
        [DllImport(Constants.ATSC_API)]
        internal static extern ATBase ATBaseNew(ATBase optionalStorage);

        /// <summary>
        /// Initialize a new object
        /// </summary>
        /// <param name="baseObj">The object to initialize.Can be `NULL` so the result from `ATBaseNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        /// <remarks>ATSC_API ATBase *_Nullable ATBaseInit(ATBase *_Nullable base)</remarks>
        [DllImport(Constants.ATSC_API)]
        internal static extern ATBase ATBaseInit(ATBase baseObj);


        /// <summary>
        /// Copy an `ATBase` object
        /// </summary>
        /// <param name="destination">The destination storage to copy into</param>
        /// <param name="source">The source object to copy from</param>
        /// <returns>`true` if copying was successful. Will fail if either pointer is `NULL` or the type of the objects is not the same.</returns>
        /// <remarks>ATSC_API bool ATBaseCopy(ATBase* _Nonnull destination, ATBase const * _Nonnull source)</remarks>
        [DllImport(Constants.ATSC_API)]
        internal static extern bool ATBaseCopy(ATBase destination, ATBase source);
    }
}

/**
 

 @param destination 
 @param source 
 @return 
 */
//

