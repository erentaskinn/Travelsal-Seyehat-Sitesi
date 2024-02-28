using Microsoft.AspNetCore.Mvc;
using Travel_DataAccessLayer.Concerate;

namespace TravelWebSite.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2=c.Guides.Count();
            ViewBag.v3 = "285";
        
            return View();
        }
    }
}
