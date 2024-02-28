using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Travels_EntityLayer.Concrete;
using TravelWebSite.Areas.Member.Models;

namespace TravelWebSite.Areas.Member.Controllers
{
    [Area("Member")]
	[Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
	{
	
		private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
		[HttpGet]
        public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel user =new UserEditViewModel();
			user.Name = values.Name;
			user.Surname = values.Surname;
			user.phoneNumber = values.PhoneNumber;
			user.Email = values.Email;
			return View(user);
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel p)
		{
			// Dışarıdan dosya yolıyla resim alma komutları böyledir.Bu içeriye giren user ile yapılır.
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (p.Image != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension=Path.GetExtension(p.Image.FileName);
				var imageName = Guid.NewGuid() + extension;
				var savelocation = resource + "/wwwroot/UserImage/" + imageName;
				var stream =new FileStream(savelocation, FileMode.Create);
				await p.Image.CopyToAsync(stream);
				user.ImageUrl= imageName;
			}
			user.Name=p.Name;
			user.Surname=p.Surname;
			user.PasswordHash = _userManager.PasswordHasher.HashPassword(user,p.Password);
			var result = await _userManager.UpdateAsync(user);
			if (result.Succeeded)
			{
				return RedirectToAction("SignIn", "Login");
			}
			return View();
		}
	}
}
