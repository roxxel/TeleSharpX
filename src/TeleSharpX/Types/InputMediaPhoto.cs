//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class InputMediaPhoto 
	{
		/// <summary>
		/// Type of the result, must be photo
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. More information on Sending Files »
		/// </summary>
		[JsonPropertyName("media")]
		public string Media { get; set; }
		/// <summary>
		/// Optional. Caption of the photo to be sent, 0-1024 characters after entities parsing
		/// </summary>
		[JsonPropertyName("caption")]
		public string Caption { get; set; }
		/// <summary>
		/// Optional. Mode for parsing entities in the photo caption. See formatting options for more details.
		/// </summary>
		[JsonPropertyName("parse_mode")]
		public string ParseMode { get; set; }
		/// <summary>
		/// Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode
		/// </summary>
		[JsonPropertyName("caption_entities")]
		public System.Collections.Generic.IEnumerable<MessageEntity> CaptionEntities { get; set; }
		/// <summary>
		/// Optional. Pass True if the photo needs to be covered with a spoiler animation
		/// </summary>
		[JsonPropertyName("has_spoiler")]
		public bool HasSpoiler { get; set; }
	}
}