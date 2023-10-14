// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class EditForumTopic
{
    /// <summary>
    /// Use this method to edit name and icon of a topic in a forum supergroup chat. The bot must be an administrator in the chat for this to work and must have can_manage_topics administrator rights, unless it is the creator of the topic. Returns True on success.
    ///</summary>
    public static async Task<bool> EditForumTopicAsync(this TelegramClient cl, long chatId, long messageThreadId, string? name = null, string? iconCustomEmojiId = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			message_thread_id = messageThreadId,
			name = name,
			icon_custom_emoji_id = iconCustomEmojiId
		};
        var resp = await api.Send<bool>("editForumTopic", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
