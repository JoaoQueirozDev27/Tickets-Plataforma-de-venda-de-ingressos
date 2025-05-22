using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tickets.Domain.Entities;

namespace Tickets.Infrastructure.Context
{
    public class TicketsDbContext : DbContext
    {
        public TicketsDbContext(DbContextOptions<TicketsDbContext> options) : base(options) {}

        public DbSet<advertiser> advertisers { get; set; }
        public DbSet<Buyer> buyers { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<ticket> Tickets { get; set; }
        public DbSet<TicketType> ticketTypes { get; set; }
    }
}
