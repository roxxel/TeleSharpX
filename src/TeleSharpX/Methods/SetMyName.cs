// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetMyName
{
    /// <summary>
    /// Use this method to change the bot&apos;s name. Returns True on success.
    ///</summary>
    public static async Task<bool> SetMyNameAsync(this TelegramClient cl, string? name = null, string? languageCode = null)
    {
        var api = cl._apiClient;
        var body = new {
            name = name,
            language_code = languageCode
        };
        var resp = await api.Send<bool>("setMyName", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
