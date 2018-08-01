using Agency.Foundation.Orm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agency.Feature.Services.Models
{
    public class PortfolioContainer : SitecoreItem
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
    }
}