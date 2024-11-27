using Microsoft.AspNetCore.Mvc;
namespace BE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        // Phương thức GET đơn giản
        [HttpGet]
        public IActionResult GetGreeting()
        {
            return Ok("Xin chào!");
        }
    }
}
