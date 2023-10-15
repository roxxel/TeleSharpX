// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetChatPermissions
{
    /// <summary>
    /// Use this method to set default chat permissions for all members. The bot must be an administrator in the group or a supergroup for this to work and must have the can_restrict_members administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> SetChatPermissionsAsync(this TelegramClient cl, long chatId, ChatPermissions permissions, bool? useIndependentChatPermissions = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            permissions = permissions,
            use_independent_chat_permissions = useIndependentChatPermissions
        };
        var resp = await api.Send<bool>("setChatPermissions", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
