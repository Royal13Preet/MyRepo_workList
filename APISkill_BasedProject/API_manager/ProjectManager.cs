using API_DataAccessLayer.DBModel;
using API_DataAccessLayer.Repositories;
using API_manager.DTo_s;
using AutoMapper;

namespace API_manager
{
    public class ProjectManager : IProjectManager
    {
        private readonly IProjectRepo _projectRepo;
        private readonly IMapper _mapper;
        public ProjectManager(IProjectRepo projectRepo, IMapper mapper)
        {
            _projectRepo = projectRepo;
            _mapper = mapper;
        }

        public Project CreateProject(CreateProject project)
        {
            var map = _mapper.Map<Project>(project);
            return _projectRepo.CreateProject(map);

        }


        public IEnumerable<Project> GetAllProjects()
        {
            return _projectRepo.GetAllProjects();
        }

        public Project GetById(int id)
        {
            return _projectRepo.GetById(id);
        }
    }
}
