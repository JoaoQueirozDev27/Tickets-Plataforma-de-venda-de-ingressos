using AutoMapper;
using Tickets.Domain.Entities;
using Tickets.Application.DTO;

namespace Tickets.Application.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<advertiser, AdvertiserDTO>();
            CreateMap<AdvertiserDTO, advertiser>();
            CreateMap<Event, EventCreateDTO>();
            CreateMap<EventCreateDTO, Event>();
            CreateMap<Buyer, BuyerDTO>();
            CreateMap<BuyerDTO, Buyer>();
            CreateMap<ticket, TicketDTO>();
            CreateMap<TicketDTO, ticket>();
            CreateMap<TicketType, TicketTypeDTO>();
            CreateMap<TicketTypeDTO, TicketType>();
        }
    }
}
