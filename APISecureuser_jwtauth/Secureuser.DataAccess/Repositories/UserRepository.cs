using Secureuser.DataAccess.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Secureuser.DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ProjectDbContext _context;

        public UserRepository(ProjectDbContext context)
        {
            _context = context;
        }

        public User GetUserByUsernameAndPassword(string username, string password)
        {
            try
            {
                var user = _context.Users.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {
                  
                    if (BCrypt.Net.BCrypt.Verify(password, user.Password))
                    {
                        return user; 
                    }
                }
                return null;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while fetching user by username and password.", ex);
                return null!;
            }
        }



        public User GetUserByUsername(string username)
        {
            try
            {
                return _context.Users.FirstOrDefault(u => u.Username == username);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while fetching user by username: {ex.Message}");
                return null!;
            }
        }

        public void AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while adding user.", ex);
            }
        }

        public void RemoveUser(User user)
        {
            try
            {
                _context.Users.Remove(user);
                Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while removing user: {ex.Message}");
            }
        }
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while saving changes to the database.", ex);
            }
        }

        public List<User> GetAllUsers()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while fetching all users.", ex);
                return null!;
            }
        }
    }
}




