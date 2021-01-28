using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTurnManager.Api
{
    public static class DataTypesConvert
    {
        public static ushort ATSwapInt16(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16(arg);
            return _ret;
        }

        public static uint ATSwapInt32(uint arg)
        {
            var _ret = _Internal.ATSwapInt32(arg);
            return _ret;
        }

        public static ulong ATSwapInt64(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64(arg);
            return _ret;
        }

        public static ushort ATSwapInt16BigToHost(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16BigToHost(arg);
            return _ret;
        }

        public static uint ATSwapInt32BigToHost(uint arg)
        {
            var _ret = _Internal.ATSwapInt32BigToHost(arg);
            return _ret;
        }

        public static ulong ATSwapInt64BigToHost(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64BigToHost(arg);
            return _ret;
        }

        public static ushort ATSwapInt16HostToBig(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16HostToBig(arg);
            return _ret;
        }

        public static uint ATSwapInt32HostToBig(uint arg)
        {
            var _ret = _Internal.ATSwapInt32HostToBig(arg);
            return _ret;
        }

        public static ulong ATSwapInt64HostToBig(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64HostToBig(arg);
            return _ret;
        }

        public static ushort ATSwapInt16LittleToHost(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16LittleToHost(arg);
            return _ret;
        }

        public static uint ATSwapInt32LittleToHost(uint arg)
        {
            var _ret = _Internal.ATSwapInt32LittleToHost(arg);
            return _ret;
        }

        public static ulong ATSwapInt64LittleToHost(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64LittleToHost(arg);
            return _ret;
        }

        public static ushort ATSwapInt16HostToLittle(ushort arg)
        {
            var _ret = _Internal.ATSwapInt16HostToLittle(arg);
            return _ret;
        }

        public static uint ATSwapInt32HostToLittle(uint arg)
        {
            var _ret = _Internal.ATSwapInt32HostToLittle(arg);
            return _ret;
        }

        public static ulong ATSwapInt64HostToLittle(ulong arg)
        {
            var _ret = _Internal.ATSwapInt64HostToLittle(arg);
            return _ret;
        }

        public static DeviceDefaults.ATSwappedFloat32 ATConvertFloatHostToSwapped(float arg)
        {
            var _ret = _Internal.ATConvertFloatHostToSwapped(arg);
            return DeviceDefaults.ATSwappedFloat32._CreateInstance(_ret);
        }

        public static float ATConvertFloatSwappedToHost(DeviceDefaults.ATSwappedFloat32 arg)
        {
            if (ReferenceEquals(arg, null))
                throw new ArgumentNullException("arg", "Cannot be null because it is passed by value.");
            var _arg0 = arg._Instance;
            var _ret = _Internal.ATConvertFloatSwappedToHost(*(DeviceDefaults.ATSwappedFloat32._Internal*)_arg0);
            return _ret;
        }

        public static DeviceDefaults.ATSwappedFloat64 ATConvertDoubleHostToSwapped(double arg)
        {
            var _ret = _Internal.ATConvertDoubleHostToSwapped(arg);
            return DeviceDefaults.ATSwappedFloat64._CreateInstance(_ret);
        }

        public static double ATConvertDoubleSwappedToHost(DeviceDefaults.ATSwappedFloat64 arg)
        {
            if (ReferenceEquals(arg, null))
                throw new ArgumentNullException("arg", "Cannot be null because it is passed by value.");
            var _arg0 = arg._Instance;
            var _ret = _Internal.ATConvertDoubleSwappedToHost(*(DeviceDefaults.ATSwappedFloat64._Internal*)_arg0);
            return _ret;
        }
    }
}
