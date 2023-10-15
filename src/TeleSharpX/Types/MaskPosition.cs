//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class MaskPosition 
    {
        /// <summary>
        /// The part of the face relative to which the mask should be placed. One of “forehead”, “eyes”, “mouth”, or “chin”.
        /// </summary>
        [JsonProperty("point")]
        public string Point { get; set; }
        /// <summary>
        /// Shift by X-axis measured in widths of the mask scaled to the face size, from left to right. For example, choosing -1.0 will place mask just to the left of the default mask position.
        /// </summary>
        [JsonProperty("x_shift")]
        public float XShift { get; set; }
        /// <summary>
        /// Shift by Y-axis measured in heights of the mask scaled to the face size, from top to bottom. For example, 1.0 will place the mask just below the default mask position.
        /// </summary>
        [JsonProperty("y_shift")]
        public float YShift { get; set; }
        /// <summary>
        /// Mask scaling coefficient. For example, 2.0 means double size.
        /// </summary>
        [JsonProperty("scale")]
        public float Scale { get; set; }
    }
}