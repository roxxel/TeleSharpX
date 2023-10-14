//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class CallbackGame 
    {
        /// <summary>
        /// User identifier
        /// </summary>
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }
        /// <summary>
        /// New score, must be non-negative
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }
        /// <summary>
        /// Pass True if the high score is allowed to decrease. This can be useful when fixing mistakes or banning cheaters
        /// </summary>
        [JsonPropertyName("force")]
        public bool Force { get; set; }
        /// <summary>
        /// Pass True if the game message should not be automatically edited to include the current scoreboard
        /// </summary>
        [JsonPropertyName("disable_edit_message")]
        public bool DisableEditMessage { get; set; }
        /// <summary>
        /// Required if inline_message_id is not specified. Unique identifier for the target chat
        /// </summary>
        [JsonPropertyName("chat_id")]
        public long ChatId { get; set; }
        /// <summary>
        /// Required if inline_message_id is not specified. Identifier of the sent message
        /// </summary>
        [JsonPropertyName("message_id")]
        public long MessageId { get; set; }
        /// <summary>
        /// Required if chat_id and message_id are not specified. Identifier of the inline message
        /// </summary>
        [JsonPropertyName("inline_message_id")]
        public string InlineMessageId { get; set; }
    }
}