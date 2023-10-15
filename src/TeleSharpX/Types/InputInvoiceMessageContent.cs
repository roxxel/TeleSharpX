//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InputInvoiceMessageContent : InputMessageContent
    {
        /// <summary>
        /// Product name, 1-32 characters
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Product description, 1-255 characters
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.
        /// </summary>
        [JsonProperty("payload")]
        public string Payload { get; set; }
        /// <summary>
        /// Payment provider token, obtained via @BotFather
        /// </summary>
        [JsonProperty("provider_token")]
        public string ProviderToken { get; set; }
        /// <summary>
        /// Three-letter ISO 4217 currency code, see more on currencies
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
        /// <summary>
        /// Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.)
        /// </summary>
        [JsonProperty("prices")]
        public System.Collections.Generic.IEnumerable<LabeledPrice> Prices { get; set; }
        /// <summary>
        /// Optional. The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double). For example, for a maximum tip of US$ 1.45 pass max_tip_amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0
        /// </summary>
        [JsonProperty("max_tip_amount")]
        public long MaxTipAmount { get; set; }
        /// <summary>
        /// Optional. A JSON-serialized array of suggested amounts of tip in the smallest units of the currency (integer, not float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed max_tip_amount.
        /// </summary>
        [JsonProperty("suggested_tip_amounts")]
        public System.Collections.Generic.IEnumerable<long> SuggestedTipAmounts { get; set; }
        /// <summary>
        /// Optional. A JSON-serialized object for data about the invoice, which will be shared with the payment provider. A detailed description of the required fields should be provided by the payment provider.
        /// </summary>
        [JsonProperty("provider_data")]
        public string ProviderData { get; set; }
        /// <summary>
        /// Optional. URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service.
        /// </summary>
        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }
        /// <summary>
        /// Optional. Photo size in bytes
        /// </summary>
        [JsonProperty("photo_size")]
        public long PhotoSize { get; set; }
        /// <summary>
        /// Optional. Photo width
        /// </summary>
        [JsonProperty("photo_width")]
        public long PhotoWidth { get; set; }
        /// <summary>
        /// Optional. Photo height
        /// </summary>
        [JsonProperty("photo_height")]
        public long PhotoHeight { get; set; }
        /// <summary>
        /// Optional. Pass True if you require the user&apos;s full name to complete the order
        /// </summary>
        [JsonProperty("need_name")]
        public bool NeedName { get; set; }
        /// <summary>
        /// Optional. Pass True if you require the user&apos;s phone number to complete the order
        /// </summary>
        [JsonProperty("need_phone_number")]
        public bool NeedPhoneNumber { get; set; }
        /// <summary>
        /// Optional. Pass True if you require the user&apos;s email address to complete the order
        /// </summary>
        [JsonProperty("need_email")]
        public bool NeedEmail { get; set; }
        /// <summary>
        /// Optional. Pass True if you require the user&apos;s shipping address to complete the order
        /// </summary>
        [JsonProperty("need_shipping_address")]
        public bool NeedShippingAddress { get; set; }
        /// <summary>
        /// Optional. Pass True if the user&apos;s phone number should be sent to provider
        /// </summary>
        [JsonProperty("send_phone_number_to_provider")]
        public bool SendPhoneNumberToProvider { get; set; }
        /// <summary>
        /// Optional. Pass True if the user&apos;s email address should be sent to provider
        /// </summary>
        [JsonProperty("send_email_to_provider")]
        public bool SendEmailToProvider { get; set; }
        /// <summary>
        /// Optional. Pass True if the final price depends on the shipping method
        /// </summary>
        [JsonProperty("is_flexible")]
        public bool IsFlexible { get; set; }
    }
}