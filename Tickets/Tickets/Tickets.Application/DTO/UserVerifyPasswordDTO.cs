using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Application.DTO
{
    public class UserDTOVerifyPassword
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [MinLength(8)]
        public string Password { get; set; } = string.Empty;
    }
}
