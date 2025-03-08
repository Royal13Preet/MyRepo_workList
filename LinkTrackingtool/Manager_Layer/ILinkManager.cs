using LinkTrackingTool.DataAccess.DBModel;
using Manager_Layer.Dto_s;

namespace Manager_Layer
{
    public interface ILinkManager
    {
        public IEnumerable<Link> GetAllLinks();

        public Link Get();

        public Link CreateShortCodeLink(CreateShortUrl link);
    }
}


















