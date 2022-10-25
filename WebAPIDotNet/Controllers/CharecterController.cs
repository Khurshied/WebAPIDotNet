using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPIDotNet.DTO;
using WebAPIDotNet.Service;

namespace WebAPIDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharecterController : ControllerBase
    {
        private readonly ICharecterService _charecterService;
        public CharecterController(ICharecterService charecterService)
        {
            _charecterService = charecterService;
        }




        [HttpGet(Name = "GetSingle")]
        public async Task<ActionResult<ServiceResponse< GetCharecterDTO>>> GetSingle()
        {
            var result = await _charecterService.GetSingleCharecter();
            return Ok(result);
        }






    }
}
