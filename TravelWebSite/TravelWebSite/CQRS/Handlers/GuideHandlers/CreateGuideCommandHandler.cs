using MediatR;
using Travel_DataAccessLayer.Concerate;
using Travels_EntityLayer.Concrete;
using TravelWebSite.CQRS.Commands.GuideCommands;

namespace TravelWebSite.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;
        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                Name = request.Name,
                Description = request.Description,
                Image = "merhaba",
                Status = true
            }) ;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
