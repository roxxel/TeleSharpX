// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class BanChatMember
{
    /// <summary>
    /// Use this method to ban a user in a group, a supergroup or a channel. In the case of supergroups and channels, the user will not be able to return to the chat on their own using invite links, etc., unless unbanned first. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> BanChatMemberAsync(this TelegramClient cl, long chatId, long userId, long? untilDate = null, bool? revokeMessages = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			user_id = userId,
			until_date = untilDate,
			revoke_messages = revokeMessages
		};
        var resp = await api.Send<bool>("banChatMember", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
