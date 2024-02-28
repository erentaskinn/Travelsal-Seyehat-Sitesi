using Travel_DataAccessLayer.Concerate;
using TravelWebSite.CQRS.Queries.DestinationQueries;
using TravelWebSite.CQRS.Results.DestinationResults;

namespace TravelWebSite.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIdQueryHandler
    {
        private readonly Context _context;
        public GetDestinationByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public GetDestinationByIDQueryResult Handle(GetDestinationByIdQuery query)
        {
            var values = _context.Destinations.Find(query.Id);
            return new GetDestinationByIDQueryResult
            {
                DestinationId = values.DestinationId,
                City = values.City,
                DateNight = values.DateNight,
                Price=values.Price
            };
        }
    }
}
