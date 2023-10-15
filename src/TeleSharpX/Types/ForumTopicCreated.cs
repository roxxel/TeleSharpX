//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ForumTopicCreated 
    {
        /// <summary>
        /// Name of the topic
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Color of the topic icon in RGB format
        /// </summary>
        [JsonProperty("icon_color")]
        public long IconColor { get; set; }
        /// <summary>
        /// Optional. Unique identifier of the custom emoji shown as the topic icon
        /// </summary>
        [JsonProperty("icon_custom_emoji_id")]
        public string IconCustomEmojiId { get; set; }
    }
}