// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class AddStickerToSet
{
    /// <summary>
    /// Use this method to add a new sticker to a set created by the bot. The format of the added sticker must match the format of the other stickers in the set. Emoji sticker sets can have up to 200 stickers. Animated and video sticker sets can have up to 50 stickers. Static sticker sets can have up to 120 stickers. Returns True on success.
    ///</summary>
    public static async Task<bool> AddStickerToSetAsync(this TelegramClient cl, long userId, string name, InputSticker sticker)
    {
        var api = cl._apiClient;
        var body = new {
            user_id = userId,
            name = name,
            sticker = sticker
        };
        var resp = await api.Send<bool>("addStickerToSet", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
