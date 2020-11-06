using System;

using AirTurnManager.UI.Helpers;
using Windows.UI.Popups;

namespace AirTurnManager.UI.ViewModels
{
    public class KeyRepeatViewModel : BaseViewModel
    {
        public KeyRepeatViewModel()
        {
        }

        #region Revert and Save parameters Methods

        public override async void RevertToDefaultParameters()
        {
            await new MessageDialog("KeyRepeat RevertToDefaultParameters").ShowAsync();
        }

        public override async void RevertToSavedParameters()
        {
            await new MessageDialog("KeyRepeat RevertToSavedParameters").ShowAsync();
        }

        public override async void DoneParameters()
        {
            await new MessageDialog("KeyRepeat DoneParameters").ShowAsync();
        }

        #endregion
    }
}
