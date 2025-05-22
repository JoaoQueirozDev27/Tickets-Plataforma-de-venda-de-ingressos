using AutoMapper;

namespace Ticket.Application.Mapping
{
    public class Mapping
    {
        private readonly IMapper _mapper;

        public Mapping(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TConverted Convert<TOriginal, TConverted>(TOriginal original)
        {
            var converted = _mapper.Map<TConverted>(original);
            return converted;
        }
    }
}
