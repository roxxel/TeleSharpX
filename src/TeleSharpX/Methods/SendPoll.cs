// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendPoll
{
    /// <summary>
    /// Use this method to send a native poll. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendPollAsync(this TelegramClient cl, long chatId, string question, System.Collections.Generic.IEnumerable<string> options, long? messageThreadId = null, bool? isAnonymous = null, string? type = null, bool? allowsMultipleAnswers = null, long? correctOptionId = null, string? explanation = null, string? explanationParseMode = null, System.Collections.Generic.IEnumerable<MessageEntity>? explanationEntities = null, long? openPeriod = null, long? closeDate = null, bool? isClosed = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            question = question,
            options = options,
            message_thread_id = messageThreadId,
            is_anonymous = isAnonymous,
            type = type,
            allows_multiple_answers = allowsMultipleAnswers,
            correct_option_id = correctOptionId,
            explanation = explanation,
            explanation_parse_mode = explanationParseMode,
            explanation_entities = explanationEntities,
            open_period = openPeriod,
            close_date = closeDate,
            is_closed = isClosed,
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("sendPoll", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
