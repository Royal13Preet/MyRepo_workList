using API_DataAccessLayer.DBModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DataAccessLayer.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _dbContext;

        public UserRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public User Create(User user)
        {
            var users = _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return users.Entity;
        }

        public User GetUserById(int id)
        {
            var user = _dbContext.Users
                  .Include(u => u.Profile)
                  .Include(u => u.Projects)
                  .Include(u => u.UserSkills)
                  .Include(u => u.ProjectUsers)
                  .FirstOrDefault(x => x.UserId == id);
            if (user != null)
            {
                return user;
            }
            return null!;
           
        }

        public User Login(string email, string password)
        {
           var login = _dbContext.Users.FirstOrDefault(x=> x.Email == email);
            
            if (login != null && BCrypt.Net.BCrypt.Verify(password, login.Password))
            {
                return login; 
            }
            return null!; 
        }
    }
}
