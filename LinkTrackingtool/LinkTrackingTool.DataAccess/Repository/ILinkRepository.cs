using LinkTrackingTool.DataAccess.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTrackingTool.DataAccess.Repository
{
    public interface ILinkRepository
    {
        public IEnumerable<Link> GetAllLinks();

        public Link CreateShortCodeLink(Link link);

        public Link GetById(Guid id);

        
    }
}
