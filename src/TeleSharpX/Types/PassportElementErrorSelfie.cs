//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class PassportElementErrorSelfie : PassportElementError
    {
        /// <summary>
        /// Error source, must be selfie
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
        /// <summary>
        /// The section of the user&apos;s Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// Base64-encoded hash of the file with the selfie
        /// </summary>
        [JsonProperty("file_hash")]
        public string FileHash { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}