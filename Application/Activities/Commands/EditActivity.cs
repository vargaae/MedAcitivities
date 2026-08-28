using Domain;
using MediatR;
using Persistence;
using AutoMapper;

namespace Application.Activities.Commands;

public class EditActivity
{
    public class Command : IRequest
    {
public required Activity Activity { get; set; }

    }

    public class Handler(AppDbContext context, IMapper mapper) : IRequestHandler<Command>
    {
        public async Task Handle(Command request, CancellationToken cancellationToken)
        {
            var activity = await context.Activities
            .FindAsync([request.Activity.Id], cancellationToken) ?? throw new Exception("Activity not found");

            mapper.Map(request.Activity, activity);

            // activity.Title = request.Activity.Title; // -> Automappert-> ezt ahelyett használjuk a mapper-t, ami automatikusan átviszi az értékeket a request.Activity-ből az activity-be

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}
