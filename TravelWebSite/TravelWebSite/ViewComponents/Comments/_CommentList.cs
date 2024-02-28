using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.EntityFramework;

namespace TravelWebSite.ViewComponents.Comments
{
    public class _CommentList:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfComment());
        public IViewComponentResult Invoke(int Id)
        {
            var values = commentManager.TGetListCommentWithDestinationAndUser(Id);
            return View(values);
        } 
    }
}
