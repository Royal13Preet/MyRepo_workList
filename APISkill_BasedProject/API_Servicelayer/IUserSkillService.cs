using API_DataAccessLayer.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Servicelayer
{
    public interface IUserSkillService
    {
        bool AssignSkillsToUser(int userId, List<int> skillIds);
        bool AssignSkillsToProject(int projectId, List<int> skillIds);
        List<Project> GetMatchingProjects(int userId);
    }
}
