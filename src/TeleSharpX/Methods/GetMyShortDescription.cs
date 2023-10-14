// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetMyShortDescription
{
    /// <summary>
    /// Use this method to get the current bot short description for the given user language. Returns BotShortDescription on success.
    ///</summary>
    public static async Task<BotShortDescription> GetMyShortDescriptionAsync(this TelegramClient cl, string? languageCode = null)
    {
        var api = cl._apiClient;
        var body = new {
			language_code = languageCode
		};
        var resp = await api.Send<BotShortDescription>("getMyShortDescription", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
