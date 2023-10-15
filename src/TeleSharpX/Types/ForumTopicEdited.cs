//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ForumTopicEdited 
    {
        /// <summary>
        /// Optional. New name of the topic, if it was edited
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Optional. New identifier of the custom emoji shown as the topic icon, if it was edited; an empty string if the icon was removed
        /// </summary>
        [JsonProperty("icon_custom_emoji_id")]
        public string IconCustomEmojiId { get; set; }
    }
}