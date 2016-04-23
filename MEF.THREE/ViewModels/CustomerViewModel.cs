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
    public class CustomerViewModel : ViewModelBase
    {
        [ImportingConstructor]
        public CustomerViewModel(ICustomerRepository customerRepository)
        {
            _CustomerModel = customerRepository.GetByIdAsync(1);
        }

        Customer _CustomerModel;
        public Customer CustomerModel { get { return _CustomerModel; } }
    }
}
