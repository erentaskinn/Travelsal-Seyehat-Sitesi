using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.ViewComponents.AdminDsahboard
{
    public class _DashboardBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
