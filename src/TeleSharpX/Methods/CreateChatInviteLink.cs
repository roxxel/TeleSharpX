// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class CreateChatInviteLink
{
    /// <summary>
    /// Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. The link can be revoked using the method revokeChatInviteLink. Returns the new invite link as ChatInviteLink object.
    ///</summary>
    public static async Task<ChatInviteLink> CreateChatInviteLinkAsync(this TelegramClient cl, long chatId, string? name = null, long? expireDate = null, long? memberLimit = null, bool? createsJoinRequest = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			name = name,
			expire_date = expireDate,
			member_limit = memberLimit,
			creates_join_request = createsJoinRequest
		};
        var resp = await api.Send<ChatInviteLink>("createChatInviteLink", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
