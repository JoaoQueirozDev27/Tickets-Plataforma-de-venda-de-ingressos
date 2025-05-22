using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tickets.Domain.Entities;
using Tickets.Application.DTO;
using Tickets.Infrastructure.Repository.Interfaces;
using Ticket.Application.Mapping;
using Tickets.Domain.Interfaces;

namespace Tickets.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertiserController : ControllerBase
    {
        private readonly IAdvertiserRepository _advertiserRepository;
        private readonly Mapping _mapping;

        public AdvertiserController(IAdvertiserRepository advertiserRepository,Mapping mapping)
        {
            _mapping = mapping;
            _advertiserRepository = advertiserRepository;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<AdvertiserDTO>> Get(string email) {
            try
            {
                advertiser advertiser = await _advertiserRepository.Get(email);
                AdvertiserDTO AdvertiserDTO = _mapping.Convert<advertiser,AdvertiserDTO>(advertiser);

                if(AdvertiserDTO == null)
                    return NotFound();
                else
                    return Ok(AdvertiserDTO);
            }
            catch
            {
                return StatusCode(500, "Erro na consulta");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Create(AdvertiserDTO advertiser)
        {
            try
            {
                await _advertiserRepository.Create(_mapping.Convert<AdvertiserDTO,advertiser>(advertiser));
                return Ok();
            }
            catch
            {
               return StatusCode(500, "Erro na criação");
            }
        }

        [HttpPut]
        public async Task<ActionResult> Update(AdvertiserDTO advertiser)
        {
            try
            {
                _advertiserRepository.Update(_mapping.Convert<AdvertiserDTO,advertiser>(advertiser));
                return Ok();
            }
            catch
            {
                return StatusCode(500, "Erro na criação");
            }
        }
    }
}
