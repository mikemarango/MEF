using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.MEF.WPF.TWO.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Mikey Marango", Email = "mikey.marango@gmail.com", Twitter = "@mikey" },
                new Customer() { Id = 1, Name = "Mikey Marango", Email = "mikey.marango@gmail.com", Twitter = "@mikey" }
            };

            return customers;
        }

        public Customer GetById(int id)
        {
            List<Customer> customers = GetAll();
            return customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Update(Customer customer)
        {

        }
    }
}
