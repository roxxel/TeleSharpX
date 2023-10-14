// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class EditGeneralForumTopic
{
    /// <summary>
    /// Use this method to edit the name of the &apos;General&apos; topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have can_manage_topics administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> EditGeneralForumTopicAsync(this TelegramClient cl, long chatId, string name)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			name = name
		};
        var resp = await api.Send<bool>("editGeneralForumTopic", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
