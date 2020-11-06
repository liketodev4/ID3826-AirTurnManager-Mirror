using System;

using AirTurnManager.UI.Helpers;
using Windows.UI.Popups;

namespace AirTurnManager.UI.ViewModels
{
    public class AdvancedViewModel : BaseViewModel
    {
        #region Private members

        private bool _isLowConnectionSpeed;
        private bool _isOpenPairingMethod;
        private int _debounceTime;
        private bool _isAirTurnOem;
        private string _otherOemString;

        #endregion

        #region Public members

        public bool IsLowConnectionSpeed
        {
            get { return _isLowConnectionSpeed; }
            set { Set(ref _isLowConnectionSpeed, value); }
        }

        public bool IsOpenPairingMethod
        {
            get { return _isOpenPairingMethod; }
            set { Set(ref _isOpenPairingMethod, value); }
        }

        public int DebounceTime
        {
            get { return _debounceTime; }
            set { Set(ref _debounceTime, value); }
        }

        public bool IsAirTurnOem
        {
            get { return _isAirTurnOem; }
            set { Set(ref _isAirTurnOem, value); }
        }

        public string OtherOemString
        {
            get { return _otherOemString; }
            set { Set(ref _otherOemString, value); }
        }

        #endregion

        public AdvancedViewModel()
        {
            // temporary assign values
            _isLowConnectionSpeed = false;
            _debounceTime = 50;
            _isAirTurnOem = true;
            _isOpenPairingMethod = false;
            _otherOemString = "oEm";
        }

        #region Revert and Save parameters Methods

        public override async void RevertToDefaultParameters()
        {
            await new MessageDialog("Advanced RevertToDefaultParameters").ShowAsync();
        }

        public override async void RevertToSavedParameters()
        {
            await new MessageDialog("Advanced RevertToSavedParameters").ShowAsync();
        }

        public override async void DoneParameters()
        {
            await new MessageDialog("Advanced DoneParameters").ShowAsync();
        }

        #endregion
    }
}
