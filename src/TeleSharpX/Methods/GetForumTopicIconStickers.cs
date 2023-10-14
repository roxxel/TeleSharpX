// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetForumTopicIconStickers
{
    /// <summary>
    /// Use this method to get custom emoji stickers, which can be used as a forum topic icon by any user. Requires no parameters. Returns an Array of Sticker objects.
    ///</summary>
    public static async Task<System.Collections.Generic.IEnumerable<Sticker>> GetForumTopicIconStickersAsync(this TelegramClient cl, long chatId, string name, long? iconColor = null, string? iconCustomEmojiId = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            name = name,
            icon_color = iconColor,
            icon_custom_emoji_id = iconCustomEmojiId
        };
        var resp = await api.Send<System.Collections.Generic.IEnumerable<Sticker>>("getForumTopicIconStickers", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
