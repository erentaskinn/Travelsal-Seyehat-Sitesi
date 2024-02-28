using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.EntityFramework;
using Travels_EntityLayer.Concrete;

namespace TravelWebSite.ViewComponents.MemberDashboard
{
    public class _ProfileInformation:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName =values.UserName+" "+ values.Surname;
            ViewBag.memberPhone = values.PhoneNumber;
            ViewBag.memberEmail=values.Email;
            return View();
        }
    }
}
