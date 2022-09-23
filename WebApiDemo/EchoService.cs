using Microsoft.AspNetCore.Mvc;

namespace WebApiDemo
{
    [Route("api")]
    [ApiController]
    public class EchoService : ControllerBase
    {
        // GET: api/<Echo>
        [HttpGet("{message}")]
        public IActionResult Echo([FromQuery] string? message = "Send a message..")
        {
            return Ok(message);
        }

        // Default error message for worng path
        // GET: api/
        [HttpGet]
        public IActionResult Error()
        {
            return NotFound("Some Error Occured..");
        }

    }
}
