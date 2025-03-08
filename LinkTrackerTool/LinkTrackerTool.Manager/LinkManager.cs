using AutoMapper;
using LinkTrackerTool.DataAccess.DBModel;
using LinkTrackerTool.DataAccess.Repositories;
using LinkTrackerTool.Manager.Dto;

namespace LinkTrackerTool.Manager
{
    public class LinkManager : ILinkManager
    {
        private readonly ILinkRepository _linkRepository;
        private readonly IMapper _mapper;

        public LinkManager(ILinkRepository linkRepository, IMapper mapper)
        {
            _linkRepository = linkRepository;
            _mapper = mapper;
        }

        public ResponseShortUrl CreateShortUrl(CreateShortUrlRequest linkDto)
        {
            var link = _mapper.Map<Link>(linkDto);

          
            link.ShortUrl = string.IsNullOrEmpty(linkDto.CustomAlias)
                ? GenerateUniqueShortCode()  
                : EnsureUniqueAlias(linkDto.CustomAlias); 

            link.CreatedAt = DateTime.UtcNow;

            var result = _linkRepository.CreateShortUrl(link);

            return new ResponseShortUrl
            {
                ShortUrl = $"https://yourdomain.com/{result.ShortUrl}"
            };
        }

        private string GenerateUniqueShortCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            string shortCode;

            do
            {
                shortCode = new string(Enumerable.Repeat(chars, 6)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
            } while (_linkRepository.ShortCodeExists(shortCode)); 

            return shortCode;
        }

        private string EnsureUniqueAlias(string customAlias)
        {
            if (_linkRepository.ShortCodeExists(customAlias))
            {
                throw new Exception("Custom alias already exists. Please choose another.");
            }
            return customAlias;
        }

    }
}



