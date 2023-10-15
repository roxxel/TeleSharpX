//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class ReplyKeyboardRemove : ReplyMarkup
    {
        /// <summary>
        /// Requests clients to remove the custom keyboard (user will not be able to summon this keyboard; if you want to hide the keyboard from sight but keep it accessible, use one_time_keyboard in ReplyKeyboardMarkup)
        /// </summary>
        [JsonProperty("remove_keyboard")]
        public bool RemoveKeyboard { get; set; }
        /// <summary>
        /// Optional. Use this parameter if you want to remove the keyboard for specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot&apos;s message is a reply (has reply_to_message_id), sender of the original message.
        /// 
        /// Example: A user votes in a poll, bot returns confirmation message in reply to the vote and removes the keyboard for that user, while still showing the keyboard with poll options to users who haven&apos;t voted yet.
        /// </summary>
        [JsonProperty("selective")]
        public bool Selective { get; set; }
    }
}