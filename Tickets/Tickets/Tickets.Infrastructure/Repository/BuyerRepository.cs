using Tickets.Domain.Entities;
using Tickets.Infrastructure.Context;
using Tickets.Infrastructure.Repository.Interfaces;

namespace Tickets.Infrastructure.Repository
{
    public class BuyerRepository : IBuyerRepository
    {
        private readonly TicketsDbContext _context;

        public BuyerRepository(TicketsDbContext context)
        {
            _context = context;
        }

        public async Task BuyTicket(ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChangesAsync();
        }
    }
}
