//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ChatPermissions 
    {
        /// <summary>
        /// Optional. True, if the user is allowed to send text messages, contacts, invoices, locations and venues
        /// </summary>
        [JsonProperty("can_send_messages")]
        public bool CanSendMessages { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to send audios
        /// </summary>
        [JsonProperty("can_send_audios")]
        public bool CanSendAudios { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to send documents
        /// </summary>
        [JsonProperty("can_send_documents")]
        public bool CanSendDocuments { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to send photos
        /// </summary>
        [JsonProperty("can_send_photos")]
        public bool CanSendPhotos { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to send videos
        /// </summary>
        [JsonProperty("can_send_videos")]
        public bool CanSendVideos { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to send video notes
        /// </summary>
        [JsonProperty("can_send_video_notes")]
        public bool CanSendVideoNotes { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to send voice notes
        /// </summary>
        [JsonProperty("can_send_voice_notes")]
        public bool CanSendVoiceNotes { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to send polls
        /// </summary>
        [JsonProperty("can_send_polls")]
        public bool CanSendPolls { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to send animations, games, stickers and use inline bots
        /// </summary>
        [JsonProperty("can_send_other_messages")]
        public bool CanSendOtherMessages { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to add web page previews to their messages
        /// </summary>
        [JsonProperty("can_add_web_page_previews")]
        public bool CanAddWebPagePreviews { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to change the chat title, photo and other settings. Ignored in public supergroups
        /// </summary>
        [JsonProperty("can_change_info")]
        public bool CanChangeInfo { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to invite new users to the chat
        /// </summary>
        [JsonProperty("can_invite_users")]
        public bool CanInviteUsers { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to pin messages. Ignored in public supergroups
        /// </summary>
        [JsonProperty("can_pin_messages")]
        public bool CanPinMessages { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to create forum topics. If omitted defaults to the value of can_pin_messages
        /// </summary>
        [JsonProperty("can_manage_topics")]
        public bool CanManageTopics { get; set; }
    }
}