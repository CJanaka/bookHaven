using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using BookHaven.Data.repository;

namespace BookHaven.Business.services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepo;

        public CustomerService(ICustomerRepository customerRepo)
        {
            _customerRepo = customerRepo;
        }

        public void AddCustomer(Customer customer) => _customerRepo.Add(customer);
        public void UpdateCustomer(Customer customer) => _customerRepo.Update(customer);
        public void DeleteCustomer(int customerId) => _customerRepo.Delete(customerId);
        public Customer GetCustomerById(int customerId) => _customerRepo.GetById(customerId);
        public List<Customer> GetAllCustomers() => _customerRepo.GetAll();
        public List<Customer> SearchCustomers(string keyword) => _customerRepo.SearchCustomers(keyword);
    }
}
