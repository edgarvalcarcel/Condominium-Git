using Condominium.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Condominium.Domain.Entities
{
    public class Contact : AuditableEntity
    {
        //public Contact()
        //{
        //    Residents = new HashSet<Resident>();
        //}
     
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        //public ICollection<Resident> Residents { get; private set; }
    }
}