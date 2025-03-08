using LinkTrackerTool.Manager.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTrackerTool.Manager
{
    public interface ILinkManager
    {
        /// <summary>
        /// For Creating a Short URL
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public ResponseShortUrl CreateShortUrl(CreateShortUrlRequest link);
    }
}
