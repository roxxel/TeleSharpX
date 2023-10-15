//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InputVenueMessageContent : InputMessageContent
    {
        /// <summary>
        /// Latitude of the venue in degrees
        /// </summary>
        [JsonProperty("latitude")]
        public float Latitude { get; set; }
        /// <summary>
        /// Longitude of the venue in degrees
        /// </summary>
        [JsonProperty("longitude")]
        public float Longitude { get; set; }
        /// <summary>
        /// Name of the venue
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Address of the venue
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
        /// <summary>
        /// Optional. Foursquare identifier of the venue, if known
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
    }
}