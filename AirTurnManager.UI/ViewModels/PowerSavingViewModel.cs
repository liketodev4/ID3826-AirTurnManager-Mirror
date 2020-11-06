using System;

using AirTurnManager.UI.Helpers;
using Windows.UI.Popups;

namespace AirTurnManager.UI.ViewModels
{
    public class PowerSavingViewModel : BaseViewModel
    {
        #region Private members

        private int _powerOffTimeout;

        #endregion

        #region Public members

        public int PowerOffTimeout
        {
            get { return _powerOffTimeout; }
            set { Set(ref _powerOffTimeout, value); }
        }

        #endregion
        public PowerSavingViewModel()
        {
            // temporary assign values
            _powerOffTimeout = 100;
        }

        #region Revert and Save parameters Methods

        public override async void RevertToDefaultParameters()
        {
            await new MessageDialog("PowerSaving RevertToDefaultParameters").ShowAsync();
        }

        public override async void RevertToSavedParameters()
        {
            await new MessageDialog("PowerSaving RevertToSavedParameters").ShowAsync();
        }

        public override async void DoneParameters()
        {
            await new MessageDialog("PowerSaving DoneParameters").ShowAsync();
        }

        #endregion
    }
}
