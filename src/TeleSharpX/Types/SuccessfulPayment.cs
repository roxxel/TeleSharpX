//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class SuccessfulPayment 
    {
        /// <summary>
        /// Three-letter ISO 4217 currency code
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
        /// <summary>
        /// Total price in the smallest units of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
        /// </summary>
        [JsonProperty("total_amount")]
        public long TotalAmount { get; set; }
        /// <summary>
        /// Bot specified invoice payload
        /// </summary>
        [JsonProperty("invoice_payload")]
        public string InvoicePayload { get; set; }
        /// <summary>
        /// Optional. Identifier of the shipping option chosen by the user
        /// </summary>
        [JsonProperty("shipping_option_id")]
        public string ShippingOptionId { get; set; }
        /// <summary>
        /// Optional. Order information provided by the user
        /// </summary>
        [JsonProperty("order_info")]
        public OrderInfo OrderInfo { get; set; }
        /// <summary>
        /// Telegram payment identifier
        /// </summary>
        [JsonProperty("telegram_payment_charge_id")]
        public string TelegramPaymentChargeId { get; set; }
        /// <summary>
        /// Provider payment identifier
        /// </summary>
        [JsonProperty("provider_payment_charge_id")]
        public string ProviderPaymentChargeId { get; set; }
    }
}