// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetMe
{
    /// <summary>
    /// A simple method for testing your bot&apos;s authentication token. Requires no parameters. Returns basic information about the bot in form of a User object.
    ///</summary>
    public static async Task<User> GetMeAsync(this TelegramClient cl)
    {
        var api = cl._apiClient;
        Object body = null;
        var resp = await api.Send<User>("getMe", System.Net.Http.HttpMethod.Get, body);
       
        return resp.Result;
        
    }
}
