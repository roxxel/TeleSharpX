// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetGameScore
{
    /// <summary>
    /// Use this method to set the score of the specified user in a game message. On success, if the message is not an inline message, the Message is returned, otherwise True is returned. Returns an error, if the new score is not greater than the user&apos;s current score in the chat and force is False.
    ///</summary>
    public static async Task<Message> SetGameScoreAsync(this TelegramClient cl, long userId, long score, bool? force = null, bool? disableEditMessage = null, long? chatId = null, long? messageId = null, string? inlineMessageId = null)
    {
        var api = cl._apiClient;
        var body = new {
			user_id = userId,
			score = score,
			force = force,
			disable_edit_message = disableEditMessage,
			chat_id = chatId,
			message_id = messageId,
			inline_message_id = inlineMessageId
		};
        var resp = await api.Send<Message>("setGameScore", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
