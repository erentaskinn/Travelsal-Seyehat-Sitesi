using MediatR;
using TravelWebSite.CQRS.Results.GuideResults;

namespace TravelWebSite.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {

    }
}
