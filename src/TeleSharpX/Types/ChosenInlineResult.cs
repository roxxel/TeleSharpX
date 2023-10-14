//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ChosenInlineResult 
    {
        /// <summary>
        /// The unique identifier for the result that was chosen
        /// </summary>
        [JsonPropertyName("result_id")]
        public string ResultId { get; set; }
        /// <summary>
        /// The user that chose the result
        /// </summary>
        [JsonPropertyName("from")]
        public User From { get; set; }
        /// <summary>
        /// Optional. Sender location, only for bots that require user location
        /// </summary>
        [JsonPropertyName("location")]
        public Location Location { get; set; }
        /// <summary>
        /// Optional. Identifier of the sent inline message. Available only if there is an inline keyboard attached to the message. Will be also received in callback queries and can be used to edit the message.
        /// </summary>
        [JsonPropertyName("inline_message_id")]
        public string InlineMessageId { get; set; }
        /// <summary>
        /// The query that was used to obtain the result
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }
    }
}