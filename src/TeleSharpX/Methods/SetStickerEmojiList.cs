// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetStickerEmojiList
{
    /// <summary>
    /// Use this method to change the list of emoji assigned to a regular or custom emoji sticker. The sticker must belong to a sticker set created by the bot. Returns True on success.
    ///</summary>
    public static async Task<bool> SetStickerEmojiListAsync(this TelegramClient cl, string sticker, System.Collections.Generic.IEnumerable<string> emojiList)
    {
        var api = cl._apiClient;
        var body = new {
            sticker = sticker,
            emoji_list = emojiList
        };
        var resp = await api.Send<bool>("setStickerEmojiList", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
