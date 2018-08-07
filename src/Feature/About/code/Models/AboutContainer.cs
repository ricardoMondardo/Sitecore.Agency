using Agency.Foundation.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency.Feature.About.Models
{
    public class AboutContainer : SitecoreItem
    {
        public virtual string Title { get; set; }
        public virtual string SubTitle { get; set; }
    }
}