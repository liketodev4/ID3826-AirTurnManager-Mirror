using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Input;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace AirTurnManager.UI.Controls
{
    public sealed partial class ParametersActionsControl : UserControl
    {
        public ParametersActionsControl()
        {
            this.InitializeComponent();
        }

        public static DependencyProperty RevertToDefaultParametersProperty = DependencyProperty.Register(nameof(RevertToDefaultParametersCommand), typeof(ICommand), typeof(ParametersActionsControl), null);
        public static DependencyProperty RevertToSavedParametersProperty = DependencyProperty.Register(nameof(RevertToSavedParametersCommand), typeof(ICommand), typeof(ParametersActionsControl), null);
        public static DependencyProperty DoneParametersProperty = DependencyProperty.Register(nameof(DoneParametersCommand), typeof(ICommand), typeof(ParametersActionsControl), null);

        public ICommand RevertToDefaultParametersCommand
        {
            get => (ICommand)GetValue(RevertToDefaultParametersProperty);
            set => SetValue(RevertToDefaultParametersProperty, value);
        }

        public ICommand RevertToSavedParametersCommand
        {
            get => (ICommand)GetValue(RevertToSavedParametersProperty);
            set => SetValue(RevertToSavedParametersProperty, value);
        }

        public ICommand DoneParametersCommand
        {
            get => (ICommand)GetValue(DoneParametersProperty);
            set => SetValue(DoneParametersProperty, value);
        }
    }
}
