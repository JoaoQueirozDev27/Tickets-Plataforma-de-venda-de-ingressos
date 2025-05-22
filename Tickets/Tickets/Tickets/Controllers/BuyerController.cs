using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tickets.Application.DTO;
using Tickets.Application.Services;
using Tickets.Domain.Entities;

namespace Tickets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        public readonly BuyerService _buyerService;
        public BuyerController(BuyerService buyerService) { 
            _buyerService = buyerService;
        }

        [HttpPost]
        public async Task<ActionResult> Buy([FromBody]ticketbuyingDTO ticketbuyingDTO)
        {
            try
            {
                if (ticketbuyingDTO == null)
                    return BadRequest();

                await _buyerService.Buy(ticketbuyingDTO);

                return Ok();
            }
            catch
            {
                return StatusCode(500, "Erro na consulta");
            }
        }
    }
}
