// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetChatDescription
{
    /// <summary>
    /// Use this method to change the description of a group, a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> SetChatDescriptionAsync(this TelegramClient cl, long chatId, string? description = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            description = description
        };
        var resp = await api.Send<bool>("setChatDescription", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
