using API_DataAccessLayer.DBModel;
using API_manager.DTo_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_manager
{
    public interface IProjectManager
    {
        public Project CreateProject(CreateProject project);

        public IEnumerable<Project> GetAllProjects();

        public Project GetById(int id);
    }
}
