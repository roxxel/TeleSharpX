// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetCustomEmojiStickers
{
    /// <summary>
    /// Use this method to get information about custom emoji stickers by their identifiers. Returns an Array of Sticker objects.
    ///</summary>
    public static async Task<System.Collections.Generic.IEnumerable<Sticker>> GetCustomEmojiStickersAsync(this TelegramClient cl, System.Collections.Generic.IEnumerable<string> customEmojiIds)
    {
        var api = cl._apiClient;
        var body = new {
            custom_emoji_ids = customEmojiIds
        };
        var resp = await api.Send<System.Collections.Generic.IEnumerable<Sticker>>("getCustomEmojiStickers", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
