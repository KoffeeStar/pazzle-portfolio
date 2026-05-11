# Практика №19
Уровень 1
1. Запуск проекта с прошлого урока
2. Очистка проекта
- Удалите файлы WeatherForecast и WeatherForecastController, созданные шаблоном.
3. Установите nuget-пакет Telegram.Bot версии 19.0.0 (при более высокой код из практики может не заработать)
- В Program.cs необходимо добавить токен, полученный на предыдущем уроке:
```
var telegramToken = "BOT_TOKEN";

builder.Services.AddSingleton<ITelegramBotClient>(sp => new TelegramBotClient(telegramToken));
```
4. Добавим контроллер и реализуем простые запросы
```
[ApiController]
[Route("api/[controller]")]
public class UpdateController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok("Hello world!");
    }

    [HttpPost]
    public async Task<IActionResult> Post(string test)
    {
        Console.WriteLine(test);
        return Ok(test);
    }
}
```
5. Запустите приложение, протестируйте запросы.
6. Обновим POST запрос
```
 [HttpPost]
 public async Task<IActionResult> Post([FromBody] Update update)
 {
     Console.WriteLine("Hello");
     return Ok();
 }
```

Уровень 2
7. Запустите приложение, рассмотрите объект Update из Telegram.Bot
- Когда пользователь взаимодействует с ботом, Telegram фиксирует это как событие. Любое такое событие Telegram передает приложению в виде объекта Update.
На следующих занятиях реализуем механизм для получения запросов от Телеграмма.