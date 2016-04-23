using System;
using System.Windows.Input;

namespace MEF.THREE.ViewModels
{
    internal class ToggleViewCommand : ICommand
    {
        private MainWindowViewModel mainWindowViewModel;

        public ToggleViewCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.mainWindowViewModel = mainWindowViewModel;
        }

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