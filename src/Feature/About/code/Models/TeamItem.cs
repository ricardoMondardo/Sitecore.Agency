using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.About.Models
{
    public class TeamItem : SitecoreItem
    {
        [SitecoreField("First Name")]
        public string FirstName { get; set; }
        public string Role { get; set; }
        [SitecoreField("Link Twitter")]
        public Link LinkTwitter { get; set; }
        [SitecoreField("Link Facebook")]
        public Link LinkFacebook { get; set; }
        [SitecoreField("Link Linkedin")]
        public Link LinkLinkedin { get; set; }
        public Image Image { get; set; }
    }
}