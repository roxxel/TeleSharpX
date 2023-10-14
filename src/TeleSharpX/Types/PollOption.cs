//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class PollOption 
	{
		/// <summary>
		/// Option text, 1-100 characters
		/// </summary>
		[JsonPropertyName("text")]
		public string Text { get; set; }
		/// <summary>
		/// Number of users that voted for this option
		/// </summary>
		[JsonPropertyName("voter_count")]
		public long VoterCount { get; set; }
	}
}