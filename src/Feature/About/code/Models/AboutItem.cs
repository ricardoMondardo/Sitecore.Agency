using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.About.Models
{
    public class AboutItem : SitecoreItem
    {
        public virtual string Title { get; set; }
        public virtual string SubTitle { get; set; }
        public virtual string Text { get; set; }
        public virtual Image Image { get; set; }
        public virtual bool Inverted { get; set; }
    }
}