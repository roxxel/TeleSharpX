// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class LeaveChat
{
    /// <summary>
    /// Use this method for your bot to leave a group, supergroup or channel. Returns True on success.
    ///</summary>
    public static async Task<bool> LeaveChatAsync(this TelegramClient cl, long chatId)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId
		};
        var resp = await api.Send<bool>("leaveChat", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
