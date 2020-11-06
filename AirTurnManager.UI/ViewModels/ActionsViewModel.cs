using System;
using System.Windows.Input;
using AirTurnManager.UI.Helpers;
using Windows.UI.Popups;

namespace AirTurnManager.UI.ViewModels
{
    public class ActionsViewModel : BaseViewModel
    {
        public ActionsViewModel()
        {
        }

        #region Revert and Save parameters Methods

        public override async void RevertToDefaultParameters()
        {
            await new MessageDialog("Actions RevertToDefaultParameters").ShowAsync();
        }

        public override async void RevertToSavedParameters()
        {
            await new MessageDialog("Actions RevertToSavedParameters").ShowAsync();
        }

        public override async void DoneParameters()
        {
            await new MessageDialog("Actions DoneParameters").ShowAsync();
        }

        #endregion
    }
}
