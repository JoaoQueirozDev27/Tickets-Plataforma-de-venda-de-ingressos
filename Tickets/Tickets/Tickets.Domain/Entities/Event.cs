using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now;
        public Guid advertiserID { get; set; } 

        public Event(int Id,string Name,DateTime BeginDate,DateTime EndDate,Guid advertiserID)
        {
            this.Id = Id;
            this.Name = Name;
            this.BeginDate = BeginDate; 
            this.EndDate = EndDate;
            this.advertiserID = advertiserID;
        }

        public Event(){}
    }
}
