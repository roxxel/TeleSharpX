//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class KeyboardButtonRequestUser 
    {
        /// <summary>
        /// Signed 32-bit identifier of the request, which will be received back in the UserShared object. Must be unique within the message
        /// </summary>
        [JsonProperty("request_id")]
        public long RequestId { get; set; }
        /// <summary>
        /// Optional. Pass True to request a bot, pass False to request a regular user. If not specified, no additional restrictions are applied.
        /// </summary>
        [JsonProperty("user_is_bot")]
        public bool UserIsBot { get; set; }
        /// <summary>
        /// Optional. Pass True to request a premium user, pass False to request a non-premium user. If not specified, no additional restrictions are applied.
        /// </summary>
        [JsonProperty("user_is_premium")]
        public bool UserIsPremium { get; set; }
    }
}