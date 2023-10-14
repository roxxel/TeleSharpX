//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class OrderInfo 
    {
        /// <summary>
        /// Optional. User name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
        /// <summary>
        /// Optional. User&apos;s phone number
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Optional. User email
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
        /// <summary>
        /// Optional. User shipping address
        /// </summary>
        [JsonPropertyName("shipping_address")]
        public ShippingAddress ShippingAddress { get; set; }
    }
}