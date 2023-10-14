// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetGameHighScores
{
    /// <summary>
    /// Use this method to get data for high score tables. Will return the score of the specified user and several of their neighbors in a game. Returns an Array of GameHighScore objects.
    ///</summary>
    public static async Task<System.Collections.Generic.IEnumerable<GameHighScore>> GetGameHighScoresAsync(this TelegramClient cl, long userId, long? chatId = null, long? messageId = null, string? inlineMessageId = null)
    {
        var api = cl._apiClient;
        var body = new {
			user_id = userId,
			chat_id = chatId,
			message_id = messageId,
			inline_message_id = inlineMessageId
		};
        var resp = await api.Send<System.Collections.Generic.IEnumerable<GameHighScore>>("getGameHighScores", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
