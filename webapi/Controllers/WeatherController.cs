using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers
{
    [Route("api")]
    [ApiController]
    public class WeatherController : Controller
    {
        [HttpGet("weather")]
        public async Task<IActionResult> HelloWorld()
        {
            return Ok("Hello World Dude");
        }
    }
}
