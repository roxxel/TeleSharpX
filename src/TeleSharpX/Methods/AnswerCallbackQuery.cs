// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class AnswerCallbackQuery
{
    /// <summary>
    /// Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.
    ///</summary>
    public static async Task<bool> AnswerCallbackQueryAsync(this TelegramClient cl, string callbackQueryId, string? text = null, bool? showAlert = null, string? url = null, long? cacheTime = null)
    {
        var api = cl._apiClient;
        var body = new {
            callback_query_id = callbackQueryId,
            text = text,
            show_alert = showAlert,
            url = url,
            cache_time = cacheTime
        };
        var resp = await api.Send<bool>("answerCallbackQuery", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
