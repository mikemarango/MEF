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
    public class CustomerViewModel : ViewModelBase
    {
        [ImportingConstructor]
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
