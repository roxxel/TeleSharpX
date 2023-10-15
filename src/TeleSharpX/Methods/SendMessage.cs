// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendMessage
{
    /// <summary>
    /// Use this method to send text messages. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendMessageAsync(this TelegramClient cl, long chatId, string text, long? messageThreadId = null, ParseMode parseMode = ParseMode.MarkdownV2, System.Collections.Generic.IEnumerable<MessageEntity>? entities = null, bool? disableWebPagePreview = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            text = text,
            message_thread_id = messageThreadId,
            parse_mode = parseMode.ToString(),
            entities = entities,
            disable_web_page_preview = disableWebPagePreview,
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("sendMessage", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
