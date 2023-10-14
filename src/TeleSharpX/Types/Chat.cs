//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class Chat 
	{
		/// <summary>
		/// Unique identifier for this chat. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
		/// </summary>
		[JsonPropertyName("id")]
		public long Id { get; set; }
		/// <summary>
		/// Type of chat, can be either “private”, “group”, “supergroup” or “channel”
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// Optional. Title, for supergroups, channels and group chats
		/// </summary>
		[JsonPropertyName("title")]
		public string Title { get; set; }
		/// <summary>
		/// Optional. Username, for private chats, supergroups and channels if available
		/// </summary>
		[JsonPropertyName("username")]
		public string Username { get; set; }
		/// <summary>
		/// Optional. First name of the other party in a private chat
		/// </summary>
		[JsonPropertyName("first_name")]
		public string FirstName { get; set; }
		/// <summary>
		/// Optional. Last name of the other party in a private chat
		/// </summary>
		[JsonPropertyName("last_name")]
		public string LastName { get; set; }
		/// <summary>
		/// Optional. True, if the supergroup chat is a forum (has topics enabled)
		/// </summary>
		[JsonPropertyName("is_forum")]
		public bool IsForum { get; set; }
		/// <summary>
		/// Optional. Chat photo. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("photo")]
		public ChatPhoto Photo { get; set; }
		/// <summary>
		/// Optional. If non-empty, the list of all active chat usernames; for private chats, supergroups and channels. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("active_usernames")]
		public System.Collections.Generic.IEnumerable<string> ActiveUsernames { get; set; }
		/// <summary>
		/// Optional. Custom emoji identifier of emoji status of the other party in a private chat. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("emoji_status_custom_emoji_id")]
		public string EmojiStatusCustomEmojiId { get; set; }
		/// <summary>
		/// Optional. Expiration date of the emoji status of the other party in a private chat in Unix time, if any. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("emoji_status_expiration_date")]
		public long EmojiStatusExpirationDate { get; set; }
		/// <summary>
		/// Optional. Bio of the other party in a private chat. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("bio")]
		public string Bio { get; set; }
		/// <summary>
		/// Optional. True, if privacy settings of the other party in the private chat allows to use tg://user?id=&lt;user_id&gt; links only in chats with the user. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("has_private_forwards")]
		public bool HasPrivateForwards { get; set; }
		/// <summary>
		/// Optional. True, if the privacy settings of the other party restrict sending voice and video note messages in the private chat. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("has_restricted_voice_and_video_messages")]
		public bool HasRestrictedVoiceAndVideoMessages { get; set; }
		/// <summary>
		/// Optional. True, if users need to join the supergroup before they can send messages. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("join_to_send_messages")]
		public bool JoinToSendMessages { get; set; }
		/// <summary>
		/// Optional. True, if all users directly joining the supergroup need to be approved by supergroup administrators. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("join_by_request")]
		public bool JoinByRequest { get; set; }
		/// <summary>
		/// Optional. Description, for groups, supergroups and channel chats. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("description")]
		public string Description { get; set; }
		/// <summary>
		/// Optional. Primary invite link, for groups, supergroups and channel chats. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("invite_link")]
		public string InviteLink { get; set; }
		/// <summary>
		/// Optional. The most recent pinned message (by sending date). Returned only in getChat.
		/// </summary>
		[JsonPropertyName("pinned_message")]
		public Message PinnedMessage { get; set; }
		/// <summary>
		/// Optional. Default chat member permissions, for groups and supergroups. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("permissions")]
		public ChatPermissions Permissions { get; set; }
		/// <summary>
		/// Optional. For supergroups, the minimum allowed delay between consecutive messages sent by each unpriviledged user; in seconds. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("slow_mode_delay")]
		public long SlowModeDelay { get; set; }
		/// <summary>
		/// Optional. The time after which all messages sent to the chat will be automatically deleted; in seconds. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("message_auto_delete_time")]
		public long MessageAutoDeleteTime { get; set; }
		/// <summary>
		/// Optional. True, if aggressive anti-spam checks are enabled in the supergroup. The field is only available to chat administrators. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("has_aggressive_anti_spam_enabled")]
		public bool HasAggressiveAntiSpamEnabled { get; set; }
		/// <summary>
		/// Optional. True, if non-administrators can only get the list of bots and administrators in the chat. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("has_hidden_members")]
		public bool HasHiddenMembers { get; set; }
		/// <summary>
		/// Optional. True, if messages from the chat can&apos;t be forwarded to other chats. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("has_protected_content")]
		public bool HasProtectedContent { get; set; }
		/// <summary>
		/// Optional. For supergroups, name of group sticker set. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("sticker_set_name")]
		public string StickerSetName { get; set; }
		/// <summary>
		/// Optional. True, if the bot can change the group sticker set. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("can_set_sticker_set")]
		public bool CanSetStickerSet { get; set; }
		/// <summary>
		/// Optional. Unique identifier for the linked chat, i.e. the discussion group identifier for a channel and vice versa; for supergroups and channel chats. This identifier may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("linked_chat_id")]
		public long LinkedChatId { get; set; }
		/// <summary>
		/// Optional. For supergroups, the location to which the supergroup is connected. Returned only in getChat.
		/// </summary>
		[JsonPropertyName("location")]
		public ChatLocation Location { get; set; }
	}
}