using ConsumoResponsableApi.Utils.Enums;
using ConsumoResponsableApi.Utils.Exceptions;
using ConsumoResponsableApi.Utils.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsumoResponsableApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAsync()
        {
            
            return Ok(new Response());
        }
    }

    public class Response
    {
        public int Code { get; set; } = 100;
        public string Message { get; set; } = "MMM YA ";
         
    }
}
