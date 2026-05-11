using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

[ApiController]
[Route("api/[controller]")]
public class UpdateController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("Hello world");
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Update update)
    {
        Console.WriteLine("Hello");
        return Ok();
    }
}