using MEF.THREE.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.THREE.ViewModels
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerListViewModel : ViewModelBase
    {
        [ImportingConstructor]
        public CustomerListViewModel(ICustomerRepository customerRepository)
        {
            _CustomersModel = customerRepository.GetAllAsync();
        }

        List<Customer> _CustomersModel;
        public List<Customer> CustomerModel { get { return _CustomersModel; } }
    }
}
