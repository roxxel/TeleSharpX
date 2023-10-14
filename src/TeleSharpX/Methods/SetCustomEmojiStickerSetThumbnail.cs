// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetCustomEmojiStickerSetThumbnail
{
    /// <summary>
    /// Use this method to set the thumbnail of a custom emoji sticker set. Returns True on success.
    ///</summary>
    public static async Task<bool> SetCustomEmojiStickerSetThumbnailAsync(this TelegramClient cl, string name, string? customEmojiId = null)
    {
        var api = cl._apiClient;
        var body = new {
            name = name,
            custom_emoji_id = customEmojiId
        };
        var resp = await api.Send<bool>("setCustomEmojiStickerSetThumbnail", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
