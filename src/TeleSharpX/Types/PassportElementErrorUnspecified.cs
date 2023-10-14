//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class PassportElementErrorUnspecified 
    {
        /// <summary>
        /// Error source, must be unspecified
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }
        /// <summary>
        /// Type of element of the user&apos;s Telegram Passport which has the issue
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        /// <summary>
        /// Base64-encoded element hash
        /// </summary>
        [JsonPropertyName("element_hash")]
        public string ElementHash { get; set; }
        /// <summary>
        /// Error message
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}