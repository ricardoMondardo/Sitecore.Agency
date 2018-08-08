using Agency.Feature.Contact.Models;
using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;

namespace Agency.Feature.Contact.Controllers
{
    public class ContactContainerController : GlassController
    {
        public ActionResult CommentConteiner()
        {
            var data = GetDataSourceItem<ContactContainer>();
            return View("~/Views/ContactContainer/ContactContainer.cshtml", data);
            
        }

        
        public ActionResult Form()
        {
            var model = new ContactForm();
            return View("~/Views/ContactContainer/ContactForm.cshtml", model);
        }
 
    }
}