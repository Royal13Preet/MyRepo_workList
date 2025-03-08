using API_DataAccessLayer.DBModel;
using API_manager.DTo_s;

namespace API_Servicelayer
{
    public interface IProjectService
    {
        public Project CreateProject(CreateProject project);

        public IEnumerable<Project> GetAllProjects();

        public Project GetById(int id);
    }
}
