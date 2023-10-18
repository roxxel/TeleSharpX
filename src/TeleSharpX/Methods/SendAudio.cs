// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendAudio
{
    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent Message is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    ///</summary>
    public static async Task<Message> SendAudioAsync(this TelegramClient cl, long chatId, InputFile audio, long? messageThreadId = null, string? caption = null, ParseMode parseMode = ParseMode.MarkdownV2, System.Collections.Generic.IEnumerable<MessageEntity>? captionEntities = null, long? duration = null, string? performer = null, string? title = null, InputFile? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            audio = audio.ToBody(),
            message_thread_id = messageThreadId,
            caption = caption,
            parse_mode = parseMode.ToString(),
            caption_entities = captionEntities,
            duration = duration,
            performer = performer,
            title = title,
            thumbnail = thumbnail.ToBody(),
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("sendAudio", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
