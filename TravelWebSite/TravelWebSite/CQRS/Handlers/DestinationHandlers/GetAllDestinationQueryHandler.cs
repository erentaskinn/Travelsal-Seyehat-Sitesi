using Microsoft.EntityFrameworkCore;
using Travel_DataAccessLayer.Concerate;
using TravelWebSite.CQRS.Queries.DestinationQueries;
using TravelWebSite.CQRS.Results.DestinationResults;

namespace TravelWebSite.CQRS.Handlers.DestinationHandlers
{
    public class GetAllDestinationQueryHandler
    {
        private readonly Context _context;
        public GetAllDestinationQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllDestinationQueryResult> Handle()
        {
            var values = _context.Destinations.Select(x => new GetAllDestinationQueryResult
            {
                DestinationId = x.DestinationId,
                City = x.City,
                Capacity = x.Capacity,
                DateNight = x.DateNight,
                Price=x.Price

            }).AsNoTracking().ToList();
            return values;
        }
    }
}
