using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BankApp.UI.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; }

        public MainViewModel()
        {
            CurrentViewModel = new LoginViewModel();
        }

    }
}
