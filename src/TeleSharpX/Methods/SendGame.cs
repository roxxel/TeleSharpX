// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendGame
{
    /// <summary>
    /// Use this method to send a game. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendGameAsync(this TelegramClient cl, long chatId, string gameShortName, long? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			game_short_name = gameShortName,
			message_thread_id = messageThreadId,
			disable_notification = disableNotification,
			protect_content = protectContent,
			reply_to_message_id = replyToMessageId,
			allow_sending_without_reply = allowSendingWithoutReply,
			reply_markup = replyMarkup
		};
        var resp = await api.Send<Message>("sendGame", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
