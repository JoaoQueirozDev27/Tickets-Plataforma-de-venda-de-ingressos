using Tickets.Domain.Entities;

namespace Tickets.Infrastructure.Repository.Interfaces
{
    public interface IAdvertiserRepository
    {
        Task Create(advertiser advertiser);
        Task Delete(advertiser advertiser);
        Task Update(advertiser advertiser);
        Task<advertiser> Get(string Email);
    }
}
