using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickets.Domain.Entities;

namespace Tickets.Application.DTO
{
    public class AdvertiserDTO
    {
        public UserDTO User { get; set; } = new UserDTO();
        public List<int> EventsId { get; set; } = new List<int>();
    }
}
