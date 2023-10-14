//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class LoginUrl 
	{
		/// <summary>
		/// An HTTPS URL to be opened with user authorization data added to the query string when the button is pressed. If the user refuses to provide authorization data, the original URL without information about the user will be opened. The data added is the same as described in Receiving authorization data.
		/// 
		/// NOTE: You must always check the hash of the received data to verify the authentication and the integrity of the data as described in Checking authorization.
		/// </summary>
		[JsonPropertyName("url")]
		public string Url { get; set; }
		/// <summary>
		/// Optional. New text of the button in forwarded messages.
		/// </summary>
		[JsonPropertyName("forward_text")]
		public string ForwardText { get; set; }
		/// <summary>
		/// Optional. Username of a bot, which will be used for user authorization. See Setting up a bot for more details. If not specified, the current bot&apos;s username will be assumed. The url&apos;s domain must be the same as the domain linked with the bot. See Linking your domain to the bot for more details.
		/// </summary>
		[JsonPropertyName("bot_username")]
		public string BotUsername { get; set; }
		/// <summary>
		/// Optional. Pass True to request the permission for your bot to send messages to the user.
		/// </summary>
		[JsonPropertyName("request_write_access")]
		public bool RequestWriteAccess { get; set; }
	}
}