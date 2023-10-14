// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetMyCommands
{
    /// <summary>
    /// Use this method to get the current list of the bot&apos;s commands for the given scope and user language. Returns an Array of BotCommand objects. If commands aren&apos;t set, an empty list is returned.
    ///</summary>
    public static async Task<System.Collections.Generic.IEnumerable<BotCommand>> GetMyCommandsAsync(this TelegramClient cl, BotCommandScope? scope = null, string? languageCode = null)
    {
        var api = cl._apiClient;
        var body = new {
            scope = scope,
            language_code = languageCode
        };
        var resp = await api.Send<System.Collections.Generic.IEnumerable<BotCommand>>("getMyCommands", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
