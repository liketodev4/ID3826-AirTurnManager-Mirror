using System;

using AirTurnManager.UI.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AirTurnManager.UI.Views
{
    public sealed partial class KeyRepeatPage : Page
    {
        public KeyRepeatViewModel ViewModel { get; } = new KeyRepeatViewModel();

        public KeyRepeatPage()
        {
            InitializeComponent();
        }
    }
}
