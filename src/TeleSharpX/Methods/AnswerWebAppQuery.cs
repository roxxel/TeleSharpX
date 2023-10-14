// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class AnswerWebAppQuery
{
    /// <summary>
    /// Use this method to set the result of an interaction with a Web App and send a corresponding message on behalf of the user to the chat from which the query originated. On success, a SentWebAppMessage object is returned.
    ///</summary>
    public static async Task<SentWebAppMessage> AnswerWebAppQueryAsync(this TelegramClient cl, string webAppQueryId, InlineQueryResult result)
    {
        var api = cl._apiClient;
        var body = new {
			web_app_query_id = webAppQueryId,
			result = result
		};
        var resp = await api.Send<SentWebAppMessage>("answerWebAppQuery", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
