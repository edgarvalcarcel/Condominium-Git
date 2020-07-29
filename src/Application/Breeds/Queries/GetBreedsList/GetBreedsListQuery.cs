using AutoMapper;
using AutoMapper.QueryableExtensions;
using Condominium.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace Condominium.Application.Breeds.Queries.GetBreedsList
{
    public class GetBreedsListQuery : IRequest<BreedsListVm>
    {
        public class GetBreedsQueryHandler : IRequestHandler<GetBreedsListQuery, BreedsListVm>
        {
            private readonly IApplicationDbContext _context;
            private readonly IMapper _mapper;

            public GetBreedsQueryHandler(IApplicationDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<BreedsListVm> Handle(GetBreedsListQuery request, CancellationToken cancellationToken)
            {
                var vm = new BreedsListVm
                {
                    Breeds = await _context.Breed
                    .ProjectTo<BreedsDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.Name)
                    .ToListAsync(cancellationToken)
                };

                return vm;
            }
        }
    }
}
