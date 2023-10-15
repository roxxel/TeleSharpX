// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class DeleteMyCommands
{
    /// <summary>
    /// Use this method to delete the list of the bot&apos;s commands for the given scope and user language. After deletion, higher level commands will be shown to affected users. Returns True on success.
    ///</summary>
    public static async Task<bool> DeleteMyCommandsAsync(this TelegramClient cl, BotCommandScope? scope = null, string? languageCode = null)
    {
        var api = cl._apiClient;
        var body = new {
            scope = scope,
            language_code = languageCode
        };
        var resp = await api.Send<bool>("deleteMyCommands", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
