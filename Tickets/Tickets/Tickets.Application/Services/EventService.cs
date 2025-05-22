using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Tickets.Application.DTO;
using Tickets.Domain.Entities;
using Tickets.Infrastructure.Context;
using Tickets.Infrastructure.Repository;
using Tickets.Infrastructure.Repository.Interfaces;

namespace Tickets.Application.Services
{
    public class EventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository eventRepository,IMapper mapper)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task Create(EventCreateDTO EventCreateDTO)
        {
            int Id = await _eventRepository.GetNewId();

            Event Event = new Event(Id, EventCreateDTO.Name, EventCreateDTO.BeginDate, EventCreateDTO.EndDate, EventCreateDTO.AdvertiserId);

            await _eventRepository.Create(Event);
        }

        public async Task<List<EventDTO>> GetEvents()
        {
            List<EventDTO> events = _eventRepository.GetEvents().Result
                .Select(e => _mapper.Map<EventDTO>(e))
                .ToList();
            
            return events;
        }

        public async Task<List<EventDTO>> GetEventsByAdvertiser(string id)
        {
            Guid AdvertiserId = Guid.Parse(id);

            var events = _eventRepository.GetEventsByAdvertiser(AdvertiserId).Result
                .Select(e => _mapper.Map<EventDTO>(e))
                .ToList(); 

            return events;
        }
    }
}
