//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class Location 
    {
        /// <summary>
        /// Longitude as defined by sender
        /// </summary>
        [JsonProperty("longitude")]
        public float Longitude { get; set; }
        /// <summary>
        /// Latitude as defined by sender
        /// </summary>
        [JsonProperty("latitude")]
        public float Latitude { get; set; }
        /// <summary>
        /// Optional. The radius of uncertainty for the location, measured in meters; 0-1500
        /// </summary>
        [JsonProperty("horizontal_accuracy")]
        public float HorizontalAccuracy { get; set; }
        /// <summary>
        /// Optional. Time relative to the message sending date, during which the location can be updated; in seconds. For active live locations only.
        /// </summary>
        [JsonProperty("live_period")]
        public long LivePeriod { get; set; }
        /// <summary>
        /// Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.
        /// </summary>
        [JsonProperty("heading")]
        public long Heading { get; set; }
        /// <summary>
        /// Optional. The maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.
        /// </summary>
        [JsonProperty("proximity_alert_radius")]
        public long ProximityAlertRadius { get; set; }
    }
}