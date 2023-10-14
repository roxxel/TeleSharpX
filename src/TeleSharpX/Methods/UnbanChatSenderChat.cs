// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class UnbanChatSenderChat
{
    /// <summary>
    /// Use this method to unban a previously banned channel chat in a supergroup or channel. The bot must be an administrator for this to work and must have the appropriate administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> UnbanChatSenderChatAsync(this TelegramClient cl, long chatId, long senderChatId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            sender_chat_id = senderChatId
        };
        var resp = await api.Send<bool>("unbanChatSenderChat", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
