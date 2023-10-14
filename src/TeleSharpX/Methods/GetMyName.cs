// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetMyName
{
    /// <summary>
    /// Use this method to get the current bot name for the given user language. Returns BotName on success.
    ///</summary>
    public static async Task<BotName> GetMyNameAsync(this TelegramClient cl, string? languageCode = null)
    {
        var api = cl._apiClient;
        var body = new {
            language_code = languageCode
        };
        var resp = await api.Send<BotName>("getMyName", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
