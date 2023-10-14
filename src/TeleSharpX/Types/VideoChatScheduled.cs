//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class VideoChatScheduled 
    {
        /// <summary>
        /// Point in time (Unix timestamp) when the video chat is supposed to be started by a chat administrator
        /// </summary>
        [JsonPropertyName("start_date")]
        public long StartDate { get; set; }
    }
}