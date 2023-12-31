//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ChatLocation 
    {
        /// <summary>
        /// The location to which the supergroup is connected. Can&apos;t be a live location.
        /// </summary>
        [JsonProperty("location")]
        public Location Location { get; set; }
        /// <summary>
        /// Location address; 1-64 characters, as defined by the chat owner
        /// </summary>
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}