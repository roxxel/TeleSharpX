// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class RestrictChatMember
{
    /// <summary>
    /// Use this method to restrict a user in a supergroup. The bot must be an administrator in the supergroup for this to work and must have the appropriate administrator rights. Pass True for all permissions to lift restrictions from a user. Returns True on success.
    ///</summary>
    public static async Task<bool> RestrictChatMemberAsync(this TelegramClient cl, long chatId, long userId, ChatPermissions permissions, bool? useIndependentChatPermissions = null, long? untilDate = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			user_id = userId,
			permissions = permissions,
			use_independent_chat_permissions = useIndependentChatPermissions,
			until_date = untilDate
		};
        var resp = await api.Send<bool>("restrictChatMember", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
