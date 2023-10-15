//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ShippingQuery 
    {
        /// <summary>
        /// Unique query identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// User who sent the query
        /// </summary>
        [JsonProperty("from")]
        public User From { get; set; }
        /// <summary>
        /// Bot specified invoice payload
        /// </summary>
        [JsonProperty("invoice_payload")]
        public string InvoicePayload { get; set; }
        /// <summary>
        /// User specified shipping address
        /// </summary>
        [JsonProperty("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }
    }
}