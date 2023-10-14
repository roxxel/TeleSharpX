// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetMyDescription
{
    /// <summary>
    /// Use this method to get the current bot description for the given user language. Returns BotDescription on success.
    ///</summary>
    public static async Task<BotDescription> GetMyDescriptionAsync(this TelegramClient cl, string? languageCode = null)
    {
        var api = cl._apiClient;
        var body = new {
            language_code = languageCode
        };
        var resp = await api.Send<BotDescription>("getMyDescription", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
