using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.About.Models;
using System.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class TeamContainerController : GlassController
    {
        // GET: TeamContainer
        public ActionResult TeamContainer()
        {
            var data = GetDataSourceItem<TeamContainer>();
            return View("~/Views/TeamContainer/TeamContainer.cshtml", data);
        }

        public ActionResult TeamItem()
        {
            var data = GetDataSourceItem<TeamItem>();
            return View("~/Views/TeamContainer/TeamItem.cshtml", data);
        }
    }
}