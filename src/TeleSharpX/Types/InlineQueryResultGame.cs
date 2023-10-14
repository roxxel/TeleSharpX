//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class InlineQueryResultGame 
	{
		/// <summary>
		/// Type of the result, must be game
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// Unique identifier for this result, 1-64 bytes
		/// </summary>
		[JsonPropertyName("id")]
		public string Id { get; set; }
		/// <summary>
		/// Short name of the game
		/// </summary>
		[JsonPropertyName("game_short_name")]
		public string GameShortName { get; set; }
		/// <summary>
		/// Optional. Inline keyboard attached to the message
		/// </summary>
		[JsonPropertyName("reply_markup")]
		public InlineKeyboardMarkup ReplyMarkup { get; set; }
	}
}