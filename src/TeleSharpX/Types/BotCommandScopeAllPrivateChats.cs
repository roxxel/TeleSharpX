//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class BotCommandScopeAllPrivateChats : BotCommandScope
	{
		/// <summary>
		/// Scope type, must be all_private_chats
		/// </summary>
		[JsonProperty("type")]
		public string Type => "all_private_chats";
	}
}