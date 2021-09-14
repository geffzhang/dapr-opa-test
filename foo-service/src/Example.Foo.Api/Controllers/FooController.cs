using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Example.Foo.Api.Controllers
{
    using Dapr.Client;

    [Route("foo")]
    [ApiController]
    public class FooCommandApiController : ControllerBase
    {
        private readonly DaprClient daprClient;

        public FooCommandApiController(DaprClient daprClient)
        {
            this.daprClient = daprClient;
        }

        [HttpPost]
        public async Task<object> GetBar()
        {
            return await daprClient.InvokeMethodAsync<string, object>("bar-service", "bar", "");
        }
    }
}