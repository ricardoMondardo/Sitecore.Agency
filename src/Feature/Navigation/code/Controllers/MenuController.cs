using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Agency.Feature.Navigation.Models;

namespace Agency.Feature.Navigation.Controllers
{
    public class MenuController : GlassController
    {
        // GET: Menu
        public ActionResult MainMenu()
        {
            var context = new SitecoreContext();
            var mainMenu = context.GetItem<MainMenu>("/sitecore/content/Agency/Data/Main Menu");

            return View(mainMenu);
        }
    }
}