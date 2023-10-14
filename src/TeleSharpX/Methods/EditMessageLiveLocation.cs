// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class EditMessageLiveLocation
{
    /// <summary>
    /// Use this method to edit live location messages. A location can be edited until its live_period expires or editing is explicitly disabled by a call to stopMessageLiveLocation. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
    ///</summary>
    public static async Task<Message> EditMessageLiveLocationAsync(this TelegramClient cl, float latitude, float longitude, long? chatId = null, long? messageId = null, string? inlineMessageId = null, float? horizontalAccuracy = null, long? heading = null, long? proximityAlertRadius = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
			latitude = latitude,
			longitude = longitude,
			chat_id = chatId,
			message_id = messageId,
			inline_message_id = inlineMessageId,
			horizontal_accuracy = horizontalAccuracy,
			heading = heading,
			proximity_alert_radius = proximityAlertRadius,
			reply_markup = replyMarkup
		};
        var resp = await api.Send<Message>("editMessageLiveLocation", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
