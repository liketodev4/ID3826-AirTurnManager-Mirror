using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
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

        #region Connect to device command

        private ICommand _connectDeviceCommand;

        public ICommand ConnectDeviceCommand => _connectDeviceCommand ?? (_connectDeviceCommand = new RelayCommand<string>(ConnectDeviceEvent, CanExecuteConnectDeviceEvent));

        private bool CanExecuteConnectDeviceEvent(string deviceId)
        {
            // create condition whether the device is available for connection
            return true;
        }

        private void ConnectDeviceEvent(string deviceId)
        {
            // do conect to device
            var param = deviceId;
        }

        #endregion
    }
}
