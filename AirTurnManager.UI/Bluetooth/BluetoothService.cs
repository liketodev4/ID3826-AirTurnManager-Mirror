using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using System.Diagnostics;
using Windows.Devices.Bluetooth;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp.Helpers;

namespace AirTurnManager.UI.Bluetooth
{
    public class BluetoothService
    {
        public ObservableCollection<BluetoothDevice> KnownBluetoothDevices = new ObservableCollection<BluetoothDevice>();
        public ObservableCollection<DeviceInformation> UnknownBluetoothDevices = new ObservableCollection<DeviceInformation>();

        private DeviceWatcher bluetoothDeviceWatcher;

        public void StartSearchingDevices()
        {
            // Additional properties we would like about the device.
            // Property strings are documented here https://msdn.microsoft.com/en-us/library/windows/desktop/ff521659(v=vs.85).aspx
            string[] requestedProperties = {
                "System.Devices.Aep.DeviceAddress",
                "System.Devices.Aep.IsConnected",
                "System.Devices.Aep.Bluetooth.Le.IsConnectable",
                "System.Devices.Aep.Bluetooth.LastSeenTime"};


            //System.Devices.Aep.Bluetooth.IssueInquiry
            //System.Devices.Aep.Bluetooth.LastSeenTime
            //System.Devices.Aep.Bluetooth.Le.IsConnectable
            //System.Devices.Aep.IsPaired
            //System.Devices.Aep.CanPair
            //System.Devices.Aep.IsConnected
            //System.Devices.Aep.IsPresent
            //System.Devices.Aep.ProtocolId

            // BT_Code: Example showing paired and non-paired in a single query.
            string aqsAllBluetoothLEDevices = "(System.Devices.Aep.ProtocolId:=\"{bb7bb05e-5972-42b5-94fc-76eaa7084d49}\")";

            bluetoothDeviceWatcher =
                DeviceInformation.CreateWatcher(
                        aqsAllBluetoothLEDevices,
                        requestedProperties,
                        DeviceInformationKind.AssociationEndpoint);

            // Register event handlers before starting the watcher.
            bluetoothDeviceWatcher.Added += BluetoothDeviceWatcher_AddedAsync;
            bluetoothDeviceWatcher.Updated += BluetoothDeviceWatcher_UpdatedAsync;
            bluetoothDeviceWatcher.Removed += BluetoothDeviceWatcher_RemovedAsync;
            bluetoothDeviceWatcher.EnumerationCompleted += BluetoothDeviceWatcher_EnumerationCompletedAsync;
            bluetoothDeviceWatcher.Stopped += BluetoothDeviceWatcher_StoppedAsync;

            // Start over with an empty collection.
            KnownBluetoothDevices.Clear();

            // Start the watcher. Active enumeration is limited to approximately 30 seconds.
            // This limits power usage and reduces interference with other Bluetooth activities.
            // To monitor for the presence of Bluetooth LE devices for an extended period,
            // use the BluetoothLEAdvertisementWatcher runtime class. See the BluetoothAdvertisement
            // sample for an example.
            bluetoothDeviceWatcher.Start();
        }

        public void StopSearchingDevices()
        {
            if (bluetoothDeviceWatcher != null)
            {
                // unegister event handlers
                bluetoothDeviceWatcher.Added += BluetoothDeviceWatcher_AddedAsync;
                bluetoothDeviceWatcher.Updated += BluetoothDeviceWatcher_UpdatedAsync;
                bluetoothDeviceWatcher.Removed += BluetoothDeviceWatcher_RemovedAsync;
                bluetoothDeviceWatcher.EnumerationCompleted += BluetoothDeviceWatcher_EnumerationCompletedAsync;
                bluetoothDeviceWatcher.Stopped += BluetoothDeviceWatcher_StoppedAsync;

                bluetoothDeviceWatcher.Stop();
                bluetoothDeviceWatcher = null;
            }
        }
        private async void BluetoothDeviceWatcher_StoppedAsync(DeviceWatcher sender, object args)
        {
            await DispatcherHelper.ExecuteOnUIThreadAsync(() =>
            {
                KnownBluetoothDevices.Clear();
            });
        }

