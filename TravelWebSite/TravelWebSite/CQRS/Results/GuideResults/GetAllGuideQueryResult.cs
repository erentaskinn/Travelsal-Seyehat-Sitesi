namespace TravelWebSite.CQRS.Results.GuideResults
{
    public class GetAllGuideQueryResult
    {
        public int GuidId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
