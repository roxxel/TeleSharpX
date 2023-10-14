// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendInvoice
{
    /// <summary>
    /// Use this method to send invoices. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendInvoiceAsync(this TelegramClient cl, long chatId, string title, string description, string payload, string providerToken, string currency, System.Collections.Generic.IEnumerable<LabeledPrice> prices, long? messageThreadId = null, long? maxTipAmount = null, System.Collections.Generic.IEnumerable<long>? suggestedTipAmounts = null, string? startParameter = null, string? providerData = null, string? photoUrl = null, long? photoSize = null, long? photoWidth = null, long? photoHeight = null, bool? needName = null, bool? needPhoneNumber = null, bool? needEmail = null, bool? needShippingAddress = null, bool? sendPhoneNumberToProvider = null, bool? sendEmailToProvider = null, bool? isFlexible = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
			chat_id = chatId,
			title = title,
			description = description,
			payload = payload,
			provider_token = providerToken,
			currency = currency,
			prices = prices,
			message_thread_id = messageThreadId,
			max_tip_amount = maxTipAmount,
			suggested_tip_amounts = suggestedTipAmounts,
			start_parameter = startParameter,
			provider_data = providerData,
			photo_url = photoUrl,
			photo_size = photoSize,
			photo_width = photoWidth,
			photo_height = photoHeight,
			need_name = needName,
			need_phone_number = needPhoneNumber,
			need_email = needEmail,
			need_shipping_address = needShippingAddress,
			send_phone_number_to_provider = sendPhoneNumberToProvider,
			send_email_to_provider = sendEmailToProvider,
			is_flexible = isFlexible,
			disable_notification = disableNotification,
			protect_content = protectContent,
			reply_to_message_id = replyToMessageId,
			allow_sending_without_reply = allowSendingWithoutReply,
			reply_markup = replyMarkup
		};
        var resp = await api.Send<Message>("sendInvoice", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
