using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF.THREE.Services
{
    [Export(typeof(ICustomerRepository))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerRespository : ICustomerRepository
    {
        public List<Customer> GetAllAsync()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Mikey Marash", Email = "mikey@marango@gmail.com", Twitter = "@mikey" },
                new Customer() { Id = 1, Name = "Mikey Marash", Email = "mikey@marango@gmail.com", Twitter = "@mikey" }
            };

            return customers;
        }

        public Customer GetByIdAsync(int id)
        {
            List<Customer> customers = GetAllAsync();
            return customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Update(Customer customer)
        {
        }
    }
}
