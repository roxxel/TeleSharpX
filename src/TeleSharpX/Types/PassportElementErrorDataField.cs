//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class PassportElementErrorDataField 
	{
		/// <summary>
		/// Error source, must be data
		/// </summary>
		[JsonPropertyName("source")]
		public string Source { get; set; }
		/// <summary>
		/// The section of the user&apos;s Telegram Passport which has the error, one of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// Name of the data field which has the error
		/// </summary>
		[JsonPropertyName("field_name")]
		public string FieldName { get; set; }
		/// <summary>
		/// Base64-encoded data hash
		/// </summary>
		[JsonPropertyName("data_hash")]
		public string DataHash { get; set; }
		/// <summary>
		/// Error message
		/// </summary>
		[JsonPropertyName("message")]
		public string Message { get; set; }
	}
}