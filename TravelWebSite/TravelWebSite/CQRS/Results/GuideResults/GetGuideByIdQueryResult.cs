namespace TravelWebSite.CQRS.Results.GuideResults
{
    public class GetGuideByIdQueryResult
    {
        public int GuidId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
