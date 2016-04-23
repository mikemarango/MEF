using DI.MEF.WPF.Models;
using DI.MEF.WPF.Services;
using System.ComponentModel.Composition;

namespace DI.MEF.WPF.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    class CustomerViewModel : ViewModelBase
    {
        public CustomerViewModel(ICustomerRepository customerRepository)
        {
            _CustomerModel = customerRepository.GetById(1);
        }


        private Customer _CustomerModel = default(Customer);
        public Customer CustomerModel
        {
            get { return _CustomerModel; }
        }
    }
}
