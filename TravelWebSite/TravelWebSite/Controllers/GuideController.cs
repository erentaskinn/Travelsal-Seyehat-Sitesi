using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.EntityFramework;

namespace TravelWebSite.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        GuidManager guidManager=new GuidManager(new EfGuideDal());
        public IActionResult Index()
        {
            var values = guidManager.TGetList();
            return View(values);
        }
    }
}
