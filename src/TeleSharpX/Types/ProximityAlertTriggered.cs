//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class ProximityAlertTriggered 
	{
		/// <summary>
		/// User that triggered the alert
		/// </summary>
		[JsonPropertyName("traveler")]
		public User Traveler { get; set; }
		/// <summary>
		/// User that set the alert
		/// </summary>
		[JsonPropertyName("watcher")]
		public User Watcher { get; set; }
		/// <summary>
		/// The distance between the users
		/// </summary>
		[JsonPropertyName("distance")]
		public long Distance { get; set; }
	}
}