//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class User 
    {
        /// <summary>
        /// Unique identifier for this user or bot. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type are safe for storing this identifier.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
        /// <summary>
        /// True, if this user is a bot
        /// </summary>
        [JsonProperty("is_bot")]
        public bool IsBot { get; set; }
        /// <summary>
        /// User&apos;s or bot&apos;s first name
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// Optional. User&apos;s or bot&apos;s last name
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        /// <summary>
        /// Optional. User&apos;s or bot&apos;s username
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }
        /// <summary>
        /// Optional. IETF language tag of the user&apos;s language
        /// </summary>
        [JsonProperty("language_code")]
        public string LanguageCode { get; set; }
        /// <summary>
        /// Optional. True, if this user is a Telegram Premium user
        /// </summary>
        [JsonProperty("is_premium")]
        public bool IsPremium { get; set; }
        /// <summary>
        /// Optional. True, if this user added the bot to the attachment menu
        /// </summary>
        [JsonProperty("added_to_attachment_menu")]
        public bool AddedToAttachmentMenu { get; set; }
        /// <summary>
        /// Optional. True, if the bot can be invited to groups. Returned only in getMe.
        /// </summary>
        [JsonProperty("can_join_groups")]
        public bool CanJoinGroups { get; set; }
        /// <summary>
        /// Optional. True, if privacy mode is disabled for the bot. Returned only in getMe.
        /// </summary>
        [JsonProperty("can_read_all_group_messages")]
        public bool CanReadAllGroupMessages { get; set; }
        /// <summary>
        /// Optional. True, if the bot supports inline queries. Returned only in getMe.
        /// </summary>
        [JsonProperty("supports_inline_queries")]
        public bool SupportsInlineQueries { get; set; }
    }
}