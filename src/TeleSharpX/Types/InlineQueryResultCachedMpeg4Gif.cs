//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class InlineQueryResultCachedMpeg4Gif 
	{
		/// <summary>
		/// Type of the result, must be mpeg4_gif
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// Unique identifier for this result, 1-64 bytes
		/// </summary>
		[JsonPropertyName("id")]
		public string Id { get; set; }
		/// <summary>
		/// A valid file identifier for the MPEG4 file
		/// </summary>
		[JsonPropertyName("mpeg4_file_id")]
		public string Mpeg4FileId { get; set; }
		/// <summary>
		/// Optional. Title for the result
		/// </summary>
		[JsonPropertyName("title")]
		public string Title { get; set; }
		/// <summary>
		/// Optional. Caption of the MPEG-4 file to be sent, 0-1024 characters after entities parsing
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
		/// Optional. Content of the message to be sent instead of the video animation
		/// </summary>
		[JsonPropertyName("input_message_content")]
		public InputMessageContent InputMessageContent { get; set; }
	}
}