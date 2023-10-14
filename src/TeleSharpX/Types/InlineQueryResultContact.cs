//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class InlineQueryResultContact 
	{
		/// <summary>
		/// Type of the result, must be contact
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// Unique identifier for this result, 1-64 Bytes
		/// </summary>
		[JsonPropertyName("id")]
		public string Id { get; set; }
		/// <summary>
		/// Contact&apos;s phone number
		/// </summary>
		[JsonPropertyName("phone_number")]
		public string PhoneNumber { get; set; }
		/// <summary>
		/// Contact&apos;s first name
		/// </summary>
		[JsonPropertyName("first_name")]
		public string FirstName { get; set; }
		/// <summary>
		/// Optional. Contact&apos;s last name
		/// </summary>
		[JsonPropertyName("last_name")]
		public string LastName { get; set; }
		/// <summary>
		/// Optional. Additional data about the contact in the form of a vCard, 0-2048 bytes
		/// </summary>
		[JsonPropertyName("vcard")]
		public string Vcard { get; set; }
		/// <summary>
		/// Optional. Inline keyboard attached to the message
		/// </summary>
		[JsonPropertyName("reply_markup")]
		public InlineKeyboardMarkup ReplyMarkup { get; set; }
		/// <summary>
		/// Optional. Content of the message to be sent instead of the contact
		/// </summary>
		[JsonPropertyName("input_message_content")]
		public InputMessageContent InputMessageContent { get; set; }
		/// <summary>
		/// Optional. Url of the thumbnail for the result
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