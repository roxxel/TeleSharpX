// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class DeleteWebhook
{
    /// <summary>
    /// Use this method to remove webhook integration if you decide to switch back to getUpdates. Returns True on success.
    ///</summary>
    public static async Task<bool> DeleteWebhookAsync(this TelegramClient cl, bool? dropPendingUpdates = null)
    {
        var api = cl._apiClient;
        var body = new {
			drop_pending_updates = dropPendingUpdates
		};
        var resp = await api.Send<bool>("deleteWebhook", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
