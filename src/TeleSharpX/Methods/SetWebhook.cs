// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetWebhook
{
    /// <summary>
    /// Use this method to specify a URL and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified URL, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.
    ///</summary>
    public static async Task<bool> SetWebhookAsync(this TelegramClient cl, string url, InputFile? certificate = null, string? ipAddress = null, long? maxConnections = null, System.Collections.Generic.IEnumerable<string>? allowedUpdates = null, bool? dropPendingUpdates = null, string? secretToken = null)
    {
        var api = cl._apiClient;
        var body = new {
			url = url,
			certificate = certificate,
			ip_address = ipAddress,
			max_connections = maxConnections,
			allowed_updates = allowedUpdates,
			drop_pending_updates = dropPendingUpdates,
			secret_token = secretToken
		};
        var resp = await api.Send<bool>("setWebhook", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
