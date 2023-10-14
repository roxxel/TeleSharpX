//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class SwitchInlineQueryChosenChat 
    {
        /// <summary>
        /// Optional. The default inline query to be inserted in the input field. If left empty, only the bot&apos;s username will be inserted
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }
        /// <summary>
        /// Optional. True, if private chats with users can be chosen
        /// </summary>
        [JsonPropertyName("allow_user_chats")]
        public bool AllowUserChats { get; set; }
        /// <summary>
        /// Optional. True, if private chats with bots can be chosen
        /// </summary>
        [JsonPropertyName("allow_bot_chats")]
        public bool AllowBotChats { get; set; }
        /// <summary>
        /// Optional. True, if group and supergroup chats can be chosen
        /// </summary>
        [JsonPropertyName("allow_group_chats")]
        public bool AllowGroupChats { get; set; }
        /// <summary>
        /// Optional. True, if channel chats can be chosen
        /// </summary>
        [JsonPropertyName("allow_channel_chats")]
        public bool AllowChannelChats { get; set; }
    }
}