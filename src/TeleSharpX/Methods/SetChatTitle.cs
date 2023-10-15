// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetChatTitle
{
    /// <summary>
    /// Use this method to change the title of a chat. Titles can&apos;t be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> SetChatTitleAsync(this TelegramClient cl, long chatId, string title)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            title = title
        };
        var resp = await api.Send<bool>("setChatTitle", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
