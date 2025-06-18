using Microsoft.AspNetCore.Mvc;

namespace dotnet_sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from test branch!");
        }
    }
}
