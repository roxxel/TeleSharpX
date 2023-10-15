//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class Video 
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
        /// Video width as defined by sender
        /// </summary>
        [JsonProperty("width")]
        public long Width { get; set; }
        /// <summary>
        /// Video height as defined by sender
        /// </summary>
        [JsonProperty("height")]
        public long Height { get; set; }
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
        /// Optional. Original filename as defined by sender
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName { get; set; }
        /// <summary>
        /// Optional. MIME type of the file as defined by sender
        /// </summary>
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }
        /// <summary>
        /// Optional. File size in bytes. It can be bigger than 2^31 and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this value.
        /// </summary>
        [JsonProperty("file_size")]
        public long FileSize { get; set; }
    }
}