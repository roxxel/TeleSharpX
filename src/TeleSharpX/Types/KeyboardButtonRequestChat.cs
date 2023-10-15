//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class KeyboardButtonRequestChat 
    {
        /// <summary>
        /// Signed 32-bit identifier of the request, which will be received back in the ChatShared object. Must be unique within the message
        /// </summary>
        [JsonProperty("request_id")]
        public long RequestId { get; set; }
        /// <summary>
        /// Pass True to request a channel chat, pass False to request a group or a supergroup chat.
        /// </summary>
        [JsonProperty("chat_is_channel")]
        public bool ChatIsChannel { get; set; }
        /// <summary>
        /// Optional. Pass True to request a forum supergroup, pass False to request a non-forum chat. If not specified, no additional restrictions are applied.
        /// </summary>
        [JsonProperty("chat_is_forum")]
        public bool ChatIsForum { get; set; }
        /// <summary>
        /// Optional. Pass True to request a supergroup or a channel with a username, pass False to request a chat without a username. If not specified, no additional restrictions are applied.
        /// </summary>
        [JsonProperty("chat_has_username")]
        public bool ChatHasUsername { get; set; }
        /// <summary>
        /// Optional. Pass True to request a chat owned by the user. Otherwise, no additional restrictions are applied.
        /// </summary>
        [JsonProperty("chat_is_created")]
        public bool ChatIsCreated { get; set; }
        /// <summary>
        /// Optional. A JSON-serialized object listing the required administrator rights of the user in the chat. The rights must be a superset of bot_administrator_rights. If not specified, no additional restrictions are applied.
        /// </summary>
        [JsonProperty("user_administrator_rights")]
        public ChatAdministratorRights UserAdministratorRights { get; set; }
        /// <summary>
        /// Optional. A JSON-serialized object listing the required administrator rights of the bot in the chat. The rights must be a subset of user_administrator_rights. If not specified, no additional restrictions are applied.
        /// </summary>
        [JsonProperty("bot_administrator_rights")]
        public ChatAdministratorRights BotAdministratorRights { get; set; }
        /// <summary>
        /// Optional. Pass True to request a chat with the bot as a member. Otherwise, no additional restrictions are applied.
        /// </summary>
        [JsonProperty("bot_is_member")]
        public bool BotIsMember { get; set; }
    }
}