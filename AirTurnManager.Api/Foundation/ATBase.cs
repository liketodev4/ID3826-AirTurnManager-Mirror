using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

#region custom types

using uint8_t = System.Char;
using _ATBaseSignature = System.Byte;

#endregion

//#nullable enable

namespace AirTurnManager.Api.Foundation
{
    public struct ATBaseRef
    {

    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ATBaseStruct
    {
        /// A predefined static signature, the value is the same between all objects. Used to determine if a pointer is to an ATBase object or if an ATBase object has been corrupted.
        public _ATBaseSignature _signature;
        /// The retain count of the object. On creating a new object this is 1. Retaining the object increases the retain count, releasing decreases the count. When 0, object is free'd
        public uint8_t _retainCount;
        /// If the struct storage is owned by the object then it will be free'd when the retain count is 0
        public bool _ownsMemory;
        /// true if init has completed
        public bool _hasInitCompleted;
        /// The type of the object
        //[MarshalAs(UnmanagedType.U1)]
        public ATBase.ATObjectType _type;
    }


    public class ATBase
    {
        public static ATBaseStruct CreateATBaseStruct()
        {
            var atBaseStruct = new ATBaseStruct();
            //atBaseStruct._type = ATBase.ATObjectType.ATObjectTypeATBase;
            atBaseStruct._ownsMemory = true;
            atBaseStruct._hasInitCompleted = true;
            return atBaseStruct;
        }

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

        /// <summary>
        /// Create a new object
        /// </summary>
        /// <param name="optionalStorage">Optionally, a pointer to a struct or memory where the object can be stored</param>
        /// <returns>A pointer to the new object. `NULL` if allocation could not be completed</returns>
        /// <remarks>ATSC_API ATBase *_Nullable ATBaseNew(ATBase *_Nullable optionalStorage)</remarks>
        [DllImport(Constants.ATSC_API)]
        public static extern ATBaseStruct ATBaseNew(ref ATBaseStruct optionalStorage);

        /// <summary>
        /// Initialize a new object
        /// </summary>
        /// <param name="baseObj">The object to initialize.Can be `NULL` so the result from `ATBaseNew` can be passed directly, in which case it will simply return `NULL`</param>
        /// <returns>The initialized object or `NULL` if initialization failed</returns>
        /// <remarks>ATSC_API ATBase *_Nullable ATBaseInit(ATBase *_Nullable base)</remarks>
        [DllImport(Constants.ATSC_API)]
        public static extern ATBaseStruct ATBaseInit(ref ATBaseStruct baseObj);

        ///// <summary>
        ///// Copy an `ATBase` object
        ///// </summary>
        ///// <param name="destination">The destination storage to copy into</param>
        ///// <param name="source">The source object to copy from</param>
        ///// <returns>`true` if copying was successful. Will fail if either pointer is `NULL` or the type of the objects is not the same</returns>
        ///// <remarks>ATSC_API bool ATBaseCopy(ATBase* _Nonnull destination, ATBase const *_Nonnull source)</remarks>
        //[DllImport(Constants.ATSC_API)]
        //public static extern bool ATBaseCopy(ref ATBaseStruct destination, ref ATBaseStruct source);


        ////        /**
        ////         Retain an object for storage in your own code

        ////         @param object The object to retain, or NULL (for convenience)
        ////         @return The object, or NULL if the passed object was NULL or not an ATBase object
        ////         */
        ////        ATSC_API ATBaseRef _Nullable ATRetain(ATBaseRef _Nullable object);

        //[DllImport(Constants.ATSC_API)]
        //public static extern bool ATRetain(ATBaseStruct obj);



        //        /**
        // General object functions
        // */


        //        /**
        //         Release an object when you have finished using it in your own code

        //         @param object The object to release, or NULL (for convenience)
        //         @return Always NULL for convenience (e.g. storedVar = ATRelease(storedVar) to ensure storedVar is NULL and released)
        //         */
        //        ATSC_API ATBaseRef _Nullable ATRelease(ATBaseRef _Nullable object);

        //        /**
        //         Get the type of an object

        //         @param object The object
        //         @return The type of the object
        //         */
        //        ATSC_API ATObjectType ATGetType(ATBaseConstRef _Nonnull object);

        //        /**
        //         Get the current retain count of the object

        //         @param object The object
        //         @return The object's retain count
        //         */
        //        ATSC_API uint8_t ATGetRetainCount(ATBaseConstRef _Nonnull object);

        //        /**
        //         Determine if the object has been initialized and is ready to use

        //         @param object The object
        //         @return `true` if the object has been initiated
        //         */
        //        ATSC_API bool ATObjectIsInitialized(ATBaseConstRef _Nonnull object);

        //        /**
        //         Determine if an object is shared, i.e. it owns its memory and was not given storage to use during creation.
        //         @discussion If an object is shared you can depend on the object to exist throughout the duration of the application as long as its retain count is above 0. If it is not shared, the storage of the object may be free'd by the application elsewhere, or the storage may be removed from the stack.
        //         @param object The object
        //         @return `true` if the object is shared and owns its own memory
        //         */
        //        ATSC_API bool ATObjectIsShared(ATBaseConstRef _Nonnull object);

        //        /**
        //         A forward declaration of ATString so it can be used in these functions
        //         */
        //        struct ATString;

        //        /**
        //         Get a description for an object type

        //         @param type The object type
        //         @return A description of the type, or NULL if unknown type
        //         */
        //        ATSC_API const char* _Nullable ATGetDescriptionForType(ATObjectType type);

        //        /**
        //         Get a description for an object

        //         @param object The object
        //         @param string The string to populate with a description
        //         @return `true` if the object could be described successfully
        //         */
        //        ATSC_API bool ATGetDescription(ATBaseConstRef _Nonnull object, struct ATString *_Nonnull string);

        ///**
        // Get a debug description for an object

        // @param object The object
        // @param string The string to populate with a description
        // @return `true` if the object could be described successfully
        // */
        //ATSC_API bool ATGetDebugDescription(ATBaseConstRef _Nonnull object, struct ATString *_Nonnull string);

        ///**
        // Print a description of an object to stdout

        // @param object The object
        // */
        //ATSC_API void ATPrintDescription(ATBaseConstRef _Nonnull object);

        //        /**
        //         Print a debug description of an object to stdout

        //         @param object The object
        //         */
        //        ATSC_API void ATPrintDebugDescription(ATBaseConstRef _Nonnull object);


    }
}
