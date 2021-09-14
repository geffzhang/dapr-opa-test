using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Example.Foo.Api.Controllers
{
    using Dapr.Client;

    [Route("foo")]
    [ApiController]
    public class FooCommandApiController : ControllerBase
    {
        public record Echo(string Message);

        private readonly DaprClient daprClient;

        public FooCommandApiController(DaprClient daprClient)
        {
            this.daprClient = daprClient;
        }

        [HttpPost]
        public async Task<object> GetBar(Echo echo)
        {
            return await daprClient.InvokeMethodAsync<Echo, object>("bar-service", "bar", echo);
        }
    }
}