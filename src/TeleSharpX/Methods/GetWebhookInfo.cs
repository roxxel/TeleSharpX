// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetWebhookInfo
{
    /// <summary>
    /// Use this method to get current webhook status. Requires no parameters. On success, returns a WebhookInfo object. If the bot is using getUpdates, will return an object with the url field empty.
    ///</summary>
    public static async Task<WebhookInfo> GetWebhookInfoAsync(this TelegramClient cl)
    {
        var api = cl._apiClient;
        Object body = null;
        var resp = await api.Send<WebhookInfo>("getWebhookInfo", System.Net.Http.HttpMethod.Get, body);
       
        return resp.Result;
        
    }
}
