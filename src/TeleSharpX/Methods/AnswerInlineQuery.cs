// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class AnswerInlineQuery
{
    /// <summary>
    /// Use this method to send answers to an inline query. On success, True is returned.
		/// No more than 50 results per query are allowed.
    ///</summary>
    public static async Task<bool> AnswerInlineQueryAsync(this TelegramClient cl, string inlineQueryId, System.Collections.Generic.IEnumerable<InlineQueryResult> results, long? cacheTime = null, bool? isPersonal = null, string? nextOffset = null, InlineQueryResultsButton? button = null)
    {
        var api = cl._apiClient;
        var body = new {
			inline_query_id = inlineQueryId,
			results = results,
			cache_time = cacheTime,
			is_personal = isPersonal,
			next_offset = nextOffset,
			button = button
		};
        var resp = await api.Send<bool>("answerInlineQuery", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
