//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ResponseParameters 
    {
        /// <summary>
        /// Optional. The group has been migrated to a supergroup with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
        /// </summary>
        [JsonPropertyName("migrate_to_chat_id")]
        public long MigrateToChatId { get; set; }
        /// <summary>
        /// Optional. In case of exceeding flood control, the number of seconds left to wait before the request can be repeated
        /// </summary>
        [JsonPropertyName("retry_after")]
        public long RetryAfter { get; set; }
    }
}