using System;
using AirTurnManager.UI.Bluetooth;
using AirTurnManager.UI.Helpers;
using AirTurnManager.UI.Services;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.UI.Core;

namespace AirTurnManager.UI.ViewModels
{
    public class ConnectViewModel : BaseViewModel
    {
        public BluetoothService bluetoothService;

        public ConnectViewModel()
        {
            
            bluetoothService = new BluetoothService();
            bluetoothService.StartSearchingDevices();

        }

        
    }
}
