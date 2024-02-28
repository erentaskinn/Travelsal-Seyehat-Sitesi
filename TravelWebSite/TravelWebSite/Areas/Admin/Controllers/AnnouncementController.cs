using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Travel_BussinessLayer.Abstract;
using Travels_EntityLayer.Concrete;
using TravelsalDTOLayer.DTO_s.AnnouncementDTOs;
using TravelWebSite.Areas.Admin.Models;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;
        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDTO>>(_announcementService.TGetList());
            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDTO model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement
                {
                    Conetent = model.Content,
                    Title = model.Title,
                    Date=Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult DeleteAnnouncement(int Id)
        {
            var values=_announcementService.TGetById(Id);
            _announcementService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UptadeAnnouncement(int id)
        {
            var values =_mapper.Map<AnnouncementUptadeDto>(_announcementService.TGetById(id));
            return View(values);
        }
        [HttpPost]
        public IActionResult UptadeAnnouncement(AnnouncementUptadeDto model)
        {
            if(ModelState.IsValid)
            {
                _announcementService.TUpdate(new Announcement
                {
                    AnnouncementId=model.AnnouncementId,
                    Title=model.Title,
                    Conetent=model.Conetent,
                    Date=Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
           return View(model);
        }
    }
}
