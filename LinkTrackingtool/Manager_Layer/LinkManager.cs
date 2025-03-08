using AutoMapper;
using LinkTrackingTool.DataAccess.DBModel;
using LinkTrackingTool.DataAccess.Repository;
using Manager_Layer.Dto_s;


namespace Manager_Layer
{
    public class LinkManager : ILinkManager
    {

        private readonly ILinkRepository _linkRepository;
        private readonly IMapper _mapper;
        private const int ShortCodeLength = 6;
        public LinkManager(ILinkRepository linkRepository, IMapper mapper)
        {
            _linkRepository = linkRepository;
            _mapper = mapper;
        }

        public Link CreateShortCodeLink(CreateShortUrl link)
        {
            var map = _mapper.Map<Link>(link);
            map.ShortUrl = GenerateShortCode();
            return _linkRepository.CreateShortCodeLink(map);
        }
      
        private string GenerateShortCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, ShortCodeLength)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public IEnumerable<Link> GetAllLinks()
        {
            return _linkRepository.GetAllLinks();
        }

        public Link Get()
        {
            throw new NotImplementedException();
        }
    }
}


