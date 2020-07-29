using MediatR;
using Condominium.Application.Common.Exceptions;
using Condominium.Application.Common.Interfaces;
using Condominium.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Condominium.Application.Breeds.Commands.DeleteBreed
{
    public class DeleteBreedCommand : IRequest
    {
        public int Id { get; set; }
        public class DeleteBreedCommandHandler : IRequestHandler<DeleteBreedCommand>
        {
            private readonly IApplicationDbContext _context;

            public DeleteBreedCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(DeleteBreedCommand request, CancellationToken cancellationToken)
            {
                var entity = await _context.TodoItems.FindAsync(request.Id);

                if (entity == null)
                {
                    throw new NotFoundException(nameof(TodoItem), request.Id);
                }

                _context.TodoItems.Remove(entity);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
