using Agency.Foundation.Orm.Models;

namespace Agency.Feature.Services.Models
{
    public class ServicesItem : SitecoreItem
    {
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }
    }
}