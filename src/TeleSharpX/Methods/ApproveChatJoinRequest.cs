// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class ApproveChatJoinRequest
{
    /// <summary>
    /// Use this method to approve a chat join request. The bot must be an administrator in the chat for this to work and must have the can_invite_users administrator right. Returns True on success.
    ///</summary>
    public static async Task<bool> ApproveChatJoinRequestAsync(this TelegramClient cl, long chatId, long userId)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			user_id = userId
		};
        var resp = await api.Send<bool>("approveChatJoinRequest", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
