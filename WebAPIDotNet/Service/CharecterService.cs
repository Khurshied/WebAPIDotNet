using AutoMapper;
using WebAPIDotNet.DTO;

namespace WebAPIDotNet.Service
{
    public class CharecterService : ICharecterService
    {

        private readonly IMapper _mapper;
        public CharecterService(IMapper mapper )
        {
            _mapper = mapper;
        }

        private static List<Charecter> charecters = new List<Charecter> {
            new Charecter(),
            new Charecter{Name="Javaid"}
        };


        public async Task<ServiceResponse<GetCharecterDTO>> GetSingleCharecter()
        {
            
            var serviceResponse = new ServiceResponse<GetCharecterDTO>();
            var charecter = charecters.First();
            serviceResponse.Data = _mapper.Map<GetCharecterDTO>(charecter);
            return serviceResponse;
        }
    }
}
