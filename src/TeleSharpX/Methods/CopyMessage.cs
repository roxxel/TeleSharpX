// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class CopyMessage
{
    /// <summary>
    /// Use this method to copy messages of any kind. Service messages and invoice messages can&apos;t be copied. A quiz poll can be copied only if the value of the field correct_option_id is known to the bot. The method is analogous to the method forwardMessage, but the copied message doesn&apos;t have a link to the original message. Returns the MessageId of the sent message on success.
    ///</summary>
    public static async Task<MessageId> CopyMessageAsync(this TelegramClient cl, long chatId, long fromChatId, long messageId, long? messageThreadId = null, string? caption = null, ParseMode parseMode = ParseMode.MarkdownV2, System.Collections.Generic.IEnumerable<MessageEntity>? captionEntities = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            from_chat_id = fromChatId,
            message_id = messageId,
            message_thread_id = messageThreadId,
            caption = caption,
            parse_mode = parseMode.ToString(),
            caption_entities = captionEntities,
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<MessageId>("copyMessage", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
