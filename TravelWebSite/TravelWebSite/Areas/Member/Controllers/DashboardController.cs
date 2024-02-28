using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Travels_EntityLayer.Concrete;

namespace TravelWebSite.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/Dashboard")]
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public DashboardController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.UserName = values.Name +" "+ values.Surname;
            ViewBag.userImage = values.ImageUrl;
            return View();
        }
        [Route("MemberDashboard")]
        public async Task<IActionResult> MemberDashboard()
        {
            return View();
        }
    }
}
