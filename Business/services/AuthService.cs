using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Data.entity;
using BookHaven.Data.repository;

namespace BookHaven.Business.services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepo;

        public AuthService(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        public bool AuthenticateUser(string username, string password, out string role)
        {
            role = string.Empty;
            var user = _userRepo.GetAll().FirstOrDefault(u => u.UserName == username);
            if (user != null && BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                role = user.Role;
                return true;
            }
            return false;
        }

        public void RegisterUser(string username, string password, string role)
        {
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            var newUser = new User { UserName = username, PasswordHash = hashedPassword, Role = role };
            _userRepo.Add(newUser);
        }
    }
}

