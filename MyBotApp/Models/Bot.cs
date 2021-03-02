using MyBotApp.Models.Commands;
using System.Collections.Generic;
using Telegram.Bot;

namespace MyBotApp.Models
{
    public static class Bot
    {
        private static TelegramBotClient _client;

        private static List<Command> _commandsList;
        public static IReadOnlyList<Command> Commands
        {
            get => _commandsList.AsReadOnly();
        }

        public static TelegramBotClient Get()
        {
            if (_client != null)
            {
                return _client;
            }

            _commandsList = new List<Command>();
            _commandsList.Add(new HelloCommand());

            _client = new TelegramBotClient(AppSettings.Key);
            var hook = string.Format(AppSettings.Url, "api/message/update");
             _client.SetWebhookAsync(hook);

            return _client;
        } 
    }
}