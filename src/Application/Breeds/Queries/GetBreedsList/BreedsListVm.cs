using System;
using System.Collections.Generic;
using System.Text;

namespace Condominium.Application.Breeds.Queries.GetBreedsList
{
    public class BreedsListVm
    {
        public IList<BreedsDto> Breeds { get; set; }

        public int Count { get; set; }
    }
}
