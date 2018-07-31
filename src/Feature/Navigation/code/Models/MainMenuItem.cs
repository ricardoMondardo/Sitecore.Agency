using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Fields;

namespace Agency.Feature.Navigation.Models
{
    public class MainMenuItem: SitecoreItem
    {
        public Link Link { get; set; }
    }
}