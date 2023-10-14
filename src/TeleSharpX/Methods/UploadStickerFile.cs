// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class UploadStickerFile
{
    /// <summary>
    /// Use this method to upload a file with a sticker for later use in the createNewStickerSet and addStickerToSet methods (the file can be used multiple times). Returns the uploaded File on success.
    ///</summary>
    public static async Task<File> UploadStickerFileAsync(this TelegramClient cl, long userId, InputFile sticker, string stickerFormat)
    {
        var api = cl._apiClient;
        var body = new {
            user_id = userId,
            sticker = sticker,
            sticker_format = stickerFormat
        };
        var resp = await api.Send<File>("uploadStickerFile", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
