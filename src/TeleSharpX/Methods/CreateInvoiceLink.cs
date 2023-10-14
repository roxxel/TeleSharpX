// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class CreateInvoiceLink
{
    /// <summary>
    /// Use this method to create a link for an invoice. Returns the created invoice link as String on success.
    ///</summary>
    public static async Task<string> CreateInvoiceLinkAsync(this TelegramClient cl, string title, string description, string payload, string providerToken, string currency, System.Collections.Generic.IEnumerable<LabeledPrice> prices, long? maxTipAmount = null, System.Collections.Generic.IEnumerable<long>? suggestedTipAmounts = null, string? providerData = null, string? photoUrl = null, long? photoSize = null, long? photoWidth = null, long? photoHeight = null, bool? needName = null, bool? needPhoneNumber = null, bool? needEmail = null, bool? needShippingAddress = null, bool? sendPhoneNumberToProvider = null, bool? sendEmailToProvider = null, bool? isFlexible = null)
    {
        var api = cl._apiClient;
        var body = new {
            title = title,
            description = description,
            payload = payload,
            provider_token = providerToken,
            currency = currency,
            prices = prices,
            max_tip_amount = maxTipAmount,
            suggested_tip_amounts = suggestedTipAmounts,
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
            is_flexible = isFlexible
        };
        var resp = await api.Send<string>("createInvoiceLink", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
