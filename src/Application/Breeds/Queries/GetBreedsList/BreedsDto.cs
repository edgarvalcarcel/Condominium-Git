using AutoMapper;
using Condominium.Application.Common.Mappings;
using Condominium.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Condominium.Application.Breeds.Queries.GetBreedsList
{
    public class BreedsDto : IMapFrom<Breed>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Breed, BreedsDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Name, opt => opt.MapFrom(s => s.Name));
        }
    }
}
