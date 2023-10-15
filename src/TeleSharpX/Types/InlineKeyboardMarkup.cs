//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InlineKeyboardMarkup : ReplyMarkup
    {
        /// <summary>
        /// Array of button rows, each represented by an Array of InlineKeyboardButton objects
        /// </summary>
        [JsonProperty("inline_keyboard")]
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<InlineKeyboardButton>> InlineKeyboard { get; set; }
    }
}