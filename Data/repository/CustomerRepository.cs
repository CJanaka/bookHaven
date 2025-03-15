using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;

namespace BookHaven.Data.repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void Delete(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public Customer GetById(int customerId) => _context.Customers.Find(customerId);

        public List<Customer> GetAll() => _context.Customers.ToList();

        public List<Customer> SearchCustomers(string keyword)
        {
            return _context.Customers
                .Where(b => b.FirstName.Contains(keyword) || b.LastName.Contains(keyword) || b.Contact.Contains(keyword))
                .ToList();
        }
    }
}
