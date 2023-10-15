//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class GameHighScore 
    {
        /// <summary>
        /// Position in high score table for the game
        /// </summary>
        [JsonProperty("position")]
        public long Position { get; set; }
        /// <summary>
        /// User
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }
        /// <summary>
        /// Score
        /// </summary>
        [JsonProperty("score")]
        public long Score { get; set; }
    }
}