using AutoMapper;
using WebAPIDotNet.DTO;

namespace WebAPIDotNet
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Charecter, GetCharecterDTO>();
        }
    }
}
