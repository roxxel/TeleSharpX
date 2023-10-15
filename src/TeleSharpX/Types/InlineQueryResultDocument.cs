//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineQueryResultDocument : InlineQueryResult
    {
        /// <summary>
        /// Type of the result, must be document
        /// </summary>
        [JsonProperty("type")]
        public string Type => "document";
        /// <summary>
        /// Unique identifier for this result, 1-64 bytes
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Title for the result
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Optional. Caption of the document to be sent, 0-1024 characters after entities parsing
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }
        /// <summary>
        /// Optional. Mode for parsing entities in the document caption. See formatting options for more details.
        /// </summary>
        [JsonProperty("parse_mode")]
        public string ParseMode { get; set; }
        /// <summary>
        /// Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode
        /// </summary>
        [JsonProperty("caption_entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> CaptionEntities { get; set; }
        /// <summary>
        /// A valid URL for the file
        /// </summary>
        [JsonProperty("document_url")]
        public string DocumentUrl { get; set; }
        /// <summary>
        /// MIME type of the content of the file, either “application/pdf” or “application/zip”
        /// </summary>
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }
        /// <summary>
        /// Optional. Short description of the result
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message
        /// </summary>
        [JsonProperty("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
        /// <summary>
        /// Optional. Content of the message to be sent instead of the file
        /// </summary>
        [JsonProperty("input_message_content")]
        public InputMessageContent InputMessageContent { get; set; }
        /// <summary>
        /// Optional. URL of the thumbnail (JPEG only) for the file
        /// </summary>
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Optional. Thumbnail width
        /// </summary>
        [JsonProperty("thumbnail_width")]
        public long ThumbnailWidth { get; set; }
        /// <summary>
        /// Optional. Thumbnail height
        /// </summary>
        [JsonProperty("thumbnail_height")]
        public long ThumbnailHeight { get; set; }
    }
}