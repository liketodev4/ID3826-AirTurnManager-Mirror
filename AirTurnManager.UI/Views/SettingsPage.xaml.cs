using System;

using AirTurnManager.UI.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AirTurnManager.UI.Views
{
    public sealed partial class SettingsPage : Page
    {
        // TODO Change the URL for your privacy policy in the Resource File.
        public SettingsViewModel ViewModel { get; } = new SettingsViewModel();

        public SettingsPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            await ViewModel.InitializeAsync();
        }
    }
}
