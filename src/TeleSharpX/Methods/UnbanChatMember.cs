// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class UnbanChatMember
{
    /// <summary>
    /// Use this method to unban a previously banned user in a supergroup or channel. The user will not return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. By default, this method guarantees that after the call the user is not a member of the chat, but will be able to join it. So if the user is a member of the chat they will also be removed from the chat. If you don&apos;t want this, use the parameter only_if_banned. Returns True on success.
    ///</summary>
    public static async Task<bool> UnbanChatMemberAsync(this TelegramClient cl, long chatId, long userId, bool? onlyIfBanned = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			user_id = userId,
			only_if_banned = onlyIfBanned
		};
        var resp = await api.Send<bool>("unbanChatMember", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
