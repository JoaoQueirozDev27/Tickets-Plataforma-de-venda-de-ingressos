using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Entities;

namespace Tickets.Application.DTO
{
    public class EventCreateDTO
    {
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid AdvertiserId { get; set; }
    }
}
