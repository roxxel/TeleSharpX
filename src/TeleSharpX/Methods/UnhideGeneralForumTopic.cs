// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class UnhideGeneralForumTopic
{
    /// <summary>
    /// Use this method to unhide the &apos;General&apos; topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> UnhideGeneralForumTopicAsync(this TelegramClient cl, long chatId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId
        };
        var resp = await api.Send<bool>("unhideGeneralForumTopic", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
