using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.ViewComponents.MemberDashboard
{
    public class _MemberStatistic:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }

    }
}
