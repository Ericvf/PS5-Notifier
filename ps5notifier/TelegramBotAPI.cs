using System;
using System.IO;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InputFiles;

namespace TelegramBotsApp
{
    public interface ITelegramApi
    {
        Task<long> SendTextMessageAsync(long chatId, string message);

        Task<long> SendMarkdownMessageAsync(long chatId, string message, bool disableWebPagePreview, bool disableNotification);

        Task DeleteMessageAsync(long chatId, long messageId);

        Task EditMessageAsync(long chatId, long messageId, string message);

        Task SendVideoAsync(long chatId, string url, string message);

        Task ForwardMessageAsync(long chatId, long id, long messageId);

        Task<long> SendStreamAsync(long chatId, Stream stream, string name, string message);
    }

    public class TelegramBotAPI : ITelegramApi
    {
        private readonly ITelegramBotClient _api;

        public TelegramBotAPI(string apiKey)
        {
            _api = new TelegramBotClient(apiKey);
        }

        public ITelegramBotClient Api => _api;

        public Task DeleteMessageAsync(long chatId, long messageId)
        {
            return _api.DeleteMessageAsync(chatId, (int)messageId);
        }

        public Task EditMessageAsync(long chatId, long messageId, string message)
        {
            return _api.EditMessageTextAsync(chatId, (int)messageId, message);
        }

        public Task ForwardMessageAsync(long chatId, long fromChatId, long messageId)
        {
            return _api.ForwardMessageAsync(chatId, fromChatId, (int)messageId);
        }

        public async Task<long> SendStreamAsync(long chatId, Stream stream, string name, string message)
        {
            var file = new InputOnlineFile(stream, name);
            var result = await _api.SendPhotoAsync(chatId, file, caption: message);
            return result.MessageId;
        }

        public async Task<long> SendTextMessageAsync(long chatId, string message)
        {
            var result = await _api.SendTextMessageAsync(chatId, message);
            return result.MessageId;
        }

        public async Task<long> SendMarkdownMessageAsync(long chatId, string message, bool disableWebPagePreview, bool disableNotification)
        {
            var result = await _api.SendTextMessageAsync(chatId, message, ParseMode.Markdown, disableWebPagePreview: disableWebPagePreview, disableNotification: disableNotification);
            return result.MessageId;
        }

        public Task SendVideoAsync(long chatId, string url, string message)
        {
            var file = new InputOnlineFile(new Uri(url));
            return _api.SendVideoAsync(chatId, file, caption: message);
        }
    }
}
