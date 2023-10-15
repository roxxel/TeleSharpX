// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class UnpinAllChatMessages
{
    /// <summary>
    /// Use this method to clear the list of pinned messages in a chat. If the chat is not a private chat, the bot must be an administrator in the chat for this to work and must have the &apos;can_pin_messages&apos; administrator right in a supergroup or &apos;can_edit_messages&apos; administrator right in a channel. Returns True on success.
    ///</summary>
    public static async Task<bool> UnpinAllChatMessagesAsync(this TelegramClient cl, long chatId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId
        };
        var resp = await api.Send<bool>("unpinAllChatMessages", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
