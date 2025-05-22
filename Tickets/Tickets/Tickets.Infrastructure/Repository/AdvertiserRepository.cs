using Microsoft.EntityFrameworkCore;
using Tickets.Domain.Entities;
using Tickets.Infrastructure.Context;
using Tickets.Infrastructure.Repository.Interfaces;

namespace Tickets.Infrastructure.Repository
{
    public class AdvertiserRepository : IAdvertiserRepository
    {
        public readonly TicketsDbContext _context;

        public AdvertiserRepository(TicketsDbContext context)
        {
            _context = context;
        }

        public async Task Create(advertiser advertiser)
        {
            try
            {
                _context.advertisers.Add(advertiser);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new Exception("Error: Not possible to acess the database(Create)");
            }
        }

        public async Task Delete(advertiser advertiser)
        {
            try
            {
                _context.Remove(advertiser);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new Exception("Error: Not possible to acess the database(Delete)");
            }
        }

        public async Task<advertiser> Get(string Email)
        {
            try
            {
                var advertiser = await _context.advertisers.SingleOrDefaultAsync(x => x.Email == Email);
                return advertiser;
            }
            catch
            {
                throw new Exception("Error: Not possible to acess the database(get)");
            }
        }

        public async Task Update(advertiser advertiser)
        {
            try
            {
                _context.advertisers.Update(advertiser);
            }
            catch
            {
                throw new Exception("Error: Not possible to acess the database(Update)");
            }
        }
    }
}
