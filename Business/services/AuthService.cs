using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookHaven.Common;
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
                SessionManager.CurrentUserId = user.Id;
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
        
        public void updateUser(string username, string password, string role, User user)
        {
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            user.PasswordHash = hashedPassword;
            user.Role = role;
            user.UserName = username;
            _userRepo.Update(user);
        }

        public List<User> GetAllUsers()
        {
            return _userRepo.GetAll();
        }

        public User GetUserById(int userId)
        {
            return _userRepo.GetById(userId);
        }

        public void deleteUser(User user)
        {
            _userRepo.Delete(user);
        }

        public List<User> searchUsers(string keyword)
        {
            return _userRepo.searchUser(keyword);
        }

    }
}


