//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ChatInviteLink 
    {
        /// <summary>
        /// The invite link. If the link was created by another chat administrator, then the second part of the link will be replaced with “…”.
        /// </summary>
        [JsonProperty("invite_link")]
        public string InviteLink { get; set; }
        /// <summary>
        /// Creator of the link
        /// </summary>
        [JsonProperty("creator")]
        public User Creator { get; set; }
        /// <summary>
        /// True, if users joining the chat via the link need to be approved by chat administrators
        /// </summary>
        [JsonProperty("creates_join_request")]
        public bool CreatesJoinRequest { get; set; }
        /// <summary>
        /// True, if the link is primary
        /// </summary>
        [JsonProperty("is_primary")]
        public bool IsPrimary { get; set; }
        /// <summary>
        /// True, if the link is revoked
        /// </summary>
        [JsonProperty("is_revoked")]
        public bool IsRevoked { get; set; }
        /// <summary>
        /// Optional. Invite link name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Optional. Point in time (Unix timestamp) when the link will expire or has been expired
        /// </summary>
        [JsonProperty("expire_date")]
        public long ExpireDate { get; set; }
        /// <summary>
        /// Optional. The maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999
        /// </summary>
        [JsonProperty("member_limit")]
        public long MemberLimit { get; set; }
        /// <summary>
        /// Optional. Number of pending join requests created using this link
        /// </summary>
        [JsonProperty("pending_join_request_count")]
        public long PendingJoinRequestCount { get; set; }
    }
}