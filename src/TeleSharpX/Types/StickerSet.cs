//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class StickerSet 
    {
        /// <summary>
        /// Sticker set name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Sticker set title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
        /// <summary>
        /// Type of stickers in the set, currently one of “regular”, “mask”, “custom_emoji”
        /// </summary>
        [JsonProperty("sticker_type")]
        public string StickerType { get; set; }
        /// <summary>
        /// True, if the sticker set contains animated stickers
        /// </summary>
        [JsonProperty("is_animated")]
        public bool IsAnimated { get; set; }
        /// <summary>
        /// True, if the sticker set contains video stickers
        /// </summary>
        [JsonProperty("is_video")]
        public bool IsVideo { get; set; }
        /// <summary>
        /// List of all set stickers
        /// </summary>
        [JsonProperty("stickers")]
        public System.Collections.Generic.IEnumerable<Sticker> Stickers { get; set; }
        /// <summary>
        /// Optional. Sticker set thumbnail in the .WEBP, .TGS, or .WEBM format
        /// </summary>
        [JsonProperty("thumbnail")]
        public PhotoSize Thumbnail { get; set; }
    }
}