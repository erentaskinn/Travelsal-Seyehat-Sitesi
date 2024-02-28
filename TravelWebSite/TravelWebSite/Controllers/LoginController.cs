using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Travels_EntityLayer.Concrete;
using TravelWebSite.Models;

namespace TravelWebSite.Controllers
{
	[AllowAnonymous]//Altında bulunduğu kodaları onları geçerli bütün kurallardan muaf
	public class LoginController : Controller
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
		public IActionResult SingUp()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> SingUp(UserRegisterVM p)
		{
			AppUser appUser = new AppUser()
			{
				Name = p.Name,
				Surname = p.Surname,
				Email = p.Email,
				UserName = p.UserName,
				ImageUrl="EREN"
				
			};
			if (p.Password == p.ConfirmPassword)
			{
				var result = await _userManager.CreateAsync(appUser,p.Password);
				if (result.Succeeded)
				{
					return RedirectToAction("SignIn");
				}
				else
				{
					foreach (var item in result.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View(p);
		}
		[HttpGet]
		public IActionResult SignIn()
		{
			return View();
		}
		[HttpPost]
		public async Task< IActionResult> SignIn(UserSignInViewModel p)
		{
			if (ModelState.IsValid)
			{
				var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
				if (result.Succeeded)
				{
					return RedirectToAction("Index", "Dashboard",new {area="Member"});
				}
				else
				{
					return RedirectToAction("SingIn", "Login");
				}
			}
			return View();
		}
	}
}
