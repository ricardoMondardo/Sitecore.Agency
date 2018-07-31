using Agency.Foundation.Orm.Models;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Feature.Navigation.Models
{
    public class MainMenu: SitecoreItem
    {
        public IEnumerable<MainMenuItem> Children { get; set; }
    }
}