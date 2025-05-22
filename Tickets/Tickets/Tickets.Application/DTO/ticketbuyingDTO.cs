using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Application.DTO
{
    public class ticketbuyingDTO
    {
        public int BuyerId { get; set; }
        public int EventId { get; set; }
        public int ticketType { get; set; }
        public double Price { get; set; }
        public int qt { get; set; }
        
    }
}
