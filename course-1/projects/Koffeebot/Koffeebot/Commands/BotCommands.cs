using ChatBot.Dtos;
using Telegram.Bot;

namespace Koffeebot.Commands
{
    public interface IBotCommand
    {
        string Trigger { get; }
        Task ExecuteAsync(TelegramUpdate update, ITelegramBotClient bot, long chatId);

    }
    public class StartCommand : IBotCommand
    {
        public string Trigger => "/start";
        public async Task ExecuteAsync(TelegramUpdate update, ITelegramBotClient bot, long chatId)
        {
            await bot.SendMessage(chatId, "Привет! Я OpenAI-бот. Отправь сообщение -- я передам его сторонней модели и верну ответ.\n/help для списка команд.");
        }

    }

    public class HelpCommand : IBotCommand
    {
        public string Trigger => "/help";
        public async Task ExecuteAsync(TelegramUpdate update, ITelegramBotClient bot, long chatId)
        {
            await bot.SendMessage(chatId, "Список доступных команд: \n/start - начало работы.");
        }

    }

    public class TelegramUpdateProcessor
    {
        private readonly IEnumerable<IBotCommand> _commands;
        private readonly ITelegramBotClient _botClient;

        public TelegramUpdateProcessor(
            IEnumerable<IBotCommand> commands,
            ITelegramBotClient botClient)
        {
            _commands = commands;
            _botClient = botClient;
        }

        public async Task HandleAsync(TelegramUpdate update)
        {
            if (update.Message == null)
                return;

            var chatId = update.Message.Chat.Id;
            var text = update.Message.Text?.Trim();

            if (text == null) return;

            if (text.StartsWith("/"))
            {
                var cmd = text.Split(' ', 2)[0];
                var command = _commands.FirstOrDefault(c => c.Trigger.Equals(cmd, StringComparison.OrdinalIgnoreCase));
                if (command != null)
                {
                    await command.ExecuteAsync(update, _botClient, chatId);
                    return;
                }
                else
                {
                    await _botClient.SendMessage(chatId, "Неизвестная команда. Используйте /help");
                    return;
                }
            }
        }
    }
}