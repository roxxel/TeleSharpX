// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetChatAdministrators
{
    /// <summary>
    /// Use this method to get a list of administrators in a chat, which aren&apos;t bots. Returns an Array of ChatMember objects.
    ///</summary>
    public static async Task<System.Collections.Generic.IEnumerable<ChatMember>> GetChatAdministratorsAsync(this TelegramClient cl, long chatId)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId
		};
        var resp = await api.Send<System.Collections.Generic.IEnumerable<ChatMember>>("getChatAdministrators", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
