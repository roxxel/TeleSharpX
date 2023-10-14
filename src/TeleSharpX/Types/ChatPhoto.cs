//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ChatPhoto 
    {
        /// <summary>
        /// File identifier of small (160x160) chat photo. This file_id can be used only for photo download and only for as long as the photo is not changed.
        /// </summary>
        [JsonPropertyName("small_file_id")]
        public string SmallFileId { get; set; }
        /// <summary>
        /// Unique file identifier of small (160x160) chat photo, which is supposed to be the same over time and for different bots. Can&apos;t be used to download or reuse the file.
        /// </summary>
        [JsonPropertyName("small_file_unique_id")]
        public string SmallFileUniqueId { get; set; }
        /// <summary>
        /// File identifier of big (640x640) chat photo. This file_id can be used only for photo download and only for as long as the photo is not changed.
        /// </summary>
        [JsonPropertyName("big_file_id")]
        public string BigFileId { get; set; }
        /// <summary>
        /// Unique file identifier of big (640x640) chat photo, which is supposed to be the same over time and for different bots. Can&apos;t be used to download or reuse the file.
        /// </summary>
        [JsonPropertyName("big_file_unique_id")]
        public string BigFileUniqueId { get; set; }
    }
}