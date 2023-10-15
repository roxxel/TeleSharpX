// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class PinChatMessage
{
    /// <summary>
    /// Use this method to add a message to the list of pinned messages in a chat. If the chat is not a private chat, the bot must be an administrator in the chat for this to work and must have the &apos;can_pin_messages&apos; administrator right in a supergroup or &apos;can_edit_messages&apos; administrator right in a channel. Returns True on success.
    ///</summary>
    public static async Task<bool> PinChatMessageAsync(this TelegramClient cl, long chatId, long messageId, bool? disableNotification = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            message_id = messageId,
            disable_notification = disableNotification
        };
        var resp = await api.Send<bool>("pinChatMessage", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
