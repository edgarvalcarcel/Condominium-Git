using Condominium.Domain.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Condominium.Domain.Entities
{
    public class Leasing : AuditableEntity
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public int ResidentTenantId { get; set; }
        public DateTime? MoveInDate { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public DateTime LeaseEndDate { get; set; }
        public int StatusId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public virtual Property Property { get; set; }
        public virtual Resident ResidentTenant { get; set; }
        public virtual Status Status { get; set; }
    }
}