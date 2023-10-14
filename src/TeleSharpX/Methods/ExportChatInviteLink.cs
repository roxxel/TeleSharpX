// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class ExportChatInviteLink
{
    /// <summary>
    /// Use this method to generate a new primary invite link for a chat; any previously generated primary link is revoked. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns the new invite link as String on success.
    ///</summary>
    public static async Task<string> ExportChatInviteLinkAsync(this TelegramClient cl, long chatId)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId
		};
        var resp = await api.Send<string>("exportChatInviteLink", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
