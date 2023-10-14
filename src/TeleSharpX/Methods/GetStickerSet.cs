// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetStickerSet
{
    /// <summary>
    /// Use this method to get a sticker set. On success, a StickerSet object is returned.
    ///</summary>
    public static async Task<StickerSet> GetStickerSetAsync(this TelegramClient cl, string name)
    {
        var api = cl._apiClient;
        var body = new {
            name = name
        };
        var resp = await api.Send<StickerSet>("getStickerSet", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
