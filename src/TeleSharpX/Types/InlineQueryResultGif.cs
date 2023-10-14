//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class InlineQueryResultGif 
	{
		/// <summary>
		/// Type of the result, must be gif
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// Unique identifier for this result, 1-64 bytes
		/// </summary>
		[JsonPropertyName("id")]
		public string Id { get; set; }
		/// <summary>
		/// A valid URL for the GIF file. File size must not exceed 1MB
		/// </summary>
		[JsonPropertyName("gif_url")]
		public string GifUrl { get; set; }
		/// <summary>
		/// Optional. Width of the GIF
		/// </summary>
		[JsonPropertyName("gif_width")]
		public long GifWidth { get; set; }
		/// <summary>
		/// Optional. Height of the GIF
		/// </summary>
		[JsonPropertyName("gif_height")]
		public long GifHeight { get; set; }
		/// <summary>
		/// Optional. Duration of the GIF in seconds
		/// </summary>
		[JsonPropertyName("gif_duration")]
		public long GifDuration { get; set; }
		/// <summary>
		/// URL of the static (JPEG or GIF) or animated (MPEG4) thumbnail for the result
		/// </summary>
		[JsonPropertyName("thumbnail_url")]
		public string ThumbnailUrl { get; set; }
		/// <summary>
		/// Optional. MIME type of the thumbnail, must be one of “image/jpeg”, “image/gif”, or “video/mp4”. Defaults to “image/jpeg”
		/// </summary>
		[JsonPropertyName("thumbnail_mime_type")]
		public string ThumbnailMimeType { get; set; }
		/// <summary>
		/// Optional. Title for the result
		/// </summary>
		[JsonPropertyName("title")]
		public string Title { get; set; }
		/// <summary>
		/// Optional. Caption of the GIF file to be sent, 0-1024 characters after entities parsing
		/// </summary>
		[JsonPropertyName("caption")]
		public string Caption { get; set; }
		/// <summary>
		/// Optional. Mode for parsing entities in the caption. See formatting options for more details.
		/// </summary>
		[JsonPropertyName("parse_mode")]
		public string ParseMode { get; set; }
		/// <summary>
		/// Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode
		/// </summary>
		[JsonPropertyName("caption_entities")]
		public MessageEntity[] CaptionEntities { get; set; }
		/// <summary>
		/// Optional. Inline keyboard attached to the message
		/// </summary>
		[JsonPropertyName("reply_markup")]
		public InlineKeyboardMarkup ReplyMarkup { get; set; }
		/// <summary>
		/// Optional. Content of the message to be sent instead of the GIF animation
		/// </summary>
		[JsonPropertyName("input_message_content")]
		public InputMessageContent InputMessageContent { get; set; }
	}
}