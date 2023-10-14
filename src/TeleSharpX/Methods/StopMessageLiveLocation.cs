// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class StopMessageLiveLocation
{
    /// <summary>
    /// Use this method to stop updating a live location message before live_period expires. On success, if the message is not an inline message, the edited Message is returned, otherwise True is returned.
    ///</summary>
    public static async Task<Message> StopMessageLiveLocationAsync(this TelegramClient cl, long? chatId = null, long? messageId = null, string? inlineMessageId = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			message_id = messageId,
			inline_message_id = inlineMessageId,
			reply_markup = replyMarkup
		};
        var resp = await api.Send<Message>("stopMessageLiveLocation", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
