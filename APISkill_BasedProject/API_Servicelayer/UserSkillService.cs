using API_DataAccessLayer.DBModel;
using API_DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Servicelayer
{
    public class UserSkillService : IUserSkillService
    {
        private readonly IUserSkillRepo _userSkillRepo;

        public UserSkillService(IUserSkillRepo userSkillRepo)
        {
            _userSkillRepo = userSkillRepo;
        }

        public bool AssignSkillsToProject(int projectId, List<int> skillIds)
        {
            var project = _userSkillRepo.GetProjectById(projectId);
          
            project.Skill = skillIds.Select(id => new ProjectSkill { ProjectId = projectId, SkillId = id }).ToList();
            _userSkillRepo.SaveChang();
            return true;
        }

        public bool AssignSkillsToUser(int userId, List<int> skillIds)
        {
            var user = _userSkillRepo.GetUserById(userId);
           
            user.UserSkills = skillIds.Select(id => new UserSkill { UserId = userId, SkillId = id }).ToList();
            _userSkillRepo.SaveChang();
            return true;
        }

        public List<Project> GetMatchingProjects(int userId)
        {
            var userSkills = _userSkillRepo.GetUserSkills(userId);
            return _userSkillRepo.GetProjectsMatchingSkills(userSkills);

        }
    }
}
