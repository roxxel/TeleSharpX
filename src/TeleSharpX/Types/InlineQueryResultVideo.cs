//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineQueryResultVideo : InlineQueryResult
    {
        /// <summary>
        /// Type of the result, must be video
        /// </summary>
        [JsonProperty("type")]
        public string Type => "video";
        /// <summary>
        /// Unique identifier for this result, 1-64 bytes
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// A valid URL for the embedded video player or video file
        /// </summary>
        [JsonProperty("video_url")]
        public string VideoUrl { get; set; }
        /// <summary>
        /// MIME type of the content of the video URL, “text/html” or “video/mp4”
        /// </summary>
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }
        /// <summary>
        /// URL of the thumbnail (JPEG only) for the video
        /// </summary>
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Title for the result
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Optional. Caption of the video to be sent, 0-1024 characters after entities parsing
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }
        /// <summary>
        /// Optional. Mode for parsing entities in the video caption. See formatting options for more details.
        /// </summary>
        [JsonProperty("parse_mode")]
        public string ParseMode { get; set; }
        /// <summary>
        /// Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode
        /// </summary>
        [JsonProperty("caption_entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> CaptionEntities { get; set; }
        /// <summary>
        /// Optional. Video width
        /// </summary>
        [JsonProperty("video_width")]
        public long VideoWidth { get; set; }
        /// <summary>
        /// Optional. Video height
        /// </summary>
        [JsonProperty("video_height")]
        public long VideoHeight { get; set; }
        /// <summary>
        /// Optional. Video duration in seconds
        /// </summary>
        [JsonProperty("video_duration")]
        public long VideoDuration { get; set; }
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
        /// Optional. Content of the message to be sent instead of the video. This field is required if InlineQueryResultVideo is used to send an HTML-page as a result (e.g., a YouTube video).
        /// </summary>
        [JsonProperty("input_message_content")]
        public InputMessageContent InputMessageContent { get; set; }
    }
}