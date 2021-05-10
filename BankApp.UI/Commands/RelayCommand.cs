using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BankApp.UI.Commands
{
    public class RelayCommand : ICommand
    {
        Action<object> action;
        bool canExecute = true;

        public RelayCommand(Action<object> action)
        {
            this.action = action;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter) => canExecute;

        public void Execute(object parameter)
        {
            action?.Invoke(parameter);
        }
    }
}
