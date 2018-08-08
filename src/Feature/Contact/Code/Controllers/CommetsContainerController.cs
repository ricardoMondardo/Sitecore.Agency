using Agency.Feature.Contact.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.Contact.Controllers
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