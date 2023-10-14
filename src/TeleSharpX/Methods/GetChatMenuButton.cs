// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetChatMenuButton
{
    /// <summary>
    /// Use this method to get the current value of the bot&apos;s menu button in a private chat, or the default menu button. Returns MenuButton on success.
    ///</summary>
    public static async Task<MenuButton> GetChatMenuButtonAsync(this TelegramClient cl, long? chatId = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId
        };
        var resp = await api.Send<MenuButton>("getChatMenuButton", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
