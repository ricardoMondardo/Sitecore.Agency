using Agency.Foundation.Orm.Models;

namespace Agency.Feature.Contact.Models
{
    public class FormContainer : SitecoreItem
    {
        public virtual string Title { get; set; }
        public virtual string SubTitle { get; set; }
    }
}