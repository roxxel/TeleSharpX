// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class CreateForumTopic
{
    /// <summary>
    /// Use this method to create a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have the can_manage_topics administrator rights. Returns information about the created topic as a ForumTopic object.
    ///</summary>
    public static async Task<ForumTopic> CreateForumTopicAsync(this TelegramClient cl, long chatId, string name, long? iconColor = null, string? iconCustomEmojiId = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            name = name,
            icon_color = iconColor,
            icon_custom_emoji_id = iconCustomEmojiId
        };
        var resp = await api.Send<ForumTopic>("createForumTopic", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
