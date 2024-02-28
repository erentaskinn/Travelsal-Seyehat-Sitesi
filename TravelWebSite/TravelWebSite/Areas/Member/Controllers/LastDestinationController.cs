using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Abstract;

namespace TravelWebSite.Areas.Member.Controllers
{
    [Area("Member")]
    public class LastDestinationController : Controller
    {
        private readonly IDestinationService _destinationService;
        public LastDestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetLast4Destinations();
            return View(values);
            
        }
    }
}
