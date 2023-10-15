//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class BotCommandScopeChat : BotCommandScope
	{
		/// <summary>
		/// Scope type, must be chat
		/// </summary>
		[JsonProperty("type")]
		public string Type => "chat";
		/// <summary>
		/// Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername)
		/// </summary>
		[JsonProperty("chat_id")]
		public long ChatId { get; set; }
	}
}