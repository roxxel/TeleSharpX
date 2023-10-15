// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class ForwardMessage
{
    /// <summary>
    /// Use this method to forward messages of any kind. Service messages can&apos;t be forwarded. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> ForwardMessageAsync(this TelegramClient cl, long chatId, long fromChatId, long messageId, long? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            from_chat_id = fromChatId,
            message_id = messageId,
            message_thread_id = messageThreadId,
            disable_notification = disableNotification,
            protect_content = protectContent
        };
        var resp = await api.Send<Message>("forwardMessage", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
