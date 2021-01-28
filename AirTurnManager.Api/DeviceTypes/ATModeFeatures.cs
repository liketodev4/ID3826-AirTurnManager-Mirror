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
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesValidate")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeFeaturesValidate(ushort modeFeatures);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesParseData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeFeaturesParseData(IntPtr data, ushort* modeFeatures);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesGetData")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeFeaturesGetData(IntPtr data, ushort modeFeatures);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesParseDataMultiple")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeFeaturesParseDataMultiple(IntPtr data, ushort* modeFeatures, byte maxCount, byte* numParsed);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesGetDataMultiple")]
            [return: MarshalAs(UnmanagedType.I1)]
            internal static extern bool ATModeFeaturesGetDataMultiple(IntPtr data, ushort* modeFeatures, byte count);

            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATModeFeaturesDescription")]
            internal static extern void ATModeFeaturesDescription(IntPtr @string, ushort modeFeatures);
        }

        /// <summary>Validate a mode features value</summary>
        /// <param name="modeFeatures">The mode features value to validate</param>
        /// <returns>`true` if valid</returns>
        public static bool ATModeFeaturesValidate(ushort modeFeatures)
        {
            var _ret = _Internal.ATModeFeaturesValidate(modeFeatures);
            return _ret;
        }

        /// <summary>Get a mode features value from data</summary>
        /// <param name="data">The data</param>
        /// <param name="modeFeatures">On return, contains the mode features value</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeFeaturesParseData(DeviceTypes.ATBytes data, ref ushort modeFeatures)
        {
            if (ReferenceEquals(data, null))
                throw new ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            fixed (ushort* _modeFeatures1 = &modeFeatures)
            {
                var _arg1 = _modeFeatures1;
                var _ret = _Internal.ATModeFeaturesParseData(_arg0, _arg1);
                return _ret;
            }
        }

        /// <summary>Get the data for a mode features value</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="modeFeatures">The mode features value to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeFeaturesGetData(DeviceTypes.ATMutableBytes data, ushort modeFeatures)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            var _ret = _Internal.ATModeFeaturesGetData(_arg0, modeFeatures);
            return _ret;
        }

        /// <summary>Get a mode features values from data. Will parse maxCount mode features</summary>
        /// <param name="data">The data</param>
        /// <param name="modeFeatures">On return, contains the mode features values</param>
        /// <param name="maxCount">The max num of mode features that will be parsed into modeFeatures</param>
        /// <param name="numParsed">On return, set to the number of mode features parsed</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeFeaturesParseDataMultiple(DeviceTypes.ATBytes data, ref ushort modeFeatures, byte maxCount, byte* numParsed)
        {
            if (ReferenceEquals(data, null))
                throw new ArgumentNullException("data", "Cannot be null because it is passed by value.");
            var _arg0 = data._Instance;
            fixed (ushort* _modeFeatures1 = &modeFeatures)
            {
                var _arg1 = _modeFeatures1;
                var _ret = _Internal.ATModeFeaturesParseDataMultiple(_arg0, _arg1, maxCount, numParsed);
                return _ret;
            }
        }

        /// <summary>Get the data for a mode features values</summary>
        /// <param name="data">Will be populated with the data</param>
        /// <param name="modeFeatures">The mode features values to encode</param>
        /// <param name="count">The number of mode features to encode</param>
        /// <returns>`true` if successful</returns>
        public static bool ATModeFeaturesGetDataMultiple(DeviceTypes.ATMutableBytes data, ref ushort modeFeatures, byte count)
        {
            var _arg0 = ReferenceEquals(data, null) ? IntPtr.Zero : data._Instance;
            fixed (ushort* _modeFeatures1 = &modeFeatures)
            {
                var _arg1 = _modeFeatures1;
                var _ret = _Internal.ATModeFeaturesGetDataMultiple(_arg0, _arg1, count);
                return _ret;
            }
        }

        /// <summary>Get a description for a mode features value</summary>
        /// <param name="string">The string to append the description to</param>
        /// <param name="modeFeatures">The mode features value</param>
        public static void ATModeFeaturesDescription(DeviceTypes.ATString @string, ushort modeFeatures)
        {
            var _arg0 = ReferenceEquals(@string, null) ? IntPtr.Zero : @string._Instance;
            _Internal.ATModeFeaturesDescription(_arg0, modeFeatures);
        }
    }
}
