using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Abstract;
using Travels_EntityLayer.Concrete;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View(values);
        }
        public IActionResult DeleteUser(int Id)
        {
            var values = _appUserService.TGetById(Id);
            _appUserService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var values = _appUserService.TGetById(Id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Edit(AppUser appUser)
        {
            _appUserService.TUpdate(appUser);
            return RedirectToAction("Index");
        }
        public IActionResult CommentUser(int Id)
        {
            _appUserService.TGetList();
            return View();
        }
        public IActionResult ReservationUser(int Id)
        {
            var values = _reservationService.GetListWithReservationByAccepted(Id);
            return View(values);
        }
    }
}
