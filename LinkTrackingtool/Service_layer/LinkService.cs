using LinkTrackingTool.DataAccess.DBModel;
using Manager_Layer;
using Manager_Layer.Dto_s;

namespace Service_layer
{
    public class LinkService : ILinkService
    {

        private readonly ILinkManager _linkManager;

        public LinkService(ILinkManager linkManager)
        {
            _linkManager = linkManager;
        }

        public Link CreateShortCodeLink(CreateShortUrl link)
        {
            return _linkManager.CreateShortCodeLink(link);
        }

        public IEnumerable<Link> GetAllLinks()
        {
            return _linkManager.GetAllLinks();
        }
    }
}
