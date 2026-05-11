using ChatBot.Dtos;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using Koffeebot.Commands;

namespace ChatBot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UpdateController : ControllerBase
    {
        private readonly TelegramUpdateProcessor _processor;

        public UpdateController(TelegramUpdateProcessor processor)
        {
            _processor = processor;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello world!");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TelegramUpdate update)
        {
            Console.WriteLine(update?.Message?.Text);
            if (!ModelState.IsValid)
                return BadRequest();
            _ = Task.Run(() => _processor.HandleAsync(update));
            return Ok();
        }
    }
}