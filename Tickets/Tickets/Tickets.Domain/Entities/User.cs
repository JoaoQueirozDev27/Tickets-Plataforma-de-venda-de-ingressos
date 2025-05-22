using System.ComponentModel.DataAnnotations;

namespace Tickets.Domain.Entities
{
    public abstract class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [MinLength(0)]
        [MaxLength(14)]
        public string Document { get; set; } = string.Empty;

        [MinLength(3)]
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [MinLength(8)]
        public string Password { get; set; } = string.Empty;

        public User(string document, string name, string email, string password)
        {
            Id = new Guid();
            Document = document;
            Name = name;
            Email = email;
            Password = password;
        }

        public User(Guid id, string document, string name, string email, string password)
        {
            Id = id;
            Document = document;
            Name = name;
            Email = email;
            Password = password;
        }

        public User(){}
    }
}
