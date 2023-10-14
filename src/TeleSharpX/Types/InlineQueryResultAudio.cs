//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineQueryResultAudio 
    {
        /// <summary>
        /// Type of the result, must be audio
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        /// <summary>
        /// Unique identifier for this result, 1-64 bytes
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        /// <summary>
        /// A valid URL for the audio file
        /// </summary>
        [JsonPropertyName("audio_url")]
        public string AudioUrl { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>
        /// Optional. Caption, 0-1024 characters after entities parsing
        /// </summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        /// <summary>
        /// Optional. Mode for parsing entities in the audio caption. See formatting options for more details.
        /// </summary>
        [JsonPropertyName("parse_mode")]
        public string ParseMode { get; set; }
        /// <summary>
        /// Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode
        /// </summary>
        [JsonPropertyName("caption_entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> CaptionEntities { get; set; }
        /// <summary>
        /// Optional. Performer
        /// </summary>
        [JsonPropertyName("performer")]
        public string Performer { get; set; }
        /// <summary>
        /// Optional. Audio duration in seconds
        /// </summary>
        [JsonPropertyName("audio_duration")]
        public long AudioDuration { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message
        /// </summary>
        [JsonPropertyName("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
        /// <summary>
        /// Optional. Content of the message to be sent instead of the audio
        /// </summary>
        [JsonPropertyName("input_message_content")]
        public InputMessageContent InputMessageContent { get; set; }
    }
}