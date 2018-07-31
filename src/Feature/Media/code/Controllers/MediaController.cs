using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.Navigation.Models;

namespace Agency.Feature.Media.Controllers
{
    public class MediaController : GlassController
    {
        public ActionResult PageHeader()
        {
            var pageHeader = this.GetDataSourceItem<PageHeader>();
            return View(pageHeader);
        }
    }
}