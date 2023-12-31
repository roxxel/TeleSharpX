//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class VideoNote 
    {
        /// <summary>
        /// Identifier for this file, which can be used to download or reuse the file
        /// </summary>
        [JsonProperty("file_id")]
        public string FileId { get; set; }
        /// <summary>
        /// Unique identifier for this file, which is supposed to be the same over time and for different bots. Can&apos;t be used to download or reuse the file.
        /// </summary>
        [JsonProperty("file_unique_id")]
        public string FileUniqueId { get; set; }
        /// <summary>
        /// Video width and height (diameter of the video message) as defined by sender
        /// </summary>
        [JsonProperty("length")]
        public long Length { get; set; }
        /// <summary>
        /// Duration of the video in seconds as defined by sender
        /// </summary>
        [JsonProperty("duration")]
        public long Duration { get; set; }
        /// <summary>
        /// Optional. Video thumbnail
        /// </summary>
        [JsonProperty("thumbnail")]
        public PhotoSize Thumbnail { get; set; }
        /// <summary>
        /// Optional. File size in bytes
        /// </summary>
        [JsonProperty("file_size")]
        public long FileSize { get; set; }
    }
}