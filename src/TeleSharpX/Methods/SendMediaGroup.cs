// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendMediaGroup
{
    /// <summary>
    /// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of Messages that were sent is returned.
    ///</summary>
    public static async Task<System.Collections.Generic.IEnumerable<Message>> SendMediaGroupAsync(this TelegramClient cl, long chatId, System.Collections.Generic.IEnumerable<InputMedia> media, long? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            media = media,
            message_thread_id = messageThreadId,
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply
        };
        var resp = await api.Send<System.Collections.Generic.IEnumerable<Message>>("sendMediaGroup", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
