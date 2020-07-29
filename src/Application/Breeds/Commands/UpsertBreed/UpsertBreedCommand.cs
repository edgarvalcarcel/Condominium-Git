using Condominium.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Condominium.Domain.Entities;


namespace Condominium.Application.Breeds.Commands.UpsertBreed
{
    public class UpsertBreedCommand : IRequest<int>
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public class UpsertBreedCommandHandler : IRequestHandler<UpsertBreedCommand, int>
        {
            private readonly IApplicationDbContext _context;
            public UpsertBreedCommandHandler(IApplicationDbContext context)
            {
                _context = context;
            }

            async Task<int> IRequestHandler<UpsertBreedCommand, int>.Handle(UpsertBreedCommand request, CancellationToken cancellationToken)
            {
                Breed entity;
                if (request.Id.HasValue)
                {
                    entity = await _context.Breed.FindAsync(request.Id.Value);
                }
                else
                {
                    entity = new Breed();
                    _context.Breed.Add(entity);
                }

                entity.Name = request.Name;
                await _context.SaveChangesAsync(cancellationToken);
                return entity.Id;
            } 
        }
    }
}
