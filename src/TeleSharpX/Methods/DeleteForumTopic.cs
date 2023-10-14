// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class DeleteForumTopic
{
    /// <summary>
    /// Use this method to delete a forum topic along with all its messages in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_delete_messages administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> DeleteForumTopicAsync(this TelegramClient cl, long chatId, long messageThreadId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            message_thread_id = messageThreadId
        };
        var resp = await api.Send<bool>("deleteForumTopic", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
