// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class CreateNewStickerSet
{
    /// <summary>
    /// Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. Returns True on success.
    ///</summary>
    public static async Task<bool> CreateNewStickerSetAsync(this TelegramClient cl, long userId, string name, string title, System.Collections.Generic.IEnumerable<InputSticker> stickers, string stickerFormat, string? stickerType = null, bool? needsRepainting = null)
    {
        var api = cl._apiClient;
        var body = new {
			user_id = userId,
			name = name,
			title = title,
			stickers = stickers,
			sticker_format = stickerFormat,
			sticker_type = stickerType,
			needs_repainting = needsRepainting
		};
        var resp = await api.Send<bool>("createNewStickerSet", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
