using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
    }
}
