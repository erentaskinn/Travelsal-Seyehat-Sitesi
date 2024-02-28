using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.ViewComponents.MemberLayout
{
    public class _MemberLayoutSideBar:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
