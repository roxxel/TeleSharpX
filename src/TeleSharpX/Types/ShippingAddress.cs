//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ShippingAddress 
    {
        /// <summary>
        /// Two-letter ISO 3166-1 alpha-2 country code
        /// </summary>
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        /// <summary>
        /// State, if applicable
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
        /// <summary>
        /// City
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }
        /// <summary>
        /// First line for the address
        /// </summary>
        [JsonProperty("street_line1")]
        public string StreetLine1 { get; set; }
        /// <summary>
        /// Second line for the address
        /// </summary>
        [JsonProperty("street_line2")]
        public string StreetLine2 { get; set; }
        /// <summary>
        /// Address post code
        /// </summary>
        [JsonProperty("post_code")]
        public string PostCode { get; set; }
    }
}