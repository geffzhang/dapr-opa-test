using Microsoft.AspNetCore.Mvc;

namespace Example.Bar.Api.Controllers
{
    [Route("bar")]
    [ApiController]
    public class BarCommandApiController : ControllerBase
    {
        [HttpPost]
        public object Bar() => new { Message =  "bar" };
    }
}