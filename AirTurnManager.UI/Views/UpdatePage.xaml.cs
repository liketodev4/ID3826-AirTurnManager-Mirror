using System;

using AirTurnManager.UI.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AirTurnManager.UI.Views
{
    public sealed partial class UpdatePage : Page
    {
        public UpdateViewModel ViewModel { get; } = new UpdateViewModel();

        public UpdatePage()
        {
            InitializeComponent();
        }
    }
}
