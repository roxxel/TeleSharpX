// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class BanChatSenderChat
{
    /// <summary>
    /// Use this method to ban a channel chat in a supergroup or a channel. Until the chat is unbanned, the owner of the banned chat won&apos;t be able to send messages on behalf of any of their channels. The bot must be an administrator in the supergroup or channel for this to work and must have the appropriate administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> BanChatSenderChatAsync(this TelegramClient cl, long chatId, long senderChatId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            sender_chat_id = senderChatId
        };
        var resp = await api.Send<bool>("banChatSenderChat", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
