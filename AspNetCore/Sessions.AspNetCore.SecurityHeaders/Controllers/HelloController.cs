using Microsoft.AspNetCore.Mvc;

namespace Sessions.AspNetCore.SecurityHeaders.Controllers
{
    [Route("hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "hello, world";
        }
    }
}