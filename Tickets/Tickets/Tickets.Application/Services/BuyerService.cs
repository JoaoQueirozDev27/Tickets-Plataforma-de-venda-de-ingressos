using Tickets.Application.DTO;
using Tickets.Domain.Entities;
using Tickets.Infrastructure.Context;
using Tickets.Infrastructure.Repository;
using Tickets.Infrastructure.Repository.Interfaces;

namespace Tickets.Application.Services
{
    public class BuyerService
    {
        private readonly IBuyerRepository _buyerRepo;
        private readonly TicketsDbContext _context;

        public BuyerService(IBuyerRepository buyerRepository, TicketsDbContext context)
        {
            _buyerRepo = buyerRepository;
            _context = context;
        }

        public async Task Buy(ticketbuyingDTO ticketbuyingDTO)
        {
            Buyer buyer = await _context.buyers.FindAsync(ticketbuyingDTO.BuyerId);
            Event Event = await _context.events.FindAsync(ticketbuyingDTO.EventId);

            if (buyer == null || Event == null)
                throw new Exception("Buyer or Event not found");

            for (int i = 0; i < ticketbuyingDTO.qt; i++)
            {
                var LastTicket = _context.Tickets.LastOrDefault(x => x.Event.Id == Event.Id);

                int newId = LastTicket == null ? 0 : LastTicket.Id + 1;

                TicketType ticketType = _context.ticketTypes.FirstOrDefault(x => x.Id == ticketbuyingDTO.ticketType
                && x.Event.Id == Event.Id);

                ticket ticket = new ticket(newId, ticketbuyingDTO.Price, ticketType, buyer, Event);

                _buyerRepo.BuyTicket(ticket);
            }
        }

    }
}
