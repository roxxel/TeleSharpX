// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetUpdates
{
    /// <summary>
    /// Use this method to receive incoming updates using long polling (wiki). Returns an Array of Update objects.
    ///</summary>
    public static async Task<System.Collections.Generic.IEnumerable<Update>> GetUpdatesAsync(this TelegramClient cl, long? offset = null, long? limit = null, long? timeout = null, System.Collections.Generic.IEnumerable<string>? allowedUpdates = null)
    {
        var api = cl._apiClient;
        var body = new {
			offset = offset,
			limit = limit,
			timeout = timeout,
			allowed_updates = allowedUpdates
		};
        var resp = await api.Send<System.Collections.Generic.IEnumerable<Update>>("getUpdates", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
