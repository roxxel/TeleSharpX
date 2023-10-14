//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class Dice 
    {
        /// <summary>
        /// Emoji on which the dice throw animation is based
        /// </summary>
        [JsonPropertyName("emoji")]
        public string Emoji { get; set; }
        /// <summary>
        /// Value of the dice, 1-6 for “”, “” and “” base emoji, 1-5 for “” and “” base emoji, 1-64 for “” base emoji
        /// </summary>
        [JsonPropertyName("value")]
        public long Value { get; set; }
    }
}