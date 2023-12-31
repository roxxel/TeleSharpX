//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class BotCommand 
    {
        /// <summary>
        /// Text of the command; 1-32 characters. Can contain only lowercase English letters, digits and underscores.
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; set; }
        /// <summary>
        /// Description of the command; 1-256 characters.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}