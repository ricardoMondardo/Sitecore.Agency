using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace Agency.Feature.Media.Models
{    

    public class PageHeader: SitecoreItem
    {
        public Image Banner { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        [SitecoreField("CTA Link")]
        public Link CtaLink { get; set; }
    }
}