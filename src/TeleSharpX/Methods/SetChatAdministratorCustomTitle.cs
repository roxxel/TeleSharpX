// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetChatAdministratorCustomTitle
{
    /// <summary>
    /// Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns True on success.
    ///</summary>
    public static async Task<bool> SetChatAdministratorCustomTitleAsync(this TelegramClient cl, long chatId, long userId, string customTitle)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			user_id = userId,
			custom_title = customTitle
		};
        var resp = await api.Send<bool>("setChatAdministratorCustomTitle", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
