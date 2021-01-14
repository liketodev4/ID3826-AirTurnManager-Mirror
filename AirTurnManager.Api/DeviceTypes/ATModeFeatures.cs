using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATModeFeatures : ushort
    {
        ATModeFeaturesDigitalPortConfig = 1,
        ATModeFeaturesAnalogPortConfig = 2,
        ATModeFeaturesProprietary = 4,
        ATModeFeaturesKeyboard = 8,
        ATModeFeaturesConsumer = 16,
        ATModeFeaturesMouse = 32,
        ATModeFeaturesJoystick = 64,
        ATModeFeaturesMIDI = 128,
        ATModeFeaturesMaskHID = 120,
        ATModeFeaturesMaskRequiresPairing = 120,
        ATModeFeaturesMaskAll = 255
    }

    public unsafe partial class ATModeFeaturesUnsafe
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeFeaturesValidate(ushort modeFeatures);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeFeaturesParseData(global::System.IntPtr data, ushort* modeFeatures);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeFeaturesGetData(global::System.IntPtr data, ushort modeFeatures);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesParseDataMultiple")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeFeaturesParseDataMultiple(global::System.IntPtr data, ushort* modeFeatures, byte maxCount, byte* numParsed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesGetDataMultiple")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeFeaturesGetDataMultiple(global::System.IntPtr data, ushort* modeFeatures, byte count);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("AirTurnManager.Api.DeviceTypes.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesDescription")]
            internal static extern void ATModeFeaturesDescription(global::System.IntPtr @string, ushort modeFeatures);
        }

        /// <summary>Validate a mode features value</summary>
        /// <param name="modeFeatures">The mode features value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATModeFeaturesValidate(ushort modeFeatures)
        {
            var __ret = __Internal.ATModeFeaturesValidate(modeFeatures);
            return __ret;
        }

        /// <summary>Get a mode features value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="modeFeatures">On return, contains the mode features value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeFeaturesParseData(global::AirTurnManager.Api.DeviceTypes.ATBytes data, ref ushort modeFeatures)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var __arg0 = data.__Instance;
            fixed (ushort* __modeFeatures1 = &modeFeatures)
            {
                var __arg1 = __modeFeatures1;
                var __ret = __Internal.ATModeFeaturesParseData(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get the data for a mode features value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="modeFeatures">The mode features value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeFeaturesGetData(global::AirTurnManager.Api.DeviceTypes.ATMutableBytes data, ushort modeFeatures)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            var __ret = __Internal.ATModeFeaturesGetData(__arg0, modeFeatures);
            return __ret;
        }

        /// <summary>Get a mode features values from data. Will parse maxCount mode features</summary>
        /// <param name="data">The data</param>
        /// <param name="modeFeatures">On return, contains the mode features values</param>
        /// <param name="maxCount">The max num of mode features that will be parsed into modeFeatures</param>
        /// <param name="numParsed">On return, set to the number of mode features parsed</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeFeaturesParseDataMultiple(global::AirTurnManager.Api.DeviceTypes.ATBytes data, ref ushort modeFeatures, byte maxCount, byte* numParsed)
        {
            if (ReferenceEquals(data, null))
                throw new global::System.ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var __arg0 = data.__Instance;
            fixed (ushort* __modeFeatures1 = &modeFeatures)
            {
                var __arg1 = __modeFeatures1;
                var __ret = __Internal.ATModeFeaturesParseDataMultiple(__arg0, __arg1, maxCount, numParsed);
                return __ret;
            }
        }

        /// <summary>Get the data for a mode features values</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="modeFeatures">The mode features values to encode</param>
        /// <param name="count">The number of mode features to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeFeaturesGetDataMultiple(global::AirTurnManager.Api.DeviceTypes.ATMutableBytes data, ref ushort modeFeatures, byte count)
        {
            var __arg0 = ReferenceEquals(data, null) ? global::System.IntPtr.Zero : data.__Instance;
            fixed (ushort* __modeFeatures1 = &modeFeatures)
            {
                var __arg1 = __modeFeatures1;
                var __ret = __Internal.ATModeFeaturesGetDataMultiple(__arg0, __arg1, count);
                return __ret;
            }
        }

        /// <summary>Get a description for a mode features value</summary>
        /// <param name="string">The string to append the description to</param>
        /// <param name="modeFeatures">The mode features value</param>
        public static void ATModeFeaturesDescription(global::AirTurnManager.Api.DeviceTypes.ATString @string, ushort modeFeatures)
        {
            var __arg0 = ReferenceEquals(@string, null) ? global::System.IntPtr.Zero : @string.__Instance;
            __Internal.ATModeFeaturesDescription(__arg0, modeFeatures);
        }
    }
}
