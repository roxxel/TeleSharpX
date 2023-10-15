//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ChatAdministratorRights 
    {
        /// <summary>
        /// True, if the user&apos;s presence in the chat is hidden
        /// </summary>
        [JsonProperty("is_anonymous")]
        public bool IsAnonymous { get; set; }
        /// <summary>
        /// True, if the administrator can access the chat event log, chat statistics, message statistics in channels, see channel members, see anonymous administrators in supergroups and ignore slow mode. Implied by any other administrator privilege
        /// </summary>
        [JsonProperty("can_manage_chat")]
        public bool CanManageChat { get; set; }
        /// <summary>
        /// True, if the administrator can delete messages of other users
        /// </summary>
        [JsonProperty("can_delete_messages")]
        public bool CanDeleteMessages { get; set; }
        /// <summary>
        /// True, if the administrator can manage video chats
        /// </summary>
        [JsonProperty("can_manage_video_chats")]
        public bool CanManageVideoChats { get; set; }
        /// <summary>
        /// True, if the administrator can restrict, ban or unban chat members
        /// </summary>
        [JsonProperty("can_restrict_members")]
        public bool CanRestrictMembers { get; set; }
        /// <summary>
        /// True, if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by the user)
        /// </summary>
        [JsonProperty("can_promote_members")]
        public bool CanPromoteMembers { get; set; }
        /// <summary>
        /// True, if the user is allowed to change the chat title, photo and other settings
        /// </summary>
        [JsonProperty("can_change_info")]
        public bool CanChangeInfo { get; set; }
        /// <summary>
        /// True, if the user is allowed to invite new users to the chat
        /// </summary>
        [JsonProperty("can_invite_users")]
        public bool CanInviteUsers { get; set; }
        /// <summary>
        /// Optional. True, if the administrator can post in the channel; channels only
        /// </summary>
        [JsonProperty("can_post_messages")]
        public bool CanPostMessages { get; set; }
        /// <summary>
        /// Optional. True, if the administrator can edit messages of other users and can pin messages; channels only
        /// </summary>
        [JsonProperty("can_edit_messages")]
        public bool CanEditMessages { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to pin messages; groups and supergroups only
        /// </summary>
        [JsonProperty("can_pin_messages")]
        public bool CanPinMessages { get; set; }
        /// <summary>
        /// Optional. True, if the user is allowed to create, rename, close, and reopen forum topics; supergroups only
        /// </summary>
        [JsonProperty("can_manage_topics")]
        public bool CanManageTopics { get; set; }
    }
}