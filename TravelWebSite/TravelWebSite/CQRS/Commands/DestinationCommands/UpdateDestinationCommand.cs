namespace TravelWebSite.CQRS.Commands.DestinationCommands
{
    public class UpdateDestinationCommand
    {
        public int DestinationId { get; set; }
        public string City { get; set; }
        public string DateNight { get; set; }
        public double Price { get; set; }
    }
}
