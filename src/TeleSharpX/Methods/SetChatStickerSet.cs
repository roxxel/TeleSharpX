// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetChatStickerSet
{
    /// <summary>
    /// Use this method to set a new group sticker set for a supergroup. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Use the field can_set_sticker_set optionally returned in getChat requests to check if the bot can use this method. Returns True on success.
    ///</summary>
    public static async Task<bool> SetChatStickerSetAsync(this TelegramClient cl, long chatId, string stickerSetName)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            sticker_set_name = stickerSetName
        };
        var resp = await api.Send<bool>("setChatStickerSet", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
