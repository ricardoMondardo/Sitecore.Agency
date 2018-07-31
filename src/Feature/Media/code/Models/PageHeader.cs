using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.Navigation.Models
{
    using Glass.Mapper.Sc.Configuration.Attributes;

    public class PageHeader: SitecoreItem
    {
        public Image Banner { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        [SitecoreField("CTA Link")]
        public Link CtaLink { get; set; }
    }
}