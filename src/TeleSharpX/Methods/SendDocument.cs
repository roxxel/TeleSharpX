// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendDocument
{
    /// <summary>
    /// Use this method to send general files. On success, the sent Message is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    ///</summary>
    public static async Task<Message> SendDocumentAsync(this TelegramClient cl, long chatId, InputFile document, long? messageThreadId = null, InputFile? thumbnail = null, string? caption = null, ParseMode parseMode = ParseMode.MarkdownV2, System.Collections.Generic.IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			document = document,
			message_thread_id = messageThreadId,
			thumbnail = thumbnail,
			caption = caption,
			parse_mode = parseMode.ToString(),
			caption_entities = captionEntities,
			disable_content_type_detection = disableContentTypeDetection,
			disable_notification = disableNotification,
			protect_content = protectContent,
			reply_to_message_id = replyToMessageId,
			allow_sending_without_reply = allowSendingWithoutReply,
			reply_markup = replyMarkup
		};
        var resp = await api.Send<Message>("sendDocument", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
