using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Domain.Entities
{
    public class Buyer : User
    {
        public DateTime BirthDate { get; set; } = DateTime.UtcNow;
    }
}
