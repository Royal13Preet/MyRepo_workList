using API_DataAccessLayer.DBModel;
using API_manager;
using API_manager.DTo_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Servicelayer
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectManager _projectManager;

        public ProjectService(IProjectManager projectManager)
        {
            _projectManager = projectManager;
        }

        public Project CreateProject(CreateProject project)
        {
            return _projectManager.CreateProject(project);
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _projectManager.GetAllProjects();
        }

        public Project GetById(int id)
        {
            return _projectManager.GetById(id);
        }
    }
}
