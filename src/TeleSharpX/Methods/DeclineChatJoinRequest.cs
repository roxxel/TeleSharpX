// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class DeclineChatJoinRequest
{
    /// <summary>
    /// Use this method to decline a chat join request. The bot must be an administrator in the chat for this to work and must have the can_invite_users administrator right. Returns True on success.
    ///</summary>
    public static async Task<bool> DeclineChatJoinRequestAsync(this TelegramClient cl, long chatId, long userId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            user_id = userId
        };
        var resp = await api.Send<bool>("declineChatJoinRequest", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
