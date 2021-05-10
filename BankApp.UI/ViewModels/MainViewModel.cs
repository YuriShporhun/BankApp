using BankApp.UI.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Input;

namespace BankApp.UI.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel()
        {
            CurrentViewModel = new LoginViewModel();
            InitCommands();
        }

        void InitCommands()
        {
            DragWindow = new RelayCommand(OnDragWindow);
        }

        void OnDragWindow(object mainWnd)
        {
            var window = mainWnd as MainWindow;
            window.DragMove();
        }

        public ICommand DragWindow { get; set; }


    }
}
