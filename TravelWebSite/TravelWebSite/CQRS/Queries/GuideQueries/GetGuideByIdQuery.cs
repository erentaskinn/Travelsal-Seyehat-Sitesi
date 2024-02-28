using MediatR;
using TravelWebSite.CQRS.Results.GuideResults;

namespace TravelWebSite.CQRS.Queries.GuideQueries
{
    public class GetGuideByIdQuery:IRequest<GetGuideByIdQueryResult>
    {
        public int Id { get; set; }

        public GetGuideByIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}
