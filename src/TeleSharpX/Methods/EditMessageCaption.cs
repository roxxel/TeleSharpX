// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class EditMessageCaption
{
    /// <summary>
    /// Use this method to edit captions of messages. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
    ///</summary>
    public static async Task<Message> EditMessageCaptionAsync(this TelegramClient cl, long? chatId = null, long? messageId = null, string? inlineMessageId = null, string? caption = null, ParseMode parseMode = ParseMode.MarkdownV2, System.Collections.Generic.IEnumerable<MessageEntity>? captionEntities = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            message_id = messageId,
            inline_message_id = inlineMessageId,
            caption = caption,
            parse_mode = parseMode.ToString(),
            caption_entities = captionEntities,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("editMessageCaption", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
