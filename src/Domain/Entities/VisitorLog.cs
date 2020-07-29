using System;

namespace Condominium.Domain.Entities
{
    public class VisitorLog
    {
        public int Id { get; set; }
        public int VisitorId { get; set; }
        public int PropertyId { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime? DismissalTime { get; set; }
        public int ResidentApprovingId { get; set; }
        public string IndexCard { get; set; }
        public string VisitorParkingId { get; set; }

        public virtual Visitor Visitor { get; set; }
        public virtual Property Property { get; set; }
        public virtual Resident ResidentApproving { get; set; }
        public virtual VisitorParking VisitorParking { get; set; }
    }
}