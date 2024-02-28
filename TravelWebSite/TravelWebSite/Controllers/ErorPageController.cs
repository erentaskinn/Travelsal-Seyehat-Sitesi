using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.Controllers
{
    public class ErorPageController : Controller
    {
        public IActionResult Eror404(int code)
        {
            return View();
        }
    }
}
