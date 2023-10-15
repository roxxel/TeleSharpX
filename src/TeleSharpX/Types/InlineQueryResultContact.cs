//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineQueryResultContact : InlineQueryResult
    {
        /// <summary>
        /// Type of the result, must be contact
        /// </summary>
        [JsonProperty("type")]
        public string Type => "contact";
        /// <summary>
        /// Unique identifier for this result, 1-64 Bytes
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Contact&apos;s phone number
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Contact&apos;s first name
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// Optional. Contact&apos;s last name
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }
        /// <summary>
        /// Optional. Additional data about the contact in the form of a vCard, 0-2048 bytes
        /// </summary>
        [JsonProperty("vcard")]
        public string Vcard { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message
        /// </summary>
        [JsonProperty("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
        /// <summary>
        /// Optional. Content of the message to be sent instead of the contact
        /// </summary>
        [JsonProperty("input_message_content")]
        public InputMessageContent InputMessageContent { get; set; }
        /// <summary>
        /// Optional. Url of the thumbnail for the result
        /// </summary>
        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }
        /// <summary>
        /// Optional. Thumbnail width
        /// </summary>
        [JsonProperty("thumbnail_width")]
        public long ThumbnailWidth { get; set; }
        /// <summary>
        /// Optional. Thumbnail height
        /// </summary>
        [JsonProperty("thumbnail_height")]
        public long ThumbnailHeight { get; set; }
    }
}