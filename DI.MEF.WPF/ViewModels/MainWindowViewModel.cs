using DI.MEF.WPF.Navigation;
using System;
using System.ComponentModel.Composition;
using System.Windows.Input;

namespace DI.MEF.WPF.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class MainWindowViewModel : ViewModelBase, IPartImportsSatisfiedNotification
    {
        public MainWindowViewModel()
        {
            ToggleViewCommand = new ToggleViewCommand(this);
        }

        [Import]
        CustomerViewModel _CustomerViewModel;

        [Import]
        CustomerListViewModel _CustomerListViewModel;

        ViewModelBase _CurrentViewModel;

        public ICommand ToggleViewCommand { get; private set; }


        //private ViewModelBase _CurrentViewModel = default(ViewModelBase);
        public ViewModelBase CurrentViewModel
        {
            get { return _CurrentViewModel; }
            set { NotifyPropertyChanged("CurrentViewModel"); }
        }

        internal void OnToggleViewCommand()
        {
            if (_CurrentViewModel.Equals(_CustomerListViewModel))
                CurrentViewModel = _CurrentViewModel;
            else
                CurrentViewModel = _CustomerListViewModel;
        }

        public void OnImportsSatisfied()
        {
            CurrentViewModel = _CustomerListViewModel;
        }
    }
}
