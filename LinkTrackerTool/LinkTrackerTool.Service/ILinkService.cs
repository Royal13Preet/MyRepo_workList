using LinkTrackerTool.Manager.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTrackerTool.Service
{
    public interface ILinkService
    {
        /// <summary>
        /// Create a short Url
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public ResponseShortUrl CreateShortUrl(CreateShortUrlRequest link);
    }


}




