using LinkTrackerTool.Manager;
using LinkTrackerTool.Manager.Dto;

namespace LinkTrackerTool.Service
{
    public class LinkService : ILinkService
    {
        private readonly ILinkManager _linkManager;

        public LinkService(ILinkManager linkManager)
        {
            _linkManager = linkManager;
        }

        public ResponseShortUrl CreateShortUrl(CreateShortUrlRequest link)
        {

            return _linkManager.CreateShortUrl(link);
        }
    }
}
