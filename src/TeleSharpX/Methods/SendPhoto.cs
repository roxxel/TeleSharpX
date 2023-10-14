// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendPhoto
{
    /// <summary>
    /// Use this method to send photos. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendPhotoAsync(this TelegramClient cl, long chatId, InputFile photo, long? messageThreadId = null, string? caption = null, ParseMode parseMode = ParseMode.MarkdownV2, System.Collections.Generic.IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			photo = photo,
			message_thread_id = messageThreadId,
			caption = caption,
			parse_mode = parseMode.ToString(),
			caption_entities = captionEntities,
			has_spoiler = hasSpoiler,
			disable_notification = disableNotification,
			protect_content = protectContent,
			reply_to_message_id = replyToMessageId,
			allow_sending_without_reply = allowSendingWithoutReply,
			reply_markup = replyMarkup
		};
        var resp = await api.Send<Message>("sendPhoto", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
