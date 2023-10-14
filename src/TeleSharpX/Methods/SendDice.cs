// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendDice
{
    /// <summary>
    /// Use this method to send an animated emoji that will display a random value. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendDiceAsync(this TelegramClient cl, long chatId, long? messageThreadId = null, string? emoji = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			message_thread_id = messageThreadId,
			emoji = emoji,
			disable_notification = disableNotification,
			protect_content = protectContent,
			reply_to_message_id = replyToMessageId,
			allow_sending_without_reply = allowSendingWithoutReply,
			reply_markup = replyMarkup
		};
        var resp = await api.Send<Message>("sendDice", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
