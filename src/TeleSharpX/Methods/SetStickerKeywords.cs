// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetStickerKeywords
{
    /// <summary>
    /// Use this method to change search keywords assigned to a regular or custom emoji sticker. The sticker must belong to a sticker set created by the bot. Returns True on success.
    ///</summary>
    public static async Task<bool> SetStickerKeywordsAsync(this TelegramClient cl, string sticker, System.Collections.Generic.IEnumerable<string>? keywords = null)
    {
        var api = cl._apiClient;
        var body = new {
			sticker = sticker,
			keywords = keywords
		};
        var resp = await api.Send<bool>("setStickerKeywords", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
