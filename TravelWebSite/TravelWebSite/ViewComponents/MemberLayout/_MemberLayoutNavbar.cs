using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.ViewComponents.MemberLayout
{
    public class _MemberLayoutNavbar:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
    }
}
