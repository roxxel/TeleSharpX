//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ChatMemberUpdated : ChatMember
    {
        /// <summary>
        /// Chat the user belongs to
        /// </summary>
        [JsonProperty("chat")]
        public Chat Chat { get; set; }
        /// <summary>
        /// Performer of the action, which resulted in the change
        /// </summary>
        [JsonProperty("from")]
        public User From { get; set; }
        /// <summary>
        /// Date the change was done in Unix time
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }
        /// <summary>
        /// Previous information about the chat member
        /// </summary>
        [JsonProperty("old_chat_member")]
        public ChatMember OldChatMember { get; set; }
        /// <summary>
        /// New information about the chat member
        /// </summary>
        [JsonProperty("new_chat_member")]
        public ChatMember NewChatMember { get; set; }
        /// <summary>
        /// Optional. Chat invite link, which was used by the user to join the chat; for joining by invite link events only.
        /// </summary>
        [JsonProperty("invite_link")]
        public ChatInviteLink InviteLink { get; set; }
        /// <summary>
        /// Optional. True, if the user joined the chat via a chat folder invite link
        /// </summary>
        [JsonProperty("via_chat_folder_invite_link")]
        public bool ViaChatFolderInviteLink { get; set; }
    }
}