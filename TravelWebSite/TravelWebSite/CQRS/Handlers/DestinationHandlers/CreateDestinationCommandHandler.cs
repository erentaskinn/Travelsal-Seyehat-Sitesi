using Travel_DataAccessLayer.Concerate;
using Travels_EntityLayer.Concrete;
using TravelWebSite.CQRS.Commands.DestinationCommands;

namespace TravelWebSite.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;
        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                City = command.City,
                Price = command.Price,
                DateNight = command.DateNight,
                Capacity = command.Capacity,
                Status =true
            });
            _context.SaveChanges();
        }
    }
}
