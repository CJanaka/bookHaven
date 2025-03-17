using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using Microsoft.VisualBasic.Devices;

namespace BookHaven.Data.repository
{
    internal class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(User user) 
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void Update(User user) {
            _context.Users.Update(user);
                
        }
        public void Delete(User user) {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        public User GetById(int id) => _context.Users.Find(id);
        public List<User> GetAll() => _context.Users.ToList();

        public List<User> searchUser(string key)
        {
            return _context.Users
            .Where(b => b.UserName.Contains(key))
            .ToList();
        }
    }
}
