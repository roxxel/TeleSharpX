//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ChatJoinRequest 
    {
        /// <summary>
        /// Chat to which the request was sent
        /// </summary>
        [JsonPropertyName("chat")]
        public Chat Chat { get; set; }
        /// <summary>
        /// User that sent the join request
        /// </summary>
        [JsonPropertyName("from")]
        public User From { get; set; }
        /// <summary>
        /// Identifier of a private chat with the user who sent the join request. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type are safe for storing this identifier. The bot can use this identifier for 24 hours to send messages until the join request is processed, assuming no other administrator contacted the user.
        /// </summary>
        [JsonPropertyName("user_chat_id")]
        public long UserChatId { get; set; }
        /// <summary>
        /// Date the request was sent in Unix time
        /// </summary>
        [JsonPropertyName("date")]
        public long Date { get; set; }
        /// <summary>
        /// Optional. Bio of the user.
        /// </summary>
        [JsonPropertyName("bio")]
        public string Bio { get; set; }
        /// <summary>
        /// Optional. Chat invite link that was used by the user to send the join request
        /// </summary>
        [JsonPropertyName("invite_link")]
        public ChatInviteLink InviteLink { get; set; }
    }
}