// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class DeleteStickerFromSet
{
    /// <summary>
    /// Use this method to delete a sticker from a set created by the bot. Returns True on success.
    ///</summary>
    public static async Task<bool> DeleteStickerFromSetAsync(this TelegramClient cl, string sticker)
    {
        var api = cl._apiClient;
        var body = new {
            sticker = sticker
        };
        var resp = await api.Send<bool>("deleteStickerFromSet", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
