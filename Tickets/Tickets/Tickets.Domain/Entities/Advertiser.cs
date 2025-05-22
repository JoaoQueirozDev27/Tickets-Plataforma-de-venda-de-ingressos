using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Domain.Entities
{
    public class advertiser : User
    {
        public List<Event> Events { get; set; } = new List<Event>();
        public advertiser(string Document,string Name,string Email,string Password) : base(Document,Name,Email,Password){
            Events = new List<Event>();
        }
        public advertiser()
        {

        }
    }
}
