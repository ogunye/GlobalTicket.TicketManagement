using GlobalTicket.TicketManagement.Domain.Common;

namespace GlobalTicket.TicketManagement.Domain.Entites
{
    public class Category : AuditableEntitiy
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<Event>? Events { get; set; }
    }
}