using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Abstract;

namespace TravelWebSite.ViewComponents.MemberDashboard
{
    public class _LastDestination:ViewComponent
    {
        private readonly IDestinationService _destinationService;

        public _LastDestination(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_destinationService.TGetLast4Destinations();
            return View(values);
        }
    }
}
