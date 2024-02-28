using DocumentFormat.OpenXml.Office2010.Excel;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelWebSite.CQRS.Commands.GuideCommands;
using TravelWebSite.CQRS.Queries.GuideQueries;
using TravelWebSite.CQRS.Results.DestinationResults;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class GuideMediatRController : Controller
    {
       private readonly IMediator _mediator;
     
        public GuideMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> GetGuides(int id)
        {
            var values = await _mediator.Send(new GetGuideByIdQuery(id));
            return View(values);
        }
        //[HttpPost]
        //public async Task<IActionResult> GetGuides(int id)
        //{
        //    var values = await _mediator.Send(new GetGuideByIdQuery(id));
        //    return View(values);
        //}
        [HttpGet]
        public IActionResult AddGuide() { return View(); }
        [HttpPost]
        public async Task<IActionResult> AddGuide(CreateGuideCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
