// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendChatAction
{
    /// <summary>
    /// Use this method when you need to tell the user that something is happening on the bot&apos;s side. The status is set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status). Returns True on success.
    ///</summary>
    public static async Task<bool> SendChatActionAsync(this TelegramClient cl, long chatId, string action, long? messageThreadId = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			action = action,
			message_thread_id = messageThreadId
		};
        var resp = await api.Send<bool>("sendChatAction", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
