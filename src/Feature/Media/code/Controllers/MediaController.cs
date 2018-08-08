using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.Media.Models;

namespace Agency.Feature.Media.Controllers
{
    public class MediaController : GlassController
    {
        public ActionResult PageHeader()
        {
            var data = this.GetDataSourceItem<PageHeader>();
            return View("~/Views/Media/PageHeader.cshtml", data);
        }

        public ActionResult PageFooter()
        {
            var data = GetDataSourceItem<PageFooter>();
            return View("~/Views/Media/PageFooter.cshtml", data);
        }
    }
}