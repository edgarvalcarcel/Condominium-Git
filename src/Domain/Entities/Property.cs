using Condominium.Domain.Common;
using System.Collections.Generic;

namespace Condominium.Domain.Entities
{
    public class Property : AuditableEntity
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int Floor { get; set; }
        public int Number { get; set; }
        public int Comments { get; set; }
        public int PropertyTypeId { get; set; }
        public int StatusId { get; set; }

        public virtual Location Location { get; set; }
        public virtual PropertyType PropertyType { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<PropertyOwner> PropertyOwner { get; private set; }

        //public virtual ICollection<PropertyOwner> Properties { get; private set; }
        //public virtual ICollection<Leasing> Leasings { get; private set; }
        //public virtual ICollection<Pet> Pets { get; private set; }
        //public virtual ICollection<Vehicle> Vehicles { get; private set; }
    }
}