using Microsoft.AspNetCore.Mvc;

namespace MakersTribeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JSController : Controller
    {
        [HttpGet("get")]
        public IActionResult Index()
        {
            return Ok("Welcome to Job Scanner API");
        }
    }
}
