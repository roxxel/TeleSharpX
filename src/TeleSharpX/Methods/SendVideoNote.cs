// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendVideoNote
{
    /// <summary>
    /// As of v.4.0, Telegram clients support rounded square MPEG4 videos of up to 1 minute long. Use this method to send video messages. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendVideoNoteAsync(this TelegramClient cl, long chatId, InputFile videoNote, long? messageThreadId = null, long? duration = null, long? length = null, InputFile? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            video_note = videoNote.ToBody(),
            message_thread_id = messageThreadId,
            duration = duration,
            length = length,
            thumbnail = thumbnail.ToBody(),
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("sendVideoNote", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
