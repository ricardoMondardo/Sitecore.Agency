using Glass.Mapper.Sc.Web.Mvc;
using Agency.Feature.Services.Models;
using System.Web.Mvc;

namespace Agency.Feature.Services.Controllers
{
    public class PortfolioContainerController : GlassController
    {
        public ActionResult PortfolioContainer()
        {
            var data = GetDataSourceItem<PortfolioContainer>();
            return View("~/Views/PortfolioContainer/PortfolioContainer.cshtml", data);
        }

        public ActionResult PortfolioItem()
        {
            var data = GetDataSourceItem<PortfolioItem>();
            return View("~/Views/PortfolioContainer/PortfolioItem.cshtml", data);
        }
    }
}