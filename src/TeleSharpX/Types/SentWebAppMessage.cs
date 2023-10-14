//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class SentWebAppMessage 
    {
        /// <summary>
        /// Optional. Identifier of the sent inline message. Available only if there is an inline keyboard attached to the message.
        /// </summary>
        [JsonPropertyName("inline_message_id")]
        public string InlineMessageId { get; set; }
    }
}