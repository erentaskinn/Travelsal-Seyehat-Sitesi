using MediatR;
using Travel_DataAccessLayer.Concerate;
using TravelWebSite.CQRS.Queries.GuideQueries;
using TravelWebSite.CQRS.Results.GuideResults;

namespace TravelWebSite.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIdQueryHandler : IRequestHandler<GetGuideByIdQuery, GetGuideByIdQueryResult>
    {
        private readonly Context _context;
        public GetGuideByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<GetGuideByIdQueryResult> Handle(GetGuideByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIdQueryResult
            {
                GuidId = values.GuidId,
                Name = values.Name,
                Description = values.Description
            };
        }
    }
}
