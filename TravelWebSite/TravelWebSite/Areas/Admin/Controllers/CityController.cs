using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using Travel_BussinessLayer.Abstract;
using Travels_EntityLayer.Concrete;
using TravelWebSite.Models;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityList()
        {
            var values = _destinationService.TGetList();
            var jsonCity = JsonConvert.SerializeObject(values);
            return Json(jsonCity);
        }
        //public static List<CityClass> cities = new List<CityClass>
        //{
        //    new CityClass
        //    {
        //        CityId=1,
        //        CityName="Üsküp",
        //        CityCountry="Makedonya"
        //    },
        //    new CityClass
        //    {
        //        CityId=2,
        //        CityName="Roma",
        //        CityCountry="İtalya"
        //    },
        //    new CityClass
        //    {
        //        CityId=3,
        //        CityName="Londra",
        //        CityCountry="İngiltere"
        //    }
        //};

        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }
        public IActionResult GetById(int DestinationId)
        {
            var values=_destinationService.TGetById(DestinationId);
            var jsonValues= JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        [HttpPost]
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetById(id);
            _destinationService.TDelete(values);
            return NoContent();
        }
        public IActionResult UpdateCity(Destination destination)
        {
         
            _destinationService.TUpdate(destination);
            var V=JsonConvert.SerializeObject(destination);
            return Json(V);
        }


    }
}
