using System.Collections.Generic;
using System.Linq;
using DI.MEF.WPF.Models;
using System.ComponentModel.Composition;

namespace DI.MEF.WPF.Services
{
    [Export(typeof(ICustomerRepository))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetAll()
        {
            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Mike M Marango", Email = "mike.marango@gmail.com", Twitter = "@marango" },
                new Customer() { Id = 1, Name = "Eunice M Marango", Email = "eunice.marango@gmail.com", Twitter = "@eunice" }
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
