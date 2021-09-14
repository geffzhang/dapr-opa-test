using System;
using Microsoft.AspNetCore.Mvc;

namespace Example.Bar.Api.Controllers
{
    [Route("bar")]
    [ApiController]
    public class BarCommandApiController : ControllerBase
    {
        public record Echo(string Message);
        
        [HttpPost]
        public object Bar(Echo input) => new Echo(Reverse(input.Message));

        private string Reverse(string src)
        {
            var a = src.ToCharArray();
            Array.Reverse(a);
            return new String(a);
        }
    }
}