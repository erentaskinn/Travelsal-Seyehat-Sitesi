using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.ViewComponents.MemberLayout
{
    public class _MemberLayoutScript:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
