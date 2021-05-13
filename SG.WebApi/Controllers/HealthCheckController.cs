using Microsoft.AspNetCore.Mvc;

namespace SG.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Test()
        {
            return new JsonResult("Application is up and running ...");
        }
    }
}
