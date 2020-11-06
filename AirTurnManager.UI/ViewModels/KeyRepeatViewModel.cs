using System;

using AirTurnManager.UI.Helpers;
using Windows.UI.Popups;

namespace AirTurnManager.UI.ViewModels
{
    public class KeyRepeatViewModel : BaseViewModel
    {
        #region Private members

        private bool _isAirTurnRepeat;
        private int _delayBeforeKeyRepeat;
        private int _keyRepeatRate;

        #endregion

        #region Public members

        public bool IsAirTurnRepeat
        {
            get { return _isAirTurnRepeat; }
            set { Set(ref _isAirTurnRepeat, value); }
        }

        public int DelayBeforeKeyRepeat
        {
            get { return _delayBeforeKeyRepeat; }
            set { Set(ref _delayBeforeKeyRepeat, value); }
        }

        public int KeyRepeatRate
        {
            get { return _keyRepeatRate; }
            set { Set(ref _keyRepeatRate, value); }
        }

        #endregion

        public KeyRepeatViewModel()
        {
            // temporary assign values
            _isAirTurnRepeat = false;
            _delayBeforeKeyRepeat = 10;
            _keyRepeatRate = 50;
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
