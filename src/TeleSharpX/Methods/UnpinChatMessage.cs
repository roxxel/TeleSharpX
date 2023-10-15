// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class UnpinChatMessage
{
    /// <summary>
    /// Use this method to remove a message from the list of pinned messages in a chat. If the chat is not a private chat, the bot must be an administrator in the chat for this to work and must have the &apos;can_pin_messages&apos; administrator right in a supergroup or &apos;can_edit_messages&apos; administrator right in a channel. Returns True on success.
    ///</summary>
    public static async Task<bool> UnpinChatMessageAsync(this TelegramClient cl, long chatId, long? messageId = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            message_id = messageId
        };
        var resp = await api.Send<bool>("unpinChatMessage", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
