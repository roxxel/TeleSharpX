//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineQueryResultArticle : InlineQueryResult
    {
        /// <summary>
        /// Type of the result, must be article
        /// </summary>
        [JsonProperty("type")]
        public string Type => "article";
        /// <summary>
        /// Unique identifier for this result, 1-64 Bytes
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Title of the result
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Content of the message to be sent
        /// </summary>
        [JsonProperty("input_message_content")]
        public InputMessageContent InputMessageContent { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message
        /// </summary>
        [JsonProperty("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
        /// <summary>
        /// Optional. URL of the result
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        /// <summary>
        /// Optional. Pass True if you don&apos;t want the URL to be shown in the message
        /// </summary>
        [JsonProperty("hide_url")]
        public bool HideUrl { get; set; }
        /// <summary>
        /// Optional. Short description of the result
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        /// Optional. Url of the thumbnail for the result
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