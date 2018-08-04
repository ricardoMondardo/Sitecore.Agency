using Agency.Feature.Services.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.Services.Controllers
{
    public class AboutContainerController : GlassController
    {
        // GET: AboutContainer
        public ActionResult AboutContainer()
        {
            var data = GetDataSourceItem<AboutContainer>();
            return View("~/Views/AboutContainer/AboutContainer.cshtml", data);
        }

        public ActionResult AboutItem()
        {
            var data = GetDataSourceItem<AboutItem>();
            return View("~/Views/AboutContainer/AboutItem.cshtml", data);
        }
    }
}