// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class EditChatInviteLink
{
    /// <summary>
    /// Use this method to edit a non-primary invite link created by the bot. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns the edited invite link as a ChatInviteLink object.
    ///</summary>
    public static async Task<ChatInviteLink> EditChatInviteLinkAsync(this TelegramClient cl, long chatId, string inviteLink, string? name = null, long? expireDate = null, long? memberLimit = null, bool? createsJoinRequest = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            invite_link = inviteLink,
            name = name,
            expire_date = expireDate,
            member_limit = memberLimit,
            creates_join_request = createsJoinRequest
        };
        var resp = await api.Send<ChatInviteLink>("editChatInviteLink", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
