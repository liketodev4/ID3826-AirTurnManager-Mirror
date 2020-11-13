using System;

using AirTurnManager.UI.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AirTurnManager.UI.Views
{
    public sealed partial class ConnectPage : Page
    {
        public ConnectViewModel ViewModel { get; } = new ConnectViewModel();

        public ConnectPage()
        {
            InitializeComponent();
        }
    }
}
