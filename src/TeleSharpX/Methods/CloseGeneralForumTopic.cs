// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class CloseGeneralForumTopic
{
    /// <summary>
    /// Use this method to close an open &apos;General&apos; topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> CloseGeneralForumTopicAsync(this TelegramClient cl, long chatId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId
        };
        var resp = await api.Send<bool>("closeGeneralForumTopic", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
