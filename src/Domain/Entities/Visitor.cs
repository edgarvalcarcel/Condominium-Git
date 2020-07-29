using System.Collections.Generic;

namespace Condominium.Domain.Entities
{
    public class Visitor
    {
        public int Id { get; set; }
        public string DocumentId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MobilePhone { get; set; }

        public virtual ICollection<VisitorLog> VisitorLogs { get; private set; }
    }
}