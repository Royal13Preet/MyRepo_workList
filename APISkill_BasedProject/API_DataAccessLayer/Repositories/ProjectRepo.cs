using API_DataAccessLayer.DBModel;
using Microsoft.EntityFrameworkCore;

namespace API_DataAccessLayer.Repositories
{
    public class ProjectRepo : IProjectRepo
    {
        private readonly AppDbContext _context;

        public ProjectRepo(AppDbContext context)
        {
            _context = context;
        }

        public Project CreateProject(Project project)
        {
            var projects = _context.Projects.Add(project);
            _context.SaveChanges();
            return projects.Entity;
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _context.Projects;
        }
       
        public Project GetById(int id)
        {
            var result = _context.Projects.Include(c => c.CreatedByUser).
                Include(c => c.Skill).
                Include(c => c.ProjectUsers).
                FirstOrDefault(x => x.ProjectId == id);
            if(result != null)
            {
                return result;
            }
            return null!;
        }
    }
}
