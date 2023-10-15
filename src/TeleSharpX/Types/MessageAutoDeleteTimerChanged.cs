//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class MessageAutoDeleteTimerChanged 
    {
        /// <summary>
        /// New auto-delete time for messages in the chat; in seconds
        /// </summary>
        [JsonProperty("message_auto_delete_time")]
        public long MessageAutoDeleteTime { get; set; }
    }
}