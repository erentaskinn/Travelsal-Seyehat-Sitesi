using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.EntityFramework;
using Travels_EntityLayer.Concrete;

namespace TravelWebSite.Controllers
{
    public class CommentController : Controller
    {
        CommentManager _commentManager = new CommentManager(new EfComment());
      
        [HttpGet]
        public PartialViewResult AddComment()
        {
           
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentUser = User.Identity.Name;
            p.CommentDate =Convert.ToDateTime( DateTime.Now.ToShortDateString());
            p.CommentState = true;
            _commentManager.TAdd(p);
            return RedirectToAction("Index","Destination");
        }
    }
}
