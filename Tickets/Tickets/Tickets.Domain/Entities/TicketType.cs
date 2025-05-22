using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Domain.Entities
{
    public class TicketType
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public Event Event { get; set; } = new Event();
        List<ticket> Tickets { get; set; } = new List<ticket>();
            
    }
}
