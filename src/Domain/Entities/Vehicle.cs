namespace Condominium.Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int MakerId { get; set; }
        public int VehicleModelId { get; set; }
        public int ColorId { get; set; }
        public string Plate { get; set; }
        public int ResidentId { get; set; }
        public int VisitorId { get; set; }

        public virtual Maker Maker { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
        public virtual Color Color { get; set; }
        public virtual Resident Resident { get; set; }
        public virtual Visitor Visitor { get; set; }
    }
}