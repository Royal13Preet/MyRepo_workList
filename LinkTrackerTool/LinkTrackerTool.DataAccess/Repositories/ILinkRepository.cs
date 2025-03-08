using LinkTrackerTool.DataAccess.DBModel;

namespace LinkTrackerTool.DataAccess.Repositories
{
    public interface ILinkRepository
    {
        /// <summary>
        /// For Creating a Short URL
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public Link CreateShortUrl(Link link);

        /// <summary>
        /// Checks the short code exists are not
        /// </summary>
        /// <param name="shortCode"></param>
        /// <returns></returns>
        bool ShortCodeExists(string shortCode);
    }
}
