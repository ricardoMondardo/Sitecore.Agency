using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Agency.Feature.Services.Models
{
    public class ServicesItem : SitecoreItem
    {
        public virtual string Title { get; set; }
        public virtual string Text { get; set; }
        public virtual LayoutVariation Variation { get; set; }
    }
}