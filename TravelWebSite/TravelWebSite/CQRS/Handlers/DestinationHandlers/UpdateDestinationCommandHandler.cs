using DocumentFormat.OpenXml.Presentation;
using Travel_DataAccessLayer.Concerate;
using TravelWebSite.CQRS.Commands.DestinationCommands;

namespace TravelWebSite.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;
        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.DestinationId);
            values.City = command.City;
            values.DateNight = command.DateNight;
            values.Price = command.Price;
            _context.SaveChanges();


        }
    }
}
