// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetChatPhoto
{
    /// <summary>
    /// Use this method to set a new profile photo for the chat. Photos can&apos;t be changed for private chats. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns True on success.
    ///</summary>
    public static async Task<bool> SetChatPhotoAsync(this TelegramClient cl, long chatId, InputFile photo)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            photo = photo
        };
        var resp = await api.Send<bool>("setChatPhoto", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
