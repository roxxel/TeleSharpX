// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class UnpinAllGeneralForumTopicMessages
{
    /// <summary>
    /// Use this method to clear the list of pinned messages in a General forum topic. The bot must be an administrator in the chat for this to work and must have the can_pin_messages administrator right in the supergroup. Returns True on success.
    ///</summary>
    public static async Task<bool> UnpinAllGeneralForumTopicMessagesAsync(this TelegramClient cl, long chatId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId
        };
        var resp = await api.Send<bool>("unpinAllGeneralForumTopicMessages", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
