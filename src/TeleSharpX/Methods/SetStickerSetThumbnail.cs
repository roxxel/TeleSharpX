// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetStickerSetThumbnail
{
    /// <summary>
    /// Use this method to set the thumbnail of a regular or mask sticker set. The format of the thumbnail file must match the format of the stickers in the set. Returns True on success.
    ///</summary>
    public static async Task<bool> SetStickerSetThumbnailAsync(this TelegramClient cl, string name, long userId, InputFile? thumbnail = null)
    {
        var api = cl._apiClient;
        var body = new {
			name = name,
			user_id = userId,
			thumbnail = thumbnail
		};
        var resp = await api.Send<bool>("setStickerSetThumbnail", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
