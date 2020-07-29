using Condominium.Domain.Common;
using System;
using System.Collections.Generic;

namespace Condominium.Domain.Entities
{
    public class Resident : AuditableEntity
    {
        public int Id { get; set; }
        public string IdDocument { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public int StateId { get; set; }
        public int PartnerId { get; set; }
        public int ContactId { get; set; }
        public Boolean IsOwner { get; set; }
        public int StatusId { get; set; }
        public string Fingerprint { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual Status Status { get; set; }
        public virtual Resident Partner { get; set; }
        public virtual State State { get; set; }

        public virtual ICollection<PropertyOwner> Properties { get; private set; }
        public virtual ICollection<Leasing> Leasings { get; private set; }
        public virtual ICollection<Pet> Pets { get; private set; }
        public virtual ICollection<Vehicle> Vehicles { get; private set; }
        //public ICollection<VisitorLog> VisitorLogs { get; private set; }
    }
}