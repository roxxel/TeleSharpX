//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InputMediaAnimation : InputMedia
    {
        /// <summary>
        /// Type of the result, must be animation
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. More information on Sending Files »
        /// </summary>
        [JsonProperty("media")]
        public string Media { get; set; }
        /// <summary>
        /// Optional. Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail&apos;s width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can&apos;t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. More information on Sending Files »
        /// </summary>
        [JsonProperty("thumbnail")]
        public InputFile Thumbnail { get; set; }
        /// <summary>
        /// Optional. Caption of the animation to be sent, 0-1024 characters after entities parsing
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }
        /// <summary>
        /// Optional. Mode for parsing entities in the animation caption. See formatting options for more details.
        /// </summary>
        [JsonProperty("parse_mode")]
        public string ParseMode { get; set; }
        /// <summary>
        /// Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode
        /// </summary>
        [JsonProperty("caption_entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> CaptionEntities { get; set; }
        /// <summary>
        /// Optional. Animation width
        /// </summary>
        [JsonProperty("width")]
        public long Width { get; set; }
        /// <summary>
        /// Optional. Animation height
        /// </summary>
        [JsonProperty("height")]
        public long Height { get; set; }
        /// <summary>
        /// Optional. Animation duration in seconds
        /// </summary>
        [JsonProperty("duration")]
        public long Duration { get; set; }
        /// <summary>
        /// Optional. Pass True if the animation needs to be covered with a spoiler animation
        /// </summary>
        [JsonProperty("has_spoiler")]
        public bool HasSpoiler { get; set; }
    }
}