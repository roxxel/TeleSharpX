// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetMyDescription
{
    /// <summary>
    /// Use this method to change the bot&apos;s description, which is shown in the chat with the bot if the chat is empty. Returns True on success.
    ///</summary>
    public static async Task<bool> SetMyDescriptionAsync(this TelegramClient cl, string? description = null, string? languageCode = null)
    {
        var api = cl._apiClient;
        var body = new {
            description = description,
            language_code = languageCode
        };
        var resp = await api.Send<bool>("setMyDescription", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
