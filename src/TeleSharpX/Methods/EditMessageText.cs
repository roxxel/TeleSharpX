// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class EditMessageText
{
    /// <summary>
    /// Use this method to edit text and game messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
    ///</summary>
    public static async Task<Message> EditMessageTextAsync(this TelegramClient cl, string text, long? chatId = null, long? messageId = null, string? inlineMessageId = null, ParseMode parseMode = ParseMode.MarkdownV2, System.Collections.Generic.IEnumerable<MessageEntity>? entities = null, bool? disableWebPagePreview = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            text = text,
            chat_id = chatId,
            message_id = messageId,
            inline_message_id = inlineMessageId,
            parse_mode = parseMode.ToString(),
            entities = entities,
            disable_web_page_preview = disableWebPagePreview,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("editMessageText", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
