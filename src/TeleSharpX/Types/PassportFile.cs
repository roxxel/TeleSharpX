//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class PassportFile 
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
        /// File size in bytes
        /// </summary>
        [JsonProperty("file_size")]
        public long FileSize { get; set; }
        /// <summary>
        /// Unix time when the file was uploaded
        /// </summary>
        [JsonProperty("file_date")]
        public long FileDate { get; set; }
    }
}