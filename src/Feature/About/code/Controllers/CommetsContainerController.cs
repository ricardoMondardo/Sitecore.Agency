using Agency.Feature.About.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class CommetsContainerController : GlassController
    {
        public ActionResult CommentConteiner()
        {
            var data = GetDataSourceItem<FormContainer>();
            return View("~/Views/CommetsContainer/FormContainer.cshtml", data);
            
        }
        public ActionResult Comments()
        {
            var model = new FormItem();
            return View("~/Views/CommetsContainer/FormItem.cshtml", model);
        }

        [HttpPost]
        public ActionResult Comments(FormItem model)
        {
            if(!ModelState.IsValid)
            {
                return View("~/Views/CommetsContainer/FormItem.cshtml", model);
            }

            return View("~/Views/CommetsContainer/FormItem.cshtml", model);
        }
    }
}