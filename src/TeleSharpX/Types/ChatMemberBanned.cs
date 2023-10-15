//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ChatMemberBanned : ChatMember
    {
        /// <summary>
        /// Information about the user
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }
        /// <summary>
        /// Date when restrictions will be lifted for this user; Unix time. If 0, then the user is banned forever
        /// </summary>
        [JsonProperty("until_date")]
        public long UntilDate { get; set; }
    }
}