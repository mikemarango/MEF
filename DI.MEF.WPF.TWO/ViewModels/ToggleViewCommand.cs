using System;
using System.Windows.Input;

namespace DI.MEF.WPF.TWO.ViewModels
{
    public class ToggleViewCommand : ICommand
    {
        public ToggleViewCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }

        MainWindowViewModel mainWindowViewModel;

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainWindowViewModel.OnToggleViewCommand();
        }
    }
}
