using Agency.Feature.Services.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.Services.Controllers
{
    public class ServicesContainerController : GlassController
    {
        public ActionResult ServicesContainer()
        {
            var data = GetDataSourceItem<ServicesContainer>();
            return View("~/Views/ServicesContainer/ServicesContainer.cshtml", data);
        }

        public ActionResult ServicesItem()
        {
            var data = GetDataSourceItem<ServicesItem>(true);
            return View("~/Views/ServicesContainer/ServicesItem.cshtml", data);
        }
    }
}