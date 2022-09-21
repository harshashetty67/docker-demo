using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchoService : ControllerBase
    {
        // GET: api/<EchoService>
        [HttpGet]
        public IActionResult Get([FromQuery] string? message="Hello please send message..")
        {
            return Ok(message);
        }

    }
}
