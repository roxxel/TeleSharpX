// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendVoice
{
    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display the file as a playable voice message. For this to work, your audio must be in an .OGG file encoded with OPUS (other formats may be sent as Audio or Document). On success, the sent Message is returned. Bots can currently send voice messages of up to 50 MB in size, this limit may be changed in the future.
    ///</summary>
    public static async Task<Message> SendVoiceAsync(this TelegramClient cl, long chatId, InputFile voice, long? messageThreadId = null, string? caption = null, ParseMode parseMode = ParseMode.MarkdownV2, System.Collections.Generic.IEnumerable<MessageEntity>? captionEntities = null, long? duration = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            voice = voice.ToBody(),
            message_thread_id = messageThreadId,
            caption = caption,
            parse_mode = parseMode.ToString(),
            caption_entities = captionEntities,
            duration = duration,
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("sendVoice", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
