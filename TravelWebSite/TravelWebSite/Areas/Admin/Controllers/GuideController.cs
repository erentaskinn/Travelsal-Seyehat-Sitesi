using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Travel_BussinessLayer.Abstract;
using Travel_BussinessLayer.ValidationRules;
using Travels_EntityLayer.Concrete;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Guide")]
    public class GuideController : Controller
    {
        private readonly IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }
        [Route("Index")]
        public IActionResult Index()
        {
          var values=  _guideService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddGuide() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result= validationRules.Validate(guide);
            if (result.IsValid)
            {
                _guideService.TAdd(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                return View();
            }
          
        }
        [HttpGet]
        public IActionResult EditGuide(int Id)
        {
            var values=_guideService.TGetById(Id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.TUpdate(guide);
            return RedirectToAction("Index");
        }
        [Route("ChangeToTrue/{Id}")]
        public IActionResult ChangeToTrue(int Id)
        {
            _guideService.TChangeToTrueByGuide(Id);
            return RedirectToAction("Index", "Guide", new {area="Admin"});
        }
        [Route("ChangeToFalse/{Id}")]
        public IActionResult ChangeToFalse(int Id)
        {
            _guideService.TChangeToFalseByGuide(Id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}
