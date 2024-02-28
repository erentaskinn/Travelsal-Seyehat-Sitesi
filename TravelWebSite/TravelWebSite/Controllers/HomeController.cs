using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TravelWebSite.Models;

namespace TravelWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index Sayfası Çağırıldı");
            return View();
        }

        public IActionResult Privacy()
        {
            DateTime d=DateTime.Now;
            _logger.LogInformation(d+"Privacy sayfası çağırıldı");
            return View();
        }
        public IActionResult Test()
        {
            _logger.LogInformation($"Test Sayfası Çağırıldı");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}