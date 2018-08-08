using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Agency.Feature.Services.Models
{
    public class LayoutVariation : SitecoreItem
    {
        [SitecoreField("Css Variation")]
        public virtual string CssVariation { get; set; }
    }
}