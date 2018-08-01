using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.Services.Models;
using System.Web.Mvc;

namespace Agency.Feature.Services.Controllers
{
    public class PortfolioContainerController : GlassController
    {
        // GET: PortfolioContainer
        public ActionResult PortfolioContainer()
        {
            var data = this.GetDataSourceItem<PortfolioContainer>();
            return View("~/Views/PortfolioContainer/PortfolioContainer.cshtml");
        }
    }
}