using AirTurnManager.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.UI.Xaml.Media.Imaging;

namespace AirTurnManager.UI.Bluetooth
{
    public class BluetoothDevice : Observable
    {
        public BluetoothDevice(DeviceInformation deviceInformation)
        {
            DeviceInformation = deviceInformation;
        }

        public DeviceInformation DeviceInformation { get; private set; }

        public string Id => DeviceInformation.Id;
        public string Name => DeviceInformation.Name;
        public bool IsPaired => DeviceInformation.Pairing.IsPaired;
        public bool IsConnected => (bool?)DeviceInformation.Properties["System.Devices.Aep.IsConnected"] == true;
        public bool IsConnectable => (bool?)DeviceInformation.Properties["System.Devices.Aep.Bluetooth.Le.IsConnectable"] == true;
        public string Address => (string)DeviceInformation.Properties["System.Devices.Aep.DeviceAddress"];
        public string LastSeenTime => ((DateTimeOffset)DeviceInformation.Properties["System.Devices.Aep.Bluetooth.LastSeenTime"]).UtcDateTime.ToString();

        //if (DeviceInfo.Properties.ContainsKey("System.Devices.Aep.Bluetooth.LastSeenTime") && (DeviceInfo.Properties["System.Devices.Aep.Bluetooth.LastSeenTime"] != null))
        //        {
        //            LastSeenTime = ((System.DateTimeOffset) DeviceInfo.Properties["System.Devices.Aep.Bluetooth.LastSeenTime"]).UtcDateTime;
        //        }

        //        if (DeviceInfo.Properties.ContainsKey("System.Devices.Aep.SignalStrength") && (DeviceInfo.Properties["System.Devices.Aep.SignalStrength"] != null))
        //        {
        //            RSSI = (int) DeviceInfo.Properties["System.Devices.Aep.SignalStrength"];


        public void Update(DeviceInformationUpdate deviceInfoUpdate)
        {
            DeviceInformation.Update(deviceInfoUpdate);
            OnPropertyChanged(nameof(Id));
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(IsPaired));
            OnPropertyChanged(nameof(IsConnected));
            OnPropertyChanged(nameof(IsConnectable));
            OnPropertyChanged(nameof(Address));
            OnPropertyChanged(nameof(LastSeenTime));
        }
        //public IReadOnlyDictionary<string, object> Properties => DeviceInformation.Properties;
        //public BitmapImage GlyphBitmapImage { get; private set; }

    }
}
