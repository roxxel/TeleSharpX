// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendAnimation
{
    /// <summary>
    /// Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned. Bots can currently send animation files of up to 50 MB in size, this limit may be changed in the future.
    ///</summary>
    public static async Task<Message> SendAnimationAsync(this TelegramClient cl, long chatId, InputFile animation, long? messageThreadId = null, long? duration = null, long? width = null, long? height = null, InputFile? thumbnail = null, string? caption = null, ParseMode parseMode = ParseMode.MarkdownV2, System.Collections.Generic.IEnumerable<MessageEntity>? captionEntities = null, bool? hasSpoiler = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            animation = animation.ToBody(),
            message_thread_id = messageThreadId,
            duration = duration,
            width = width,
            height = height,
            thumbnail = thumbnail.ToBody(),
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
        var resp = await api.Send<Message>("sendAnimation", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
