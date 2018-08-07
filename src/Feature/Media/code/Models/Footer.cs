using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.Media.Models
{
    public class Footer : SitecoreItem
    {
        public Link Copyright { get; set; }
        [SitecoreField("Link Ttwitter")]
        public Link LinkTtwitter { get; set; }
        [SitecoreField("Link Facebook")]
        public Link LinkFacebook { get; set; }
        [SitecoreField("Link Linkedin")]
        public Link LinkLinkedin { get; set; }
        [SitecoreField("Link Policy")]
        public Link LinkPolicy { get; set; }
        [SitecoreField("Link Terms")]
        public Link LinkTerms { get; set; }

    }
}