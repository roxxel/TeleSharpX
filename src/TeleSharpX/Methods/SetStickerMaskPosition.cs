// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetStickerMaskPosition
{
    /// <summary>
    /// Use this method to change the mask position of a mask sticker. The sticker must belong to a sticker set that was created by the bot. Returns True on success.
    ///</summary>
    public static async Task<bool> SetStickerMaskPositionAsync(this TelegramClient cl, string sticker, MaskPosition? maskPosition = null)
    {
        var api = cl._apiClient;
        var body = new {
            sticker = sticker,
            mask_position = maskPosition
        };
        var resp = await api.Send<bool>("setStickerMaskPosition", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
