//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineQueryResultVenue : InlineQueryResult
    {
        /// <summary>
        /// Type of the result, must be venue
        /// </summary>
        [JsonProperty("type")]
        public string Type => "venue";
        /// <summary>
        /// Unique identifier for this result, 1-64 Bytes
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
        /// <summary>
        /// Latitude of the venue location in degrees
        /// </summary>
        [JsonProperty("latitude")]
        public float Latitude { get; set; }
        /// <summary>
        /// Longitude of the venue location in degrees
        /// </summary>
        [JsonProperty("longitude")]
        public float Longitude { get; set; }
        /// <summary>
        /// Title of the venue
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Address of the venue
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
        /// <summary>
        /// Optional. Foursquare identifier of the venue if known
        /// </summary>
        [JsonProperty("foursquare_id")]
        public string FoursquareId { get; set; }
        /// <summary>
        /// Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)
        /// </summary>
        [JsonProperty("foursquare_type")]
        public string FoursquareType { get; set; }
        /// <summary>
        /// Optional. Google Places identifier of the venue
        /// </summary>
        [JsonProperty("google_place_id")]
        public string GooglePlaceId { get; set; }
        /// <summary>
        /// Optional. Google Places type of the venue. (See supported types.)
        /// </summary>
        [JsonProperty("google_place_type")]
        public string GooglePlaceType { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message
        /// </summary>
        [JsonProperty("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
        /// <summary>
        /// Optional. Content of the message to be sent instead of the venue
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