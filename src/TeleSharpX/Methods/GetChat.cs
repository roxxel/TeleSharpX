// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetChat
{
    /// <summary>
    /// Use this method to get up to date information about the chat (current name of the user for one-on-one conversations, current username of a user, group or channel, etc.). Returns a Chat object on success.
    ///</summary>
    public static async Task<Chat> GetChatAsync(this TelegramClient cl, long chatId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId
        };
        var resp = await api.Send<Chat>("getChat", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
