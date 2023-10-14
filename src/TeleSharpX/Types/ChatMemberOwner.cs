//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class ChatMemberOwner 
	{
		/// <summary>
		/// Information about the user
		/// </summary>
		[JsonPropertyName("user")]
		public User User { get; set; }
		/// <summary>
		/// True, if the user&apos;s presence in the chat is hidden
		/// </summary>
		[JsonPropertyName("is_anonymous")]
		public bool IsAnonymous { get; set; }
		/// <summary>
		/// Optional. Custom title for this user
		/// </summary>
		[JsonPropertyName("custom_title")]
		public string CustomTitle { get; set; }
	}
}