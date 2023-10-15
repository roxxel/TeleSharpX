//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class Message 
    {
        /// <summary>
        /// Unique message identifier inside this chat
        /// </summary>
        [JsonProperty("message_id")]
        public long MessageId { get; set; }
        /// <summary>
        /// Optional. Unique identifier of a message thread to which the message belongs; for supergroups only
        /// </summary>
        [JsonProperty("message_thread_id")]
        public long MessageThreadId { get; set; }
        /// <summary>
        /// Optional. Sender of the message; empty for messages sent to channels. For backward compatibility, the field contains a fake sender user in non-channel chats, if the message was sent on behalf of a chat.
        /// </summary>
        [JsonProperty("from")]
        public User From { get; set; }
        /// <summary>
        /// Optional. Sender of the message, sent on behalf of a chat. For example, the channel itself for channel posts, the supergroup itself for messages from anonymous group administrators, the linked channel for messages automatically forwarded to the discussion group. For backward compatibility, the field from contains a fake sender user in non-channel chats, if the message was sent on behalf of a chat.
        /// </summary>
        [JsonProperty("sender_chat")]
        public Chat SenderChat { get; set; }
        /// <summary>
        /// Date the message was sent in Unix time
        /// </summary>
        [JsonProperty("date")]
        public long Date { get; set; }
        /// <summary>
        /// Conversation the message belongs to
        /// </summary>
        [JsonProperty("chat")]
        public Chat Chat { get; set; }
        /// <summary>
        /// Optional. For forwarded messages, sender of the original message
        /// </summary>
        [JsonProperty("forward_from")]
        public User ForwardFrom { get; set; }
        /// <summary>
        /// Optional. For messages forwarded from channels or from anonymous administrators, information about the original sender chat
        /// </summary>
        [JsonProperty("forward_from_chat")]
        public Chat ForwardFromChat { get; set; }
        /// <summary>
        /// Optional. For messages forwarded from channels, identifier of the original message in the channel
        /// </summary>
        [JsonProperty("forward_from_message_id")]
        public long ForwardFromMessageId { get; set; }
        /// <summary>
        /// Optional. For forwarded messages that were originally sent in channels or by an anonymous chat administrator, signature of the message sender if present
        /// </summary>
        [JsonProperty("forward_signature")]
        public string ForwardSignature { get; set; }
        /// <summary>
        /// Optional. Sender&apos;s name for messages forwarded from users who disallow adding a link to their account in forwarded messages
        /// </summary>
        [JsonProperty("forward_sender_name")]
        public string ForwardSenderName { get; set; }
        /// <summary>
        /// Optional. For forwarded messages, date the original message was sent in Unix time
        /// </summary>
        [JsonProperty("forward_date")]
        public long ForwardDate { get; set; }
        /// <summary>
        /// Optional. True, if the message is sent to a forum topic
        /// </summary>
        [JsonProperty("is_topic_message")]
        public bool IsTopicMessage { get; set; }
        /// <summary>
        /// Optional. True, if the message is a channel post that was automatically forwarded to the connected discussion group
        /// </summary>
        [JsonProperty("is_automatic_forward")]
        public bool IsAutomaticForward { get; set; }
        /// <summary>
        /// Optional. For replies, the original message. Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.
        /// </summary>
        [JsonProperty("reply_to_message")]
        public Message ReplyToMessage { get; set; }
        /// <summary>
        /// Optional. Bot through which the message was sent
        /// </summary>
        [JsonProperty("via_bot")]
        public User ViaBot { get; set; }
        /// <summary>
        /// Optional. Date the message was last edited in Unix time
        /// </summary>
        [JsonProperty("edit_date")]
        public long EditDate { get; set; }
        /// <summary>
        /// Optional. True, if the message can&apos;t be forwarded
        /// </summary>
        [JsonProperty("has_protected_content")]
        public bool HasProtectedContent { get; set; }
        /// <summary>
        /// Optional. The unique identifier of a media message group this message belongs to
        /// </summary>
        [JsonProperty("media_group_id")]
        public string MediaGroupId { get; set; }
        /// <summary>
        /// Optional. Signature of the post author for messages in channels, or the custom title of an anonymous group administrator
        /// </summary>
        [JsonProperty("author_signature")]
        public string AuthorSignature { get; set; }
        /// <summary>
        /// Optional. For text messages, the actual UTF-8 text of the message
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// Optional. For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text
        /// </summary>
        [JsonProperty("entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> Entities { get; set; }
        /// <summary>
        /// Optional. Message is an animation, information about the animation. For backward compatibility, when this field is set, the document field will also be set
        /// </summary>
        [JsonProperty("animation")]
        public Animation Animation { get; set; }
        /// <summary>
        /// Optional. Message is an audio file, information about the file
        /// </summary>
        [JsonProperty("audio")]
        public Audio Audio { get; set; }
        /// <summary>
        /// Optional. Message is a general file, information about the file
        /// </summary>
        [JsonProperty("document")]
        public Document Document { get; set; }
        /// <summary>
        /// Optional. Message is a photo, available sizes of the photo
        /// </summary>
        [JsonProperty("photo")]
        public System.Collections.Generic.IEnumerable<PhotoSize> Photo { get; set; }
        /// <summary>
        /// Optional. Message is a sticker, information about the sticker
        /// </summary>
        [JsonProperty("sticker")]
        public Sticker Sticker { get; set; }
        /// <summary>
        /// Optional. Message is a forwarded story
        /// </summary>
        [JsonProperty("story")]
        public Story Story { get; set; }
        /// <summary>
        /// Optional. Message is a video, information about the video
        /// </summary>
        [JsonProperty("video")]
        public Video Video { get; set; }
        /// <summary>
        /// Optional. Message is a video note, information about the video message
        /// </summary>
        [JsonProperty("video_note")]
        public VideoNote VideoNote { get; set; }
        /// <summary>
        /// Optional. Message is a voice message, information about the file
        /// </summary>
        [JsonProperty("voice")]
        public Voice Voice { get; set; }
        /// <summary>
        /// Optional. Caption for the animation, audio, document, photo, video or voice
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }
        /// <summary>
        /// Optional. For messages with a caption, special entities like usernames, URLs, bot commands, etc. that appear in the caption
        /// </summary>
        [JsonProperty("caption_entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> CaptionEntities { get; set; }
        /// <summary>
        /// Optional. True, if the message media is covered by a spoiler animation
        /// </summary>
        [JsonProperty("has_media_spoiler")]
        public bool HasMediaSpoiler { get; set; }
        /// <summary>
        /// Optional. Message is a shared contact, information about the contact
        /// </summary>
        [JsonProperty("contact")]
        public Contact Contact { get; set; }
        /// <summary>
        /// Optional. Message is a dice with random value
        /// </summary>
        [JsonProperty("dice")]
        public Dice Dice { get; set; }
        /// <summary>
        /// Optional. Message is a game, information about the game. More about games »
        /// </summary>
        [JsonProperty("game")]
        public Game Game { get; set; }
        /// <summary>
        /// Optional. Message is a native poll, information about the poll
        /// </summary>
        [JsonProperty("poll")]
        public Poll Poll { get; set; }
        /// <summary>
        /// Optional. Message is a venue, information about the venue. For backward compatibility, when this field is set, the location field will also be set
        /// </summary>
        [JsonProperty("venue")]
        public Venue Venue { get; set; }
        /// <summary>
        /// Optional. Message is a shared location, information about the location
        /// </summary>
        [JsonProperty("location")]
        public Location Location { get; set; }
        /// <summary>
        /// Optional. New members that were added to the group or supergroup and information about them (the bot itself may be one of these members)
        /// </summary>
        [JsonProperty("new_chat_members")]
        public System.Collections.Generic.IEnumerable<User> NewChatMembers { get; set; }
        /// <summary>
        /// Optional. A member was removed from the group, information about them (this member may be the bot itself)
        /// </summary>
        [JsonProperty("left_chat_member")]
        public User LeftChatMember { get; set; }
        /// <summary>
        /// Optional. A chat title was changed to this value
        /// </summary>
        [JsonProperty("new_chat_title")]
        public string NewChatTitle { get; set; }
        /// <summary>
        /// Optional. A chat photo was change to this value
        /// </summary>
        [JsonProperty("new_chat_photo")]
        public System.Collections.Generic.IEnumerable<PhotoSize> NewChatPhoto { get; set; }
        /// <summary>
        /// Optional. Service message: the chat photo was deleted
        /// </summary>
        [JsonProperty("delete_chat_photo")]
        public bool DeleteChatPhoto { get; set; }
        /// <summary>
        /// Optional. Service message: the group has been created
        /// </summary>
        [JsonProperty("group_chat_created")]
        public bool GroupChatCreated { get; set; }
        /// <summary>
        /// Optional. Service message: the supergroup has been created. This field can&apos;t be received in a message coming through updates, because bot can&apos;t be a member of a supergroup when it is created. It can only be found in reply_to_message if someone replies to a very first message in a directly created supergroup.
        /// </summary>
        [JsonProperty("supergroup_chat_created")]
        public bool SupergroupChatCreated { get; set; }
        /// <summary>
        /// Optional. Service message: the channel has been created. This field can&apos;t be received in a message coming through updates, because bot can&apos;t be a member of a channel when it is created. It can only be found in reply_to_message if someone replies to a very first message in a channel.
        /// </summary>
        [JsonProperty("channel_chat_created")]
        public bool ChannelChatCreated { get; set; }
        /// <summary>
        /// Optional. Service message: auto-delete timer settings changed in the chat
        /// </summary>
        [JsonProperty("message_auto_delete_timer_changed")]
        public MessageAutoDeleteTimerChanged MessageAutoDeleteTimerChanged { get; set; }
        /// <summary>
        /// Optional. The group has been migrated to a supergroup with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
        /// </summary>
        [JsonProperty("migrate_to_chat_id")]
        public long MigrateToChatId { get; set; }
        /// <summary>
        /// Optional. The supergroup has been migrated from a group with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
        /// </summary>
        [JsonProperty("migrate_from_chat_id")]
        public long MigrateFromChatId { get; set; }
        /// <summary>
        /// Optional. Specified message was pinned. Note that the Message object in this field will not contain further reply_to_message fields even if it is itself a reply.
        /// </summary>
        [JsonProperty("pinned_message")]
        public Message PinnedMessage { get; set; }
        /// <summary>
        /// Optional. Message is an invoice for a payment, information about the invoice. More about payments »
        /// </summary>
        [JsonProperty("invoice")]
        public Invoice Invoice { get; set; }
        /// <summary>
        /// Optional. Message is a service message about a successful payment, information about the payment. More about payments »
        /// </summary>
        [JsonProperty("successful_payment")]
        public SuccessfulPayment SuccessfulPayment { get; set; }
        /// <summary>
        /// Optional. Service message: a user was shared with the bot
        /// </summary>
        [JsonProperty("user_shared")]
        public UserShared UserShared { get; set; }
        /// <summary>
        /// Optional. Service message: a chat was shared with the bot
        /// </summary>
        [JsonProperty("chat_shared")]
        public ChatShared ChatShared { get; set; }
        /// <summary>
        /// Optional. The domain name of the website on which the user has logged in. More about Telegram Login »
        /// </summary>
        [JsonProperty("connected_website")]
        public string ConnectedWebsite { get; set; }
        /// <summary>
        /// Optional. Service message: the user allowed the bot added to the attachment menu to write messages
        /// </summary>
        [JsonProperty("write_access_allowed")]
        public WriteAccessAllowed WriteAccessAllowed { get; set; }
        /// <summary>
        /// Optional. Telegram Passport data
        /// </summary>
        [JsonProperty("passport_data")]
        public PassportData PassportData { get; set; }
        /// <summary>
        /// Optional. Service message. A user in the chat triggered another user&apos;s proximity alert while sharing Live Location.
        /// </summary>
        [JsonProperty("proximity_alert_triggered")]
        public ProximityAlertTriggered ProximityAlertTriggered { get; set; }
        /// <summary>
        /// Optional. Service message: forum topic created
        /// </summary>
        [JsonProperty("forum_topic_created")]
        public ForumTopicCreated ForumTopicCreated { get; set; }
        /// <summary>
        /// Optional. Service message: forum topic edited
        /// </summary>
        [JsonProperty("forum_topic_edited")]
        public ForumTopicEdited ForumTopicEdited { get; set; }
        /// <summary>
        /// Optional. Service message: forum topic closed
        /// </summary>
        [JsonProperty("forum_topic_closed")]
        public ForumTopicClosed ForumTopicClosed { get; set; }
        /// <summary>
        /// Optional. Service message: forum topic reopened
        /// </summary>
        [JsonProperty("forum_topic_reopened")]
        public ForumTopicReopened ForumTopicReopened { get; set; }
        /// <summary>
        /// Optional. Service message: the &apos;General&apos; forum topic hidden
        /// </summary>
        [JsonProperty("general_forum_topic_hidden")]
        public GeneralForumTopicHidden GeneralForumTopicHidden { get; set; }
        /// <summary>
        /// Optional. Service message: the &apos;General&apos; forum topic unhidden
        /// </summary>
        [JsonProperty("general_forum_topic_unhidden")]
        public GeneralForumTopicUnhidden GeneralForumTopicUnhidden { get; set; }
        /// <summary>
        /// Optional. Service message: video chat scheduled
        /// </summary>
        [JsonProperty("video_chat_scheduled")]
        public VideoChatScheduled VideoChatScheduled { get; set; }
        /// <summary>
        /// Optional. Service message: video chat started
        /// </summary>
        [JsonProperty("video_chat_started")]
        public VideoChatStarted VideoChatStarted { get; set; }
        /// <summary>
        /// Optional. Service message: video chat ended
        /// </summary>
        [JsonProperty("video_chat_ended")]
        public VideoChatEnded VideoChatEnded { get; set; }
        /// <summary>
        /// Optional. Service message: new participants invited to a video chat
        /// </summary>
        [JsonProperty("video_chat_participants_invited")]
        public VideoChatParticipantsInvited VideoChatParticipantsInvited { get; set; }
        /// <summary>
        /// Optional. Service message: data sent by a Web App
        /// </summary>
        [JsonProperty("web_app_data")]
        public WebAppData WebAppData { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message. login_url buttons are represented as ordinary url buttons.
        /// </summary>
        [JsonProperty("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
    }
}