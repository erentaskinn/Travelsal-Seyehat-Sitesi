using MediatR;
using Microsoft.EntityFrameworkCore;
using Travel_DataAccessLayer.Concerate;
using TravelWebSite.CQRS.Queries.GuideQueries;
using TravelWebSite.CQRS.Results.GuideResults;

namespace TravelWebSite.CQRS.Handlers.GuideHandlers
{
    public class GetAllGuideQueryHandler:IRequestHandler<GetAllGuideQuery,List<GetAllGuideQueryResult>>
    {
        private readonly Context _context;
        public GetAllGuideQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllGuideQueryResult>> Handle(GetAllGuideQuery request, CancellationToken cancellationToken)
        {
            return await _context.Guides.Select(x => new GetAllGuideQueryResult
            {
                GuidId = x.GuidId,
                Name = x.Name,
                Description = x.Description,
                Image = x.Image
            }).AsNoTracking().ToListAsync();
        }
    }
}
