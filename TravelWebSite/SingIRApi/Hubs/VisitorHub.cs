using Microsoft.AspNetCore.SignalR;
using SingIRApi.Model;

namespace SingIRApi.Hubs
{
    public class VisitorHub:Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }

        public async Task GetVisitor()
        {
            await Clients.All.SendAsync("ReceiveVisitorList", _visitorService.GetVisitorChartsList());
        }

    }
}
