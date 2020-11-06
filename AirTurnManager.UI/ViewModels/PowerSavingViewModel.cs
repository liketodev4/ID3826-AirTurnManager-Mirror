using System;

using AirTurnManager.UI.Helpers;
using Windows.UI.Popups;

namespace AirTurnManager.UI.ViewModels
{
    public class PowerSavingViewModel : BaseViewModel
    {
        public PowerSavingViewModel()
        {
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
