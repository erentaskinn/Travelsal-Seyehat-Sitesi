using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Travel_BussinessLayer.Concrete;
using Travel_DataAccessLayer.EntityFramework;
using Travels_EntityLayer.Concrete;

namespace TravelWebSite.Areas.Member.Controllers
{
    [Area("Member")]
    public class RezervationController : Controller
    {
        DestinationManager destinationManager=new DestinationManager(new EfDestinationDal());
        ReservationManager reservationManager=new ReservationManager(new EfRezervationDal());
        private readonly UserManager<AppUser> _userManager;
        public RezervationController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> MyCurrentRezervation() 
        {

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByAccepted(values.Id);
            return View(valuesList);
        }
        public async Task< IActionResult> MyOldRezervation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList = reservationManager.GetListWithReservationByPrevious(values.Id);
            return View(valuesList);
        }
        public async Task<IActionResult> MyApprovalReservation()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            var valuesList= reservationManager.GetListWithReservationByWaitApproval(values.Id);
            return View(valuesList);
        }

        [HttpGet]
        public IActionResult NewRezervation()
        {
            List<SelectListItem> values = (from x in destinationManager.TGetList()
                                           select new SelectListItem
                                           {
                                               Text=x.City,
                                               Value=x.DestinationId.ToString(),
                                           }).ToList();
            ViewBag.Values = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewRezervation(Rezervation p)
        {
            p.AppUserId = 15;
            p.Status = "Onay Bekliyor";
            reservationManager.TAdd(p);
            RedirectToAction("MyCurrentReservation");
            return View();
        }
        public IActionResult Deneme()
        {
            return View();
        }
    }
}
