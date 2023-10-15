//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InputLocationMessageContent : InputMessageContent
    {
        /// <summary>
        /// Latitude of the location in degrees
        /// </summary>
        [JsonProperty("latitude")]
        public float Latitude { get; set; }
        /// <summary>
        /// Longitude of the location in degrees
        /// </summary>
        [JsonProperty("longitude")]
        public float Longitude { get; set; }
        /// <summary>
        /// Optional. The radius of uncertainty for the location, measured in meters; 0-1500
        /// </summary>
        [JsonProperty("horizontal_accuracy")]
        public float HorizontalAccuracy { get; set; }
        /// <summary>
        /// Optional. Period in seconds for which the location can be updated, should be between 60 and 86400.
        /// </summary>
        [JsonProperty("live_period")]
        public long LivePeriod { get; set; }
        /// <summary>
        /// Optional. For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.
        /// </summary>
        [JsonProperty("heading")]
        public long Heading { get; set; }
        /// <summary>
        /// Optional. For live locations, a maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.
        /// </summary>
        [JsonProperty("proximity_alert_radius")]
        public long ProximityAlertRadius { get; set; }
    }
}