using BankApp.UI.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace BankApp.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        ViewModelBase currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => currentViewModel;
            set
            {
                currentViewModel = value;
                RaisePropertyChanged(nameof(CurrentViewModel));
            }
        }

        public MainViewModel()
        {
            CurrentViewModel = new LoginViewModel();
            InitCommands();
        }

        void InitCommands()
        {
            DragWindow = new RelayCommand(OnDragWindow);
            MaximizeWindow = new RelayCommand(OnMaximizeWindow);
            MinimizeWindow = new RelayCommand(OnMinimizeWindow);
            OpenCustomersWindow = new RelayCommand(OnOpenCustomersWindow);
        }

        private void OnOpenCustomersWindow(object obj)
        {
            CurrentViewModel = new CustomersViewModel();
        }

        private void OnMinimizeWindow(object mainWnd)
        {
            var window = mainWnd as MainWindow;
            window.WindowState = WindowState.Minimized;
        }

        void OnDragWindow(object mainWnd)
        {
            var window = mainWnd as MainWindow;
            window.DragMove();
        }

        void OnMaximizeWindow(object mainWnd)
        {
            var window = mainWnd as MainWindow;
            window.WindowState = WindowState.Maximized;
        }

        public ICommand DragWindow { get; private set; }
        public ICommand MaximizeWindow { get; private set; }
        public ICommand MinimizeWindow { get; private set; }
        public ICommand OpenCustomersWindow { get; private set; }

    }
}
