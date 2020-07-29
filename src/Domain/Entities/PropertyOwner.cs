using System;

namespace Condominium.Domain.Entities
{
    public class PropertyOwner
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int ResidentId { get; set; }
        public Boolean IsMainOwner { get; set; }
        public DateTime AcquiredDate { get; set; }
        public DateTime? SellingDate { get; set; }

        public virtual Property Property { get; set; }
        public virtual Resident Resident { get; set; }
    }
}