using System;

using AirTurnManager.UI.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AirTurnManager.UI.Views
{
    public sealed partial class AdvancedPage : Page
    {
        public AdvancedViewModel ViewModel { get; } = new AdvancedViewModel();

        public AdvancedPage()
        {
            InitializeComponent();
        }
    }
}
