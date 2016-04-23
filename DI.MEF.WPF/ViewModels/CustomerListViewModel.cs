using DI.MEF.WPF.Models;
using DI.MEF.WPF.Services;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace DI.MEF.WPF.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerListViewModel : ViewModelBase
    {
        public CustomerListViewModel(ICustomerRepository customerRepository)
        {
            _CustomerModel = customerRepository.GetAll();
        }


        private List<Customer> _CustomerModel;
        public List<Customer> CustomerModel
        {
            get { return _CustomerModel; }
        }
    }
}
