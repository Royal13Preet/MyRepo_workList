using API_DataAccessLayer.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DataAccessLayer.Repositories
{
    public interface IUserSkillRepo
    {
        User GetUserById(int id);

        Project GetProjectById(int id);

        List<int> GetUserSkills(int userId);

        List<Project> GetProjectsMatchingSkills(List<int> skillIds);

        public void SaveChang();




    }
}
