﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api.DeviceTypes
{
    public enum ATInputType : byte
    {
        //AirTurn has 'port' inputs. Examples include older keyboard only devices and unknown devices.
        ATInputTypePort = 0,
        //AirTurn has dual 'pedal' inputs. Examples include PEDpro. 
        ATInputTypeDualPedal = 1,
        //AirTurn has many 'pedal' inputs. Examples include QUAD200.
        ATInputTypeManyPedal = 2,
        //AirTurn has 'switch' inputs. Examples include BT200S-2
        ATInputTypeSwitch = 3,
        //AirTurn has 'button' inputs. Examples include DIGITIII
        ATInputTypeButton = 4,
        //AirTurn has both 'ports' and directional pad inputs. Examples include BT200
        ATInputTypePortsAndPad = 5
    }

    public unsafe partial class ATInputTypeUnsafe
    {
        public partial struct _Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport(Constants.ATSC_API, CallingConvention = CallingConvention.Cdecl,
                EntryPoint = "ATInputTypeFromModelID")]
            internal static extern DeviceTypes.ATInputType ATInputTypeFromModelID(DeviceTypes.ATModelID modelID);
        }

        public static DeviceTypes.ATInputType ATInputTypeFromModelID(DeviceTypes.ATModelID modelID)
        {
            var _ret = _Internal.ATInputTypeFromModelID(modelID);
            return _ret;
        }
    }
}
