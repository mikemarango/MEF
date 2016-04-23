using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.THREE.Services
{
    public interface ICustomerRepository
    {
        Customer GetByIdAsync(int id);
        List<Customer> GetAllAsync();
        void Update(Customer customer);
    }
}
