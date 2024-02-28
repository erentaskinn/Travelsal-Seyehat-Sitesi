using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.ViewComponents.MemberLayout
{
    public class _MemberLayoutSearch:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
