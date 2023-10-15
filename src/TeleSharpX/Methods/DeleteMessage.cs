// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class DeleteMessage
{
    /// <summary>
    /// Use this method to delete a message, including service messages, with the following limitations:
        /// - A message can only be deleted if it was sent less than 48 hours ago.
        /// - Service messages about a supergroup, channel, or forum topic creation can&apos;t be deleted.
        /// - A dice message in a private chat can only be deleted if it was sent more than 24 hours ago.
        /// - Bots can delete outgoing messages in private chats, groups, and supergroups.
        /// - Bots can delete incoming messages in private chats.
        /// - Bots granted can_post_messages permissions can delete outgoing messages in channels.
        /// - If the bot is an administrator of a group, it can delete any message there.
        /// - If the bot has can_delete_messages permission in a supergroup or a channel, it can delete any message there.
        /// Returns True on success.
    ///</summary>
    public static async Task<bool> DeleteMessageAsync(this TelegramClient cl, long chatId, long messageId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            message_id = messageId
        };
        var resp = await api.Send<bool>("deleteMessage", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
