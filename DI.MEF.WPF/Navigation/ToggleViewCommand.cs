using DI.MEF.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DI.MEF.WPF.Navigation
{
    public class ToggleViewCommand : ICommand
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
