using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Domain.Entities
{
    public class ticket
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public TicketType TicketType { get; set; } = new TicketType();
        public Buyer Buyer { get; set; } = new Buyer();
        public Event Event { get; set; } = new Event();

        public ticket(){}

        public ticket(int id, double Price, TicketType ticketType,Buyer buyer,Event @event)
        {
            Id = id;
            this.Price = Price;
            TicketType = ticketType;
            Buyer = buyer;
            Event = @event;
        }

        public ticket(int id)
        {
            Id = id;
        }
    }
}
