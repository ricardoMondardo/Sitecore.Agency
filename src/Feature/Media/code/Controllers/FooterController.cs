using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.Media.Models;
using System.Web.Mvc;

namespace Agency.Feature.Media.Controllers
{
    public class FooterController : GlassController
    {
        public ActionResult Footer()
        {
            var data = GetDataSourceItem<Footer>();
            return View("~/Views/Footer/Footer.cshtml", data);
        }
    }
}