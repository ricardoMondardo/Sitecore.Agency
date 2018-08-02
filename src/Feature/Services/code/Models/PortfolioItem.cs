using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.Services.Models
{
    public class PortfolioItem : SitecoreItem
    {
        public string Title { get; set; }
        public Image Image { get; set; }
    }
}