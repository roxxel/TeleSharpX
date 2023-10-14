// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class UnpinAllForumTopicMessages
{
    /// <summary>
    /// Use this method to clear the list of pinned messages in a forum topic. The bot must be an administrator in the chat for this to work and must have the can_pin_messages administrator right in the supergroup. Returns True on success.
    ///</summary>
    public static async Task<bool> UnpinAllForumTopicMessagesAsync(this TelegramClient cl, long chatId, long messageThreadId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            message_thread_id = messageThreadId
        };
        var resp = await api.Send<bool>("unpinAllForumTopicMessages", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
