using API_DataAccessLayer.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DataAccessLayer.Repositories
{
    public interface IProjectRepo
    {
        public Project CreateProject(Project project);

        public IEnumerable<Project> GetAllProjects();

        public Project GetById(int id); 
    }
}
