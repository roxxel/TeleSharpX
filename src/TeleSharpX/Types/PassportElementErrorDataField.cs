//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class PassportElementErrorDataField : PassportElementError
    {
        /// <summary>
        /// Error source, must be data
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
        /// <summary>
        /// The section of the user&apos;s Telegram Passport which has the error, one of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// Name of the data field which has the error
        /// </summary>
        [JsonProperty("field_name")]
        public string FieldName { get; set; }
        /// <summary>
        /// Base64-encoded data hash
        /// </summary>
        [JsonProperty("data_hash")]
        public string DataHash { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}