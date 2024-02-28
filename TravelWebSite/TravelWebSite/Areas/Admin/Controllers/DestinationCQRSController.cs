using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelWebSite.CQRS.Commands.DestinationCommands;
using TravelWebSite.CQRS.Handlers.DestinationHandlers;
using TravelWebSite.CQRS.Queries.DestinationQueries;

namespace TravelWebSite.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _queryHandler;
        private readonly GetDestinationByIdQueryHandler _byIdQueryHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        private readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;
        private readonly UpdateDestinationCommandHandler _updateDestinationCommandHandler;
        public DestinationCQRSController(GetAllDestinationQueryHandler queryHandler, GetDestinationByIdQueryHandler byIdQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler, UpdateDestinationCommandHandler updateDestinationCommandHandler)
        {
            _queryHandler = queryHandler;
            _byIdQueryHandler = byIdQueryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;
            _updateDestinationCommandHandler = updateDestinationCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _queryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int Id) 
        {
            var values = _byIdQueryHandler.Handle(new GetDestinationByIdQuery(Id));
            return View(values);
        }
        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand command)
        {
            _updateDestinationCommandHandler.Handle(command);
          return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command);
           return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int Id)
        {
            _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(Id));
            return RedirectToAction("Index");
        }

       
    }
}
