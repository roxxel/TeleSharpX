//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class PollAnswer 
	{
		/// <summary>
		/// Unique poll identifier
		/// </summary>
		[JsonPropertyName("poll_id")]
		public string PollId { get; set; }
		/// <summary>
		/// Optional. The chat that changed the answer to the poll, if the voter is anonymous
		/// </summary>
		[JsonPropertyName("voter_chat")]
		public Chat VoterChat { get; set; }
		/// <summary>
		/// Optional. The user that changed the answer to the poll, if the voter isn&apos;t anonymous
		/// </summary>
		[JsonPropertyName("user")]
		public User User { get; set; }
		/// <summary>
		/// 0-based identifiers of chosen answer options. May be empty if the vote was retracted.
		/// </summary>
		[JsonPropertyName("option_ids")]
		public System.Collections.Generic.IEnumerable<long> OptionIds { get; set; }
	}
}