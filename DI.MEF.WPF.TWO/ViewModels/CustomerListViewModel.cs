using DI.MEF.WPF.TWO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.MEF.WPF.TWO.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerListViewModel : ViewModelBase
    {
        [ImportingConstructor]
        public CustomerListViewModel(ICustomerRepository customerRepository)
        {
            _CustomerModel = customerRepository.GetAll();
        }

        List<Customer> _CustomerModel;
        public List<Customer> CustomerModel
        {
            get { return _CustomerModel; }
        }
    }
}
