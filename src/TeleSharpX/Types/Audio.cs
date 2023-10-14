//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class Audio 
    {
        /// <summary>
        /// Identifier for this file, which can be used to download or reuse the file
        /// </summary>
        [JsonPropertyName("file_id")]
        public string FileId { get; set; }
        /// <summary>
        /// Unique identifier for this file, which is supposed to be the same over time and for different bots. Can&apos;t be used to download or reuse the file.
        /// </summary>
        [JsonPropertyName("file_unique_id")]
        public string FileUniqueId { get; set; }
        /// <summary>
        /// Duration of the audio in seconds as defined by sender
        /// </summary>
        [JsonPropertyName("duration")]
        public long Duration { get; set; }
        /// <summary>
        /// Optional. Performer of the audio as defined by sender or by audio tags
        /// </summary>
        [JsonPropertyName("performer")]
        public string Performer { get; set; }
        /// <summary>
        /// Optional. Title of the audio as defined by sender or by audio tags
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
        /// <summary>
        /// Optional. Original filename as defined by sender
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }
        /// <summary>
        /// Optional. MIME type of the file as defined by sender
        /// </summary>
        [JsonPropertyName("mime_type")]
        public string MimeType { get; set; }
        /// <summary>
        /// Optional. File size in bytes. It can be bigger than 2^31 and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this value.
        /// </summary>
        [JsonPropertyName("file_size")]
        public long FileSize { get; set; }
        /// <summary>
        /// Optional. Thumbnail of the album cover to which the music file belongs
        /// </summary>
        [JsonPropertyName("thumbnail")]
        public PhotoSize Thumbnail { get; set; }
    }
}