//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InputTextMessageContent : InputMessageContent
    {
        /// <summary>
        /// Text of the message to be sent, 1-4096 characters
        /// </summary>
        [JsonProperty("message_text")]
        public string MessageText { get; set; }
        /// <summary>
        /// Optional. Mode for parsing entities in the message text. See formatting options for more details.
        /// </summary>
        [JsonProperty("parse_mode")]
        public string ParseMode { get; set; }
        /// <summary>
        /// Optional. List of special entities that appear in message text, which can be specified instead of parse_mode
        /// </summary>
        [JsonProperty("entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> Entities { get; set; }
        /// <summary>
        /// Optional. Disables link previews for links in the sent message
        /// </summary>
        [JsonProperty("disable_web_page_preview")]
        public bool DisableWebPagePreview { get; set; }
    }
}