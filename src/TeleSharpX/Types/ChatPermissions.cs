//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class ChatPermissions 
	{
		/// <summary>
		/// Optional. True, if the user is allowed to send text messages, contacts, invoices, locations and venues
		/// </summary>
		[JsonPropertyName("can_send_messages")]
		public bool CanSendMessages { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to send audios
		/// </summary>
		[JsonPropertyName("can_send_audios")]
		public bool CanSendAudios { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to send documents
		/// </summary>
		[JsonPropertyName("can_send_documents")]
		public bool CanSendDocuments { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to send photos
		/// </summary>
		[JsonPropertyName("can_send_photos")]
		public bool CanSendPhotos { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to send videos
		/// </summary>
		[JsonPropertyName("can_send_videos")]
		public bool CanSendVideos { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to send video notes
		/// </summary>
		[JsonPropertyName("can_send_video_notes")]
		public bool CanSendVideoNotes { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to send voice notes
		/// </summary>
		[JsonPropertyName("can_send_voice_notes")]
		public bool CanSendVoiceNotes { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to send polls
		/// </summary>
		[JsonPropertyName("can_send_polls")]
		public bool CanSendPolls { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to send animations, games, stickers and use inline bots
		/// </summary>
		[JsonPropertyName("can_send_other_messages")]
		public bool CanSendOtherMessages { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to add web page previews to their messages
		/// </summary>
		[JsonPropertyName("can_add_web_page_previews")]
		public bool CanAddWebPagePreviews { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to change the chat title, photo and other settings. Ignored in public supergroups
		/// </summary>
		[JsonPropertyName("can_change_info")]
		public bool CanChangeInfo { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to invite new users to the chat
		/// </summary>
		[JsonPropertyName("can_invite_users")]
		public bool CanInviteUsers { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to pin messages. Ignored in public supergroups
		/// </summary>
		[JsonPropertyName("can_pin_messages")]
		public bool CanPinMessages { get; set; }
		/// <summary>
		/// Optional. True, if the user is allowed to create forum topics. If omitted defaults to the value of can_pin_messages
		/// </summary>
		[JsonPropertyName("can_manage_topics")]
		public bool CanManageTopics { get; set; }
	}
}