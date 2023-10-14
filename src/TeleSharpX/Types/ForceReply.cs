//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class ForceReply : ReplyMarkup
	{
		/// <summary>
		/// Shows reply interface to the user, as if they manually selected the bot&apos;s message and tapped &apos;Reply&apos;
		/// </summary>
		[JsonPropertyName("force_reply")]
		public bool ForceReplyT { get; set; }
		/// <summary>
		/// Optional. The placeholder to be shown in the input field when the reply is active; 1-64 characters
		/// </summary>
		[JsonPropertyName("input_field_placeholder")]
		public string InputFieldPlaceholder { get; set; }
		/// <summary>
		/// Optional. Use this parameter if you want to force reply from specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot&apos;s message is a reply (has reply_to_message_id), sender of the original message.
		/// </summary>
		[JsonPropertyName("selective")]
		public bool Selective { get; set; }
	}
}