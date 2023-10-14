//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class InputMediaAudio 
	{
		/// <summary>
		/// Type of the result, must be audio
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. More information on Sending Files »
		/// </summary>
		[JsonPropertyName("media")]
		public string Media { get; set; }
		/// <summary>
		/// Optional. Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail&apos;s width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can&apos;t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. More information on Sending Files »
		/// </summary>
		[JsonPropertyName("thumbnail")]
		public file Thumbnail { get; set; }
		/// <summary>
		/// Optional. Caption of the audio to be sent, 0-1024 characters after entities parsing
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
		public MessageEntity[] CaptionEntities { get; set; }
		/// <summary>
		/// Optional. Duration of the audio in seconds
		/// </summary>
		[JsonPropertyName("duration")]
		public long Duration { get; set; }
		/// <summary>
		/// Optional. Performer of the audio
		/// </summary>
		[JsonPropertyName("performer")]
		public string Performer { get; set; }
		/// <summary>
		/// Optional. Title of the audio
		/// </summary>
		[JsonPropertyName("title")]
		public string Title { get; set; }
	}
}