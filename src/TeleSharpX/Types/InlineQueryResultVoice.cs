//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineQueryResultVoice : InlineQueryResult
    {
        /// <summary>
        /// Type of the result, must be voice
        /// </summary>
        [JsonProperty("type")]
        public string Type => "voice";
        /// <summary>
        /// Unique identifier for this result, 1-64 bytes
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// A valid URL for the voice recording
        /// </summary>
        [JsonProperty("voice_url")]
        public string VoiceUrl { get; set; }
        /// <summary>
        /// Recording title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Optional. Caption, 0-1024 characters after entities parsing
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }
        /// <summary>
        /// Optional. Mode for parsing entities in the voice message caption. See formatting options for more details.
        /// </summary>
        [JsonProperty("parse_mode")]
        public string ParseMode { get; set; }
        /// <summary>
        /// Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode
        /// </summary>
        [JsonProperty("caption_entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> CaptionEntities { get; set; }
        /// <summary>
        /// Optional. Recording duration in seconds
        /// </summary>
        [JsonProperty("voice_duration")]
        public long VoiceDuration { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message
        /// </summary>
        [JsonProperty("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
        /// <summary>
        /// Optional. Content of the message to be sent instead of the voice recording
        /// </summary>
        [JsonProperty("input_message_content")]
        public InputMessageContent InputMessageContent { get; set; }
    }
}