using System;

using AirTurnManager.UI.Helpers;
using Windows.UI.Popups;

namespace AirTurnManager.UI.ViewModels
{
    public class AdvancedViewModel : BaseViewModel
    {
        public AdvancedViewModel()
        {
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
