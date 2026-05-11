using System.Net;
using Telegram.Bot;
using Koffeebot.Commands;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var telegramToken = "8730936001:AAGP4_YBMftEOPNzia7P5PoSh8sVev0lCS0";
// var proxy = new WebProxy("socks5://124.221.156.173:443");

builder.Services.AddSingleton<ITelegramBotClient>(sp => new TelegramBotClient(telegramToken))
    ;
builder.Services.AddSingleton<IBotCommand, StartCommand>();
builder.Services.AddSingleton<IBotCommand, HelpCommand>();
builder.Services.AddSingleton<TelegramUpdateProcessor>();

builder.Services.AddControllers().AddNewtonsoftJson(options =>
{
    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Koffeebot", Version = "v1" });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();