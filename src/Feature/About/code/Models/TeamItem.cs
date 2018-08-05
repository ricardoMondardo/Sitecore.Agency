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
        public Link Twitter { get; set; }
        public Link Facebook { get; set; }
        public Link Linkedin { get; set; }
        public Image Image { get; set; }
    }
}