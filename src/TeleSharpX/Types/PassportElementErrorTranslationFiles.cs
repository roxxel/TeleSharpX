//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class PassportElementErrorTranslationFiles 
    {
        /// <summary>
        /// Error source, must be translation_files
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
        /// <summary>
        /// Type of element of the user&apos;s Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        /// <summary>
        /// List of base64-encoded file hashes
        /// </summary>
        [JsonPropertyName("file_hashes")]
        public System.Collections.Generic.IEnumerable<string> FileHashes { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}