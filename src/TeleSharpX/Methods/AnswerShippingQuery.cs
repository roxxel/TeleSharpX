// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class AnswerShippingQuery
{
    /// <summary>
    /// If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the Bot API will send an Update with a shipping_query field to the bot. Use this method to reply to shipping queries. On success, True is returned.
    ///</summary>
    public static async Task<bool> AnswerShippingQueryAsync(this TelegramClient cl, string shippingQueryId, bool ok, System.Collections.Generic.IEnumerable<ShippingOption>? shippingOptions = null, string? errorMessage = null)
    {
        var api = cl._apiClient;
        var body = new {
			shipping_query_id = shippingQueryId,
			ok = ok,
			shipping_options = shippingOptions,
			error_message = errorMessage
		};
        var resp = await api.Send<bool>("answerShippingQuery", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
