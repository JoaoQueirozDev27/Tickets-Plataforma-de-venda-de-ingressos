using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Application.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [MinLength(0)]
        [MaxLength(14)]
        public string Document { get; set; } = string.Empty;

        [MinLength(3)]
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
