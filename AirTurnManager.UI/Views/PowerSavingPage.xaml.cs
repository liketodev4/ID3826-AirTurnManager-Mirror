using System;

using AirTurnManager.UI.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AirTurnManager.UI.Views
{
    public sealed partial class PowerSavingPage : Page
    {
        public PowerSavingViewModel ViewModel { get; } = new PowerSavingViewModel();

        public PowerSavingPage()
        {
            InitializeComponent();
        }
    }
}
