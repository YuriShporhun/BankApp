using BankApp.UI.ViewModels;
using System.Windows;

namespace BankApp
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainViewModel mainViewModel = new MainViewModel();
            MainWindow mainWindow = new MainWindow 
            { 
                DataContext = mainViewModel 
            };
            mainWindow.Show();
            base.OnStartup(e);
        }
    }
}
