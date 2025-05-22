using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Tickets.Infrastructure.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Tickets.Infrastructure
{
    public class DbContextFactory : IDesignTimeDbContextFactory<TicketsDbContext>
    {
        public TicketsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("Dbsettings.json")
            .Build();

            DbContextOptionsBuilder<TicketsDbContext> options = new DbContextOptionsBuilder<TicketsDbContext>();
            options.UseSqlServer(configuration.GetConnectionString("defaultConnection"));

            return new TicketsDbContext(options.Options);
        }
    }
}
