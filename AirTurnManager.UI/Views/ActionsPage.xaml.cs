using System;

using AirTurnManager.UI.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AirTurnManager.UI.Views
{
    public sealed partial class ActionsPage : Page
    {
        public ActionsViewModel ViewModel { get; } = new ActionsViewModel();

        public ActionsPage()
        {
            InitializeComponent();
        }
    }
}
