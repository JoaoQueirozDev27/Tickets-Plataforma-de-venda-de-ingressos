using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain;
using Tickets.Domain.Entities;

namespace Tickets.Infrastructure.Repository.Interfaces
{
    public interface IEventRepository
    {
        public Task Create(Event Event);
        public Task<int> GetNewId();
        public Task<List<Event>> GetEvents();
        public Task<List<Event>> GetEventsByAdvertiser(Guid id);
    }
}
