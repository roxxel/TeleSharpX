//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ChatShared 
    {
        /// <summary>
        /// Identifier of the request
        /// </summary>
        [JsonProperty("request_id")]
        public long RequestId { get; set; }
        /// <summary>
        /// Identifier of the shared chat. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type are safe for storing this identifier. The bot may not have access to the chat and could be unable to use this identifier, unless the chat is already known to the bot by some other means.
        /// </summary>
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }
    }
}