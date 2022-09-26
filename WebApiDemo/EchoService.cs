using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo
{
    [Route("api")]
    [ApiController]
    public class EchoService : ControllerBase
    {
        // Echo service api call
        // GET: api/<Echo>
        [HttpGet("{message}")]
        public IActionResult Echo([FromQuery] string? message = "Send a message..")
        {
            return Ok(message);
        }

        // Default message for Get api call
        // GET: api/
        [HttpGet]
        public IActionResult Error()
        {
            return NotFound("Some Error Occured..");
        }

    }
}
