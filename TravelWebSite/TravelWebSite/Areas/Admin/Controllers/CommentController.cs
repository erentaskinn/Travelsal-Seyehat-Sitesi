using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Abstract;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.EntityFramework;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values= _commentService.TGetListCommentWithDestination();
            return View(values);
        }
        public IActionResult DeleteComment(int Id) 
        {
            var values=_commentService.TGetById(Id);
            _commentService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
