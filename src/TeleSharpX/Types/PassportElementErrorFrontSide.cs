//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class PassportElementErrorFrontSide 
	{
		/// <summary>
		/// Error source, must be front_side
		/// </summary>
		[JsonPropertyName("source")]
		public string Source { get; set; }
		/// <summary>
		/// The section of the user&apos;s Telegram Passport which has the issue, one of “passport”, “driver_license”, “identity_card”, “internal_passport”
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// Base64-encoded hash of the file with the front side of the document
		/// </summary>
		[JsonPropertyName("file_hash")]
		public string FileHash { get; set; }
		/// <summary>
		/// Error message
		/// </summary>
		[JsonPropertyName("message")]
		public string Message { get; set; }
	}
}