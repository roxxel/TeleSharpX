// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendVenue
{
    /// <summary>
    /// Use this method to send information about a venue. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendVenueAsync(this TelegramClient cl, long chatId, float latitude, float longitude, string title, string address, long? messageThreadId = null, string? foursquareId = null, string? foursquareType = null, string? googlePlaceId = null, string? googlePlaceType = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            latitude = latitude,
            longitude = longitude,
            title = title,
            address = address,
            message_thread_id = messageThreadId,
            foursquare_id = foursquareId,
            foursquare_type = foursquareType,
            google_place_id = googlePlaceId,
            google_place_type = googlePlaceType,
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("sendVenue", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
