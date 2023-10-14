// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetChatMemberCount
{
    /// <summary>
    /// Use this method to get the number of members in a chat. Returns Int on success.
    ///</summary>
    public static async Task<long> GetChatMemberCountAsync(this TelegramClient cl, long chatId)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId
		};
        var resp = await api.Send<long>("getChatMemberCount", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
