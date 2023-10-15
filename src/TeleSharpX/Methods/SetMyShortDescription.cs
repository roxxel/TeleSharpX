// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetMyShortDescription
{
    /// <summary>
    /// Use this method to change the bot&apos;s short description, which is shown on the bot&apos;s profile page and is sent together with the link when users share the bot. Returns True on success.
    ///</summary>
    public static async Task<bool> SetMyShortDescriptionAsync(this TelegramClient cl, string? shortDescription = null, string? languageCode = null)
    {
        var api = cl._apiClient;
        var body = new {
            short_description = shortDescription,
            language_code = languageCode
        };
        var resp = await api.Send<bool>("setMyShortDescription", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
