using System.ComponentModel.Composition;
using System.Windows.Input;

namespace DI.MEF.WPF.TWO.ViewModels
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
        CustomerListViewModel customerListViewModel;

        [Import]
        CustomerViewModel customerViewModel;
        
        public ICommand ToggleViewCommand { get; private set; }

        ViewModelBase currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get { return currentViewModel; }
            set { currentViewModel = value; NotifyPropertyChanged("CurrentViewModel"); }
        }

        public void OnImportsSatisfied()
        {
            CurrentViewModel = customerListViewModel;
        }

        internal void OnToggleViewCommand()
        {
            if (customerListViewModel.Equals(customerListViewModel))
            {
                CurrentViewModel = customerViewModel;
            }

            else
            {
                CurrentViewModel = customerListViewModel;
            }
        }
    }
}
