using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;

namespace BookHaven.Data.repository
{
    public interface ICustomerRepository
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int customerId);
        Customer GetById(int customerId);
        List<Customer> GetAll();
        List<Customer> SearchCustomers(string keyword);
    }
}
