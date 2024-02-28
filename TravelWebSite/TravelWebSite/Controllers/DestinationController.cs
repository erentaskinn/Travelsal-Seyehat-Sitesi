using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.EntityFramework;
using Travels_EntityLayer.Concrete;

namespace TravelWebSite.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        DestinationManager _DestinationManager = new DestinationManager(new EfDestinationDal());
        private readonly UserManager<AppUser> _userManager;
        public DestinationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var values = _DestinationManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> DestinationDetails(int id)
        {
            ViewBag.i=id;
            ViewBag.destId=id;
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.userId=value.Id;
            var values=_DestinationManager.TGetDestinationWithGuide(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p) 
        {
            return View();
        }
    }
}
