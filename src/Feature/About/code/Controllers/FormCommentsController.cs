using Agency.Feature.About.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agency.Feature.About.Controllers
{
    public class FormCommentsController : GlassController
    {
        // GET: FormComments
        public ActionResult Comments()
        {
            var model = new FormComment();
            return View("~/Views/FormComments/FormComment.cshtml", model);
        }

        [HttpPost]
        public ActionResult Comments(FormComment model)
        {
            if(!ModelState.IsValid)
            {
                return View("~/Views/FormComments/FormComment.cshtml", model);
            }

            return View("~/Views/FormComments/FormComment.cshtml", model);
        }
    }
}