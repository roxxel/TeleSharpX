//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineQueryResultCachedSticker : InlineQueryResult
    {
        /// <summary>
        /// Type of the result, must be sticker
        /// </summary>
        [JsonProperty("type")]
        public string Type => "sticker";
        /// <summary>
        /// Unique identifier for this result, 1-64 bytes
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// A valid file identifier of the sticker
        /// </summary>
        [JsonProperty("sticker_file_id")]
        public string StickerFileId { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message
        /// </summary>
        [JsonProperty("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
        /// <summary>
        /// Optional. Content of the message to be sent instead of the sticker
        /// </summary>
        [JsonProperty("input_message_content")]
        public InputMessageContent InputMessageContent { get; set; }
    }
}