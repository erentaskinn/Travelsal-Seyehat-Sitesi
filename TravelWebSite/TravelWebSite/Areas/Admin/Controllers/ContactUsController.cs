using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Abstract;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            _contactUsService = contactUsService;
        }

        public IActionResult Index()
        {
            var values=_contactUsService.TGetListByTrue();
            return View(values);
        }
    }
}
