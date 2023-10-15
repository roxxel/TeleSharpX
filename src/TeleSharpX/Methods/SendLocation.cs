// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendLocation
{
    /// <summary>
    /// Use this method to send point on the map. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendLocationAsync(this TelegramClient cl, long chatId, float latitude, float longitude, long? messageThreadId = null, float? horizontalAccuracy = null, long? livePeriod = null, long? heading = null, long? proximityAlertRadius = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            latitude = latitude,
            longitude = longitude,
            message_thread_id = messageThreadId,
            horizontal_accuracy = horizontalAccuracy,
            live_period = livePeriod,
            heading = heading,
            proximity_alert_radius = proximityAlertRadius,
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("sendLocation", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
