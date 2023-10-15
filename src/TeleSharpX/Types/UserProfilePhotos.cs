//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class UserProfilePhotos 
    {
        /// <summary>
        /// Total number of profile pictures the target user has
        /// </summary>
        [JsonProperty("total_count")]
        public long TotalCount { get; set; }
        /// <summary>
        /// Requested profile pictures (in up to 4 sizes each)
        /// </summary>
        [JsonProperty("photos")]
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<PhotoSize>> Photos { get; set; }
    }
}