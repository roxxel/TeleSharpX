// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class AnswerPreCheckoutQuery
{
    /// <summary>
    /// Once the user has confirmed their payment and shipping details, the Bot API sends the final confirmation in the form of an Update with the field pre_checkout_query. Use this method to respond to such pre-checkout queries. On success, True is returned. Note: The Bot API must receive an answer within 10 seconds after the pre-checkout query was sent.
    ///</summary>
    public static async Task<bool> AnswerPreCheckoutQueryAsync(this TelegramClient cl, string preCheckoutQueryId, bool ok, string? errorMessage = null)
    {
        var api = cl._apiClient;
        var body = new {
            pre_checkout_query_id = preCheckoutQueryId,
            ok = ok,
            error_message = errorMessage
        };
        var resp = await api.Send<bool>("answerPreCheckoutQuery", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
