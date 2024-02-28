namespace TravelWebSite.CQRS.Results.DestinationResults
{
    public class GetDestinationByIDQueryResult
    {
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string DateNight { get; set; }
        public double Price { get; set; }
    }
}
