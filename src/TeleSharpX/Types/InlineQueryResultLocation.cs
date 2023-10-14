//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class InlineQueryResultLocation 
	{
		/// <summary>
		/// Type of the result, must be location
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// Unique identifier for this result, 1-64 Bytes
		/// </summary>
		[JsonPropertyName("id")]
		public string Id { get; set; }
		/// <summary>
		/// Location latitude in degrees
		/// </summary>
		[JsonPropertyName("latitude")]
		public float Latitude { get; set; }
		/// <summary>
		/// Location longitude in degrees
		/// </summary>
		[JsonPropertyName("longitude")]
		public float Longitude { get; set; }
		/// <summary>
		/// Location title
		/// </summary>
		[JsonPropertyName("title")]
		public string Title { get; set; }
		/// <summary>
		/// Optional. The radius of uncertainty for the location, measured in meters; 0-1500
		/// </summary>
		[JsonPropertyName("horizontal_accuracy")]
		public float HorizontalAccuracy { get; set; }
		/// <summary>
		/// Optional. Period in seconds for which the location can be updated, should be between 60 and 86400.
		/// </summary>
		[JsonPropertyName("live_period")]
		public long LivePeriod { get; set; }
		/// <summary>
		/// Optional. For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.
		/// </summary>
		[JsonPropertyName("heading")]
		public long Heading { get; set; }
		/// <summary>
		/// Optional. For live locations, a maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.
		/// </summary>
		[JsonPropertyName("proximity_alert_radius")]
		public long ProximityAlertRadius { get; set; }
		/// <summary>
		/// Optional. Inline keyboard attached to the message
		/// </summary>
		[JsonPropertyName("reply_markup")]
		public InlineKeyboardMarkup ReplyMarkup { get; set; }
		/// <summary>
		/// Optional. Content of the message to be sent instead of the location
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