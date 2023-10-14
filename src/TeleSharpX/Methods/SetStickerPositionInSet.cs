// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetStickerPositionInSet
{
    /// <summary>
    /// Use this method to move a sticker in a set created by the bot to a specific position. Returns True on success.
    ///</summary>
    public static async Task<bool> SetStickerPositionInSetAsync(this TelegramClient cl, string sticker, long position)
    {
        var api = cl._apiClient;
        var body = new {
			sticker = sticker,
			position = position
		};
        var resp = await api.Send<bool>("setStickerPositionInSet", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
