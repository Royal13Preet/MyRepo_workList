using LinkTrackerTool.DataAccess.DBModel;

namespace LinkTrackerTool.DataAccess.Repositories
{
    public class LinkRepository : ILinkRepository
    {
        private readonly ProjectDbContext _projectDbContext;


        public LinkRepository(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        public Link CreateShortUrl(Link link)
        {
            _projectDbContext.Links.Add(link);
            _projectDbContext.SaveChanges();
            return link;
        }
        
        public bool ShortCodeExists(string shortCode)
        {
            return _projectDbContext.Links.Any(l => l.ShortUrl == shortCode);
        }

    }
}
