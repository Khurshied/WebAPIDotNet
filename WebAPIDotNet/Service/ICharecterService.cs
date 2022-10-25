using WebAPIDotNet.DTO;
using WebAPIDotNet.Models;
namespace WebAPIDotNet.Service

{
    public interface ICharecterService
    {
        Task<ServiceResponse<GetCharecterDTO>> GetSingleCharecter();
    }
}
