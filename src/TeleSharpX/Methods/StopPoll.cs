// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class StopPoll
{
    /// <summary>
    /// Use this method to stop a poll which was sent by the bot. On success, the stopped Poll is returned.
    ///</summary>
    public static async Task<Poll> StopPollAsync(this TelegramClient cl, long chatId, long messageId, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			message_id = messageId,
			reply_markup = replyMarkup
		};
        var resp = await api.Send<Poll>("stopPoll", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
