//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class BotCommandScopeChatMember : BotCommandScope
	{
		/// <summary>
		/// Scope type, must be chat_member
		/// </summary>
		[JsonPropertyName("type")]
		public string Type => "chat_member";
		/// <summary>
		/// Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername)
		/// </summary>
		[JsonPropertyName("chat_id")]
		public long ChatId { get; set; }
		/// <summary>
		/// Unique identifier of the target user
		/// </summary>
		[JsonPropertyName("user_id")]
		public long UserId { get; set; }
	}
}