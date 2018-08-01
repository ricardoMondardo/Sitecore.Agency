using Agency.Foundation.Orm.Models;

namespace Agency.Feature.Services.Models
{
    public class PortfolioContainer : SitecoreItem
    {
        public virtual string Title { get; set; }
        public virtual string SubTitle { get; set; }
    }
}