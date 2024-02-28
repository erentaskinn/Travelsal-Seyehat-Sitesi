namespace TravelWebSite.CQRS.Queries.DestinationQueries
{
    public class GetDestinationByIdQuery 
    {
        public GetDestinationByIdQuery(int Id)
        {
           this.Id = Id;
        }

        public int Id { get; set; }
    }
}
