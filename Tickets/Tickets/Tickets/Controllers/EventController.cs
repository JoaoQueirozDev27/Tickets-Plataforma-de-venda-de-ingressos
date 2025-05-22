using Microsoft.AspNetCore.Mvc;
using Tickets.Application.DTO;
using Tickets.Application.Services;

namespace Tickets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly EventService _eventService;
        public EventController(EventService eventService) {
            _eventService = eventService;
        }    

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [Route("/GetEvents")]
        [HttpGet]
        public async Task<ActionResult<List<EventDTO>>> GetEvents()
        {
            try
            {
                var events = _eventService.GetEvents().Result;
                return events;
            }
            catch
            {
                return StatusCode(500, "Erro na consulta");
            }
        }

        [Route("/GetEventsByAdvertiser")]
        [HttpGet]
        public async Task<ActionResult<List<EventDTO>>> GetEventsByAdvertiser(string id)
        {
            try
            {
                var events = _eventService.GetEventsByAdvertiser(id).Result;
                return events;
            }
            catch
            {
                return StatusCode(500, "Erro na consulta");
            }
        }

        [HttpPost]
        public async void Create([FromBody] EventCreateDTO EventCreateDTO)
        {
            _eventService.Create(EventCreateDTO);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
