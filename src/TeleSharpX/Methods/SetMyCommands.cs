// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetMyCommands
{
    /// <summary>
    /// Use this method to change the list of the bot&apos;s commands. See this manual for more details about bot commands. Returns True on success.
    ///</summary>
    public static async Task<bool> SetMyCommandsAsync(this TelegramClient cl, System.Collections.Generic.IEnumerable<BotCommand> commands, BotCommandScope? scope = null, string? languageCode = null)
    {
        var api = cl._apiClient;
        var body = new {
			commands = commands,
			scope = scope,
			language_code = languageCode
		};
        var resp = await api.Send<bool>("setMyCommands", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
