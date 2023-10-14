// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class DeleteStickerSet
{
    /// <summary>
    /// Use this method to delete a sticker set that was created by the bot. Returns True on success.
    ///</summary>
    public static async Task<bool> DeleteStickerSetAsync(this TelegramClient cl, string name)
    {
        var api = cl._apiClient;
        var body = new {
            name = name
        };
        var resp = await api.Send<bool>("deleteStickerSet", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
