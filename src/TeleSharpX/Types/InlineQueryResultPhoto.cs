//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineQueryResultPhoto : InlineQueryResult
    {
        /// <summary>
        /// Type of the result, must be photo
        /// </summary>
        [JsonProperty("type")]
        public string Type => "photo";
        /// <summary>
        /// Unique identifier for this result, 1-64 bytes
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// A valid URL of the photo. Photo must be in JPEG format. Photo size must not exceed 5MB
        /// </summary>
        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }
        /// <summary>
        /// URL of the thumbnail for the photo
        /// </summary>
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Optional. Width of the photo
        /// </summary>
        [JsonProperty("photo_width")]
        public long PhotoWidth { get; set; }
        /// <summary>
        /// Optional. Height of the photo
        /// </summary>
        [JsonProperty("photo_height")]
        public long PhotoHeight { get; set; }
        /// <summary>
        /// Optional. Title for the result
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Optional. Short description of the result
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// Optional. Caption of the photo to be sent, 0-1024 characters after entities parsing
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }
        /// <summary>
        /// Optional. Mode for parsing entities in the photo caption. See formatting options for more details.
        /// </summary>
        [JsonProperty("parse_mode")]
        public string ParseMode { get; set; }
        /// <summary>
        /// Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode
        /// </summary>
        [JsonProperty("caption_entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> CaptionEntities { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message
        /// </summary>
        [JsonProperty("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
        /// <summary>
        /// Optional. Content of the message to be sent instead of the photo
        /// </summary>
        [JsonProperty("input_message_content")]
        public InputMessageContent InputMessageContent { get; set; }
    }
}