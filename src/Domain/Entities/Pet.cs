using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities
{
    public class Pet
    {
        public int Id { get; set; }
        public int PetTypeId { get; set; }
        public int BreeId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int? ResidentId { get; set; }
        public int? VisitorId { get; set; }
        public int StatusId { get; set; }
        public Boolean IsPotentiallyDangerous { get; set; }

        public virtual PetType PetType { get; set; }
        public virtual Breed Breed { get; set; }

        public virtual Resident Resident { get; set; }
        public virtual Visitor Visitor { get; set; }
        public virtual Status Status { get; set; }

        //public virtual ICollection<Leasing> Leasings { get; private set; }
        //public virtual ICollection<Pet> Pets { get; private set; }
        //public virtual ICollection<Vehicle> Vehicles { get; private set; }
    }
}