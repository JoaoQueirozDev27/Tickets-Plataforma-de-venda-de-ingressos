using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Entities;
using Tickets.Infrastructure.Context;
using Tickets.Infrastructure.Repository.Interfaces;

namespace Tickets.Infrastructure.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly TicketsDbContext _context;
        public EventRepository(TicketsDbContext context)
        {
            _context = context;
        }

        public async Task Create(Event Event)
        {
            _context.events.Add(Event);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Event>> GetEvents()
        {
            var events = await _context.events.Where(e => e.EndDate < DateTime.Today).ToListAsync();
            return events;
        }

        public async Task<List<Event>> GetEventsByAdvertiser(Guid id)
        {
            var events = await _context.events.Where(e => e.EndDate < DateTime.Today && e.advertiserID == id).ToListAsync();
            return events;
        }

        public async Task<int> GetNewId()
        {
            var lastEvent = await _context.events
            .OrderByDescending(e => e.Id)
            .Select(e => e.Id)
            .FirstOrDefaultAsync();

            int newId = lastEvent == null ? 0 : lastEvent + 1;
            return newId;
        }
    }
}
