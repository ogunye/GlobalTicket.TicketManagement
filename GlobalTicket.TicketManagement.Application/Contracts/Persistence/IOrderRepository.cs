using GlobalTicket.TicketManagement.Domain.Entites;

namespace GlobalTicket.TicketManagement.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
