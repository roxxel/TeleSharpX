// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetChatMenuButton
{
    /// <summary>
    /// Use this method to change the bot&apos;s menu button in a private chat, or the default menu button. Returns True on success.
    ///</summary>
    public static async Task<bool> SetChatMenuButtonAsync(this TelegramClient cl, long? chatId = null, MenuButton? menuButton = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            menu_button = menuButton
        };
        var resp = await api.Send<bool>("setChatMenuButton", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
