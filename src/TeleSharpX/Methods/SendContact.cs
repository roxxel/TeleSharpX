// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendContact
{
    /// <summary>
    /// Use this method to send phone contacts. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendContactAsync(this TelegramClient cl, long chatId, string phoneNumber, string firstName, long? messageThreadId = null, string? lastName = null, string? vcard = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            phone_number = phoneNumber,
            first_name = firstName,
            message_thread_id = messageThreadId,
            last_name = lastName,
            vcard = vcard,
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("sendContact", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
