// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetStickerSetTitle
{
    /// <summary>
    /// Use this method to set the title of a created sticker set. Returns True on success.
    ///</summary>
    public static async Task<bool> SetStickerSetTitleAsync(this TelegramClient cl, string name, string title)
    {
        var api = cl._apiClient;
        var body = new {
            name = name,
            title = title
        };
        var resp = await api.Send<bool>("setStickerSetTitle", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
