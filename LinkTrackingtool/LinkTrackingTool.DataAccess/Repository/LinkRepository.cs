using LinkTrackingTool.DataAccess.DBModel;

namespace LinkTrackingTool.DataAccess.Repository
{
    public class LinkRepository : ILinkRepository
    {

        private readonly AppDbContext _appDbContext;

        public LinkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Link CreateShortCodeLink(Link link)
        {
            _appDbContext.Links.Add(link);
            _appDbContext.SaveChanges();
            return link;
        }

        public IEnumerable<Link> GetAllLinks()
        {
            return _appDbContext.Links;
        }

        public Link GetById(Guid id)
        {
            var map = _appDbContext.Links.FirstOrDefault(x => x.Id == id);

            if(map != null)
            {
                return map;
            }
            return null!;
        }
    }
}
