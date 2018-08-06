using Agency.Feature.About.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class ClientContainerController : GlassController
    {
        public ActionResult ClientContainer()
        {
            return View("~/Views/ClientContainer/ClientContainer.cshtml");
        }

        public ActionResult ClientItem()
        {
            var data = GetDataSourceItem<ClientItem>();
            return View("~/Views/ClientContainer/ClientItem.cshtml", data);
        }
    }
}