//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class VideoChatParticipantsInvited 
	{
		/// <summary>
		/// New members that were invited to the video chat
		/// </summary>
		[JsonPropertyName("users")]
		public User[] Users { get; set; }
	}
}