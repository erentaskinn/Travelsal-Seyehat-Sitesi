using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.ViewComponents.MemberLayout
{
    public class _MemberLayoutLanguages:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {  
            return View(); 
        }

    }
}
