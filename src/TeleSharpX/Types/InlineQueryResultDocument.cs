//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineQueryResultDocument 
    {
        /// <summary>
        /// Type of the result, must be document
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        /// <summary>
        /// Unique identifier for this result, 1-64 bytes
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        /// <summary>
        /// Title for the result
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>
        /// Optional. Caption of the document to be sent, 0-1024 characters after entities parsing
        /// </summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        /// <summary>
        /// Optional. Mode for parsing entities in the document caption. See formatting options for more details.
        /// </summary>
        [JsonPropertyName("parse_mode")]
        public string ParseMode { get; set; }
        /// <summary>
        /// Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode
        /// </summary>
        [JsonPropertyName("caption_entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> CaptionEntities { get; set; }
        /// <summary>
        /// A valid URL for the file
        /// </summary>
        [JsonPropertyName("document_url")]
        public string DocumentUrl { get; set; }
        /// <summary>
        /// MIME type of the content of the file, either “application/pdf” or “application/zip”
        /// </summary>
        [JsonPropertyName("mime_type")]
        public string MimeType { get; set; }
        /// <summary>
        /// Optional. Short description of the result
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message
        /// </summary>
        [JsonPropertyName("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
        /// <summary>
        /// Optional. Content of the message to be sent instead of the file
        /// </summary>
        [JsonPropertyName("input_message_content")]
        public InputMessageContent InputMessageContent { get; set; }
        /// <summary>
        /// Optional. URL of the thumbnail (JPEG only) for the file
        /// </summary>
        [JsonPropertyName("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Optional. Thumbnail width
        /// </summary>
        [JsonPropertyName("thumbnail_width")]
        public long ThumbnailWidth { get; set; }
        /// <summary>
        /// Optional. Thumbnail height
        /// </summary>
        [JsonPropertyName("thumbnail_height")]
        public long ThumbnailHeight { get; set; }
    }
}