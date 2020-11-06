using AirTurnManager.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace AirTurnManager.UI.ViewModels
{
    public abstract class BaseViewModel : Observable
    {
        private ICommand _revertToDefaultParametersCommand;
        private ICommand _revertToSavedParametersCommand;
        private ICommand _doneParametersCommand;

        public ICommand RevertToDefaultParametersCommand => _revertToDefaultParametersCommand ?? (_revertToDefaultParametersCommand = new RelayCommand(RevertToDefaultParameters));
        public ICommand RevertToSavedParametersCommand => _revertToSavedParametersCommand ?? (_revertToSavedParametersCommand = new RelayCommand(RevertToSavedParameters));
        public ICommand DoneParametersCommand => _doneParametersCommand ?? (_doneParametersCommand = new RelayCommand(DoneParameters));

        #region Methods for Commands

        public virtual async void RevertToDefaultParameters()
        {
            await new MessageDialog("Need to override this method - RevertToDefaultSettings").ShowAsync();
            throw new Exception("");
        }

        public virtual async void RevertToSavedParameters()
        {
            await new MessageDialog("Need to override this method - RevertToSavedSettings").ShowAsync();
            throw new Exception("");
        }

        public virtual async void DoneParameters()
        {
            await new MessageDialog("Need to override this method - DoneSettings").ShowAsync();
            throw new Exception("");
        }

        #endregion 
    }
}