        private async void BluetoothDeviceWatcher_EnumerationCompletedAsync(DeviceWatcher sender, object args)
        {
            await DispatcherHelper.ExecuteOnUIThreadAsync(() =>
            {
                // Protect against race condition if the task runs after the app stopped the deviceWatcher.
                if (sender == bluetoothDeviceWatcher)
                {
                    // Enumeration completed.
                }
            });
        }

        private async void BluetoothDeviceWatcher_RemovedAsync(DeviceWatcher sender, DeviceInformationUpdate deviceInfoUpdate)
        {
            // We must update the collection on the UI thread because the collection is databound to a UI element.
            // use Microsoft.Toolkit.Uwp.Helpers extensions
            await DispatcherHelper.ExecuteOnUIThreadAsync(() =>
            {
                // Code to execute on main window's UI thread
                // Protect against race condition if the task runs after the app stopped the deviceWatcher.
                if (sender == bluetoothDeviceWatcher)
                {
                    // Find the corresponding DeviceInformation in the collection and remove it.
                    var bluetoothDevice = FindKnownBluetoothDevice(deviceInfoUpdate.Id);
                    if (bluetoothDevice != null)
                    {
                        KnownBluetoothDevices.Remove(bluetoothDevice);
                    }

                    var deviceInfo = FindUnknownBluetoothDevice(deviceInfoUpdate.Id);
                    if (deviceInfo != null)
                    {
                        UnknownBluetoothDevices.Remove(deviceInfo);
                    }
                }
            });
        }

        private async void BluetoothDeviceWatcher_UpdatedAsync(DeviceWatcher sender, DeviceInformationUpdate deviceInfoUpdate)
        {
            // We must update the collection on the UI thread because the collection is databound to a UI element.
            // use Microsoft.Toolkit.Uwp.Helpers extensions
            await DispatcherHelper.ExecuteOnUIThreadAsync(() =>
            {
                // Protect against race condition if the task runs after the app stopped the deviceWatcher.
                if (sender == bluetoothDeviceWatcher)
                {
                    var bluetoothDevice = FindKnownBluetoothDevice(deviceInfoUpdate.Id);
                    if (bluetoothDevice != null)
                    {
                        // Device is already being displayed - update UI.
                        bluetoothDevice.Update(deviceInfoUpdate);
                        return;
                    }

                    DeviceInformation deviceInfo = FindUnknownBluetoothDevice(deviceInfoUpdate.Id);
                    if (deviceInfo != null)
                    {
                        deviceInfo.Update(deviceInfoUpdate);
                        // If device has been updated with a friendly name it's no longer unknown.
                        if (deviceInfo.Name != String.Empty)
                        {
                            KnownBluetoothDevices.Add(new BluetoothDevice(deviceInfo));
                            UnknownBluetoothDevices.Remove(deviceInfo);
                        }
                    }
                }
            });
        }

        private async void BluetoothDeviceWatcher_AddedAsync(DeviceWatcher sender, DeviceInformation deviceInfo)
        {
            // We must update the collection on the UI thread because the collection is databound to a UI element.
            // use Microsoft.Toolkit.Uwp.Helpers extensions
            await DispatcherHelper.ExecuteOnUIThreadAsync(() =>
            {
                // Protect against race condition if the task runs after the app stopped the deviceWatcher.
                if (sender == bluetoothDeviceWatcher)
                {
                    // Make sure device isn't already present in the list.
                    if (FindKnownBluetoothDevice(deviceInfo.Id) == null)
                    {
                        if (deviceInfo.Name != string.Empty)
                        {
                            // If device has a friendly name display it immediately.
                            KnownBluetoothDevices.Add(new BluetoothDevice(deviceInfo));
                        }
                        else
                        {
                            // Add it to a list in case the name gets updated later. 
                            UnknownBluetoothDevices.Add(deviceInfo);
                        }
                    }
                }
            });
        }

        private BluetoothDevice FindKnownBluetoothDevice(string id)
        {
            foreach (BluetoothDevice bluetoothDevice in KnownBluetoothDevices)
            {
                if (bluetoothDevice.Id == id)
                {
                    return bluetoothDevice;
                }
            }
            return null;
        }

        private DeviceInformation FindUnknownBluetoothDevice(string id)
        {
            foreach (DeviceInformation bluetoothDeviceInfo in UnknownBluetoothDevices)
            {
                if (bluetoothDeviceInfo.Id == id)
                {
                    return bluetoothDeviceInfo;
                }
            }
            return null;
        }
    }
}
