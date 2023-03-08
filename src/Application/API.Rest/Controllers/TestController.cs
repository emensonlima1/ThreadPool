using Microsoft.AspNetCore.Mvc;

namespace API.Rest.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    // GET api/values
    [HttpGet]
    // Synchronous
    public IEnumerable<string> Get()
    {
        Thread.Sleep(5000);
        return new string[] { "value1", "value2" };
    }

    // Asynchronous
    // GET api/values/5
    [HttpGet("{id}")]
    public async Task<IEnumerable<string>> Get(int id)
    {
        await Task.Delay(5000);
        return new string[] { "value1", "value2" };
    }
}
