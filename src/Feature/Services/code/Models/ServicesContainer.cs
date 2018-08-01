using Agency.Foundation.Orm.Models;

namespace Agency.Feature.Services.Models
{
   public class ServicesContainer : SitecoreItem
    {
        public virtual string Title { get; set; }
        public virtual string SubTitle { get; set; }
    }
}