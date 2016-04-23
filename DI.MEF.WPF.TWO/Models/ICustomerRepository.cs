using System.Collections.Generic;

namespace DI.MEF.WPF.TWO.Models
{
    public interface ICustomerRepository
    {
        Customer GetById(int id);
        List<Customer> GetAll();
        void Update(Customer customer);
    }
}