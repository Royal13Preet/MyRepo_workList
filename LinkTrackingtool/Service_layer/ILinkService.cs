using LinkTrackingTool.DataAccess.DBModel;
using Manager_Layer.Dto_s;

namespace Service_layer
{
    public interface ILinkService
    {
        public IEnumerable<Link> GetAllLinks();

        public Link CreateShortCodeLink(CreateShortUrl link);
    }
}
