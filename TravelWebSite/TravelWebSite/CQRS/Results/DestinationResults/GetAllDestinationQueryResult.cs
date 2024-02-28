namespace TravelWebSite.CQRS.Results.DestinationResults
{
    public class GetAllDestinationQueryResult
    {
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string DateNight { get; set; }
        public double Price { get; set; }
        public int Capacity { get; set; }
    }
}
