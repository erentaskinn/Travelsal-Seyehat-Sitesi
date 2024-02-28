using Microsoft.AspNetCore.Mvc;

namespace TravelWebSite.Areas.Member.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
