using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Application.DTO
{
    public class EventDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public Guid advertiserID { get; set; }
    }
}
