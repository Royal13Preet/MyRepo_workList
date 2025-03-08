using API_DataAccessLayer.DBModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DataAccessLayer.Repositories
{
    public class UserSkillRepo : IUserSkillRepo
    {
        private readonly AppDbContext _dbContext;

        public UserSkillRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Project GetProjectById(int id)
        {

            var projects = _dbContext.Projects.Include(p => p.Skill).FirstOrDefault(p => p.ProjectId == id);
            if (projects != null) 
            {
                return projects;
            }
            return null!;
           
        }

        public List<Project> GetProjectsMatchingSkills(List<int> skillIds)
        {
           var match = _dbContext.ProjectsSkills.Where(ps => skillIds.Contains(ps.SkillId)).Select(ps => ps.Project).Distinct().ToList();
            return match;

        }
        
        public User GetUserById(int id)
        {

            var users = _dbContext.Users.Include(u => u.UserSkills).FirstOrDefault(u => u.UserId == id);
            if (users != null)
            {
                return users;
            }
            return null!;
        }

        public List<int> GetUserSkills(int userId)
        {
            var skills = _dbContext.UserSkills.Where(us => us.UserId == userId).Select(us => us.SkillId).ToList();
            return skills;

        }

        public void SaveChang()
        {
             _dbContext.SaveChanges();
        }

        


    }
}
