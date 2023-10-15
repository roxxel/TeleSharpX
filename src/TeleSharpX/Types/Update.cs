//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class Update 
    {
        /// <summary>
        /// The update&apos;s unique identifier. Update identifiers start from a certain positive number and increase sequentially. This ID becomes especially handy if you&apos;re using webhooks, since it allows you to ignore repeated updates or to restore the correct update sequence, should they get out of order. If there are no new updates for at least a week, then identifier of the next update will be chosen randomly instead of sequentially.
        /// </summary>
        [JsonProperty("update_id")]
        public long UpdateId { get; set; }
        /// <summary>
        /// Optional. New incoming message of any kind - text, photo, sticker, etc.
        /// </summary>
        [JsonProperty("message")]
        public Message Message { get; set; }
        /// <summary>
        /// Optional. New version of a message that is known to the bot and was edited
        /// </summary>
        [JsonProperty("edited_message")]
        public Message EditedMessage { get; set; }
        /// <summary>
        /// Optional. New incoming channel post of any kind - text, photo, sticker, etc.
        /// </summary>
        [JsonProperty("channel_post")]
        public Message ChannelPost { get; set; }
        /// <summary>
        /// Optional. New version of a channel post that is known to the bot and was edited
        /// </summary>
        [JsonProperty("edited_channel_post")]
        public Message EditedChannelPost { get; set; }
        /// <summary>
        /// Optional. New incoming inline query
        /// </summary>
        [JsonProperty("inline_query")]
        public InlineQuery InlineQuery { get; set; }
        /// <summary>
        /// Optional. The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.
        /// </summary>
        [JsonProperty("chosen_inline_result")]
        public ChosenInlineResult ChosenInlineResult { get; set; }
        /// <summary>
        /// Optional. New incoming callback query
        /// </summary>
        [JsonProperty("callback_query")]
        public CallbackQuery CallbackQuery { get; set; }
        /// <summary>
        /// Optional. New incoming shipping query. Only for invoices with flexible price
        /// </summary>
        [JsonProperty("shipping_query")]
        public ShippingQuery ShippingQuery { get; set; }
        /// <summary>
        /// Optional. New incoming pre-checkout query. Contains full information about checkout
        /// </summary>
        [JsonProperty("pre_checkout_query")]
        public PreCheckoutQuery PreCheckoutQuery { get; set; }
        /// <summary>
        /// Optional. New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot
        /// </summary>
        [JsonProperty("poll")]
        public Poll Poll { get; set; }
        /// <summary>
        /// Optional. A user changed their answer in a non-anonymous poll. Bots receive new votes only in polls that were sent by the bot itself.
        /// </summary>
        [JsonProperty("poll_answer")]
        public PollAnswer PollAnswer { get; set; }
        /// <summary>
        /// Optional. The bot&apos;s chat member status was updated in a chat. For private chats, this update is received only when the bot is blocked or unblocked by the user.
        /// </summary>
        [JsonProperty("my_chat_member")]
        public ChatMemberUpdated MyChatMember { get; set; }
        /// <summary>
        /// Optional. A chat member&apos;s status was updated in a chat. The bot must be an administrator in the chat and must explicitly specify “chat_member” in the list of allowed_updates to receive these updates.
        /// </summary>
        [JsonProperty("chat_member")]
        public ChatMemberUpdated ChatMember { get; set; }
        /// <summary>
        /// Optional. A request to join the chat has been sent. The bot must have the can_invite_users administrator right in the chat to receive these updates.
        /// </summary>
        [JsonProperty("chat_join_request")]
        public ChatJoinRequest ChatJoinRequest { get; set; }
    }
}