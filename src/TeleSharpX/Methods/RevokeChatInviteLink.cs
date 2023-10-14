// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class RevokeChatInviteLink
{
    /// <summary>
    /// Use this method to revoke an invite link created by the bot. If the primary link is revoked, a new link is automatically generated. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns the revoked invite link as ChatInviteLink object.
    ///</summary>
    public static async Task<ChatInviteLink> RevokeChatInviteLinkAsync(this TelegramClient cl, long chatId, string inviteLink)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			invite_link = inviteLink
		};
        var resp = await api.Send<ChatInviteLink>("revokeChatInviteLink", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
