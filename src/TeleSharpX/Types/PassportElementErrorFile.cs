//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class PassportElementErrorFile : PassportElementError
    {
        /// <summary>
        /// Error source, must be file
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
        /// <summary>
        /// The section of the user&apos;s Telegram Passport which has the issue, one of “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// Base64-encoded file hash
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