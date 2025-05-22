using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Entities;

namespace Tickets.Infrastructure.Repository.Interfaces
{
    public interface IBuyerRepository
    {
        Task BuyTicket(ticket ticket);
        
    }
}
