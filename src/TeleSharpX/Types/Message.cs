//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class Message 
    {
        /// <summary>
        /// Unique message identifier inside this chat
        /// </summary>
        [JsonPropertyName("message_id")]
        public long MessageId { get; set; }
        /// <summary>
        /// Optional. Unique identifier of a message thread to which the message belongs; for supergroups only
        /// </summary>
        [JsonPropertyName("message_thread_id")]
        public long MessageThreadId { get; set; }
        /// <summary>
        /// Optional. Sender of the message; empty for messages sent to channels. For backward compatibility, the field contains a fake sender user in non-channel chats, if the message was sent on behalf of a chat.
        /// </summary>
        [JsonPropertyName("from")]
        public User From { get; set; }
        /// <summary>
        /// Optional. Sender of the message, sent on behalf of a chat. For example, the channel itself for channel posts, the supergroup itself for messages from anonymous group administrators, the linked channel for messages automatically forwarded to the discussion group. For backward compatibility, the field from contains a fake sender user in non-channel chats, if the message was sent on behalf of a chat.
        /// </summary>
        [JsonPropertyName("sender_chat")]
        public Chat SenderChat { get; set; }
        /// <summary>
        /// Date the message was sent in Unix time
        /// </summary>
        [JsonPropertyName("date")]
        public long Date { get; set; }
        /// <summary>
        /// Conversation the message belongs to
        /// </summary>
        [JsonPropertyName("chat")]
        public Chat Chat { get; set; }
        /// <summary>
        /// Optional. For forwarded messages, sender of the original message
        /// </summary>
        [JsonPropertyName("forward_from")]
        public User ForwardFrom { get; set; }
        /// <summary>
        /// Optional. For messages forwarded from channels or from anonymous administrators, information about the original sender chat
        /// </summary>
        [JsonPropertyName("forward_from_chat")]
        public Chat ForwardFromChat { get; set; }
        /// <summary>
        /// Optional. For messages forwarded from channels, identifier of the original message in the channel
        /// </summary>
        [JsonPropertyName("forward_from_message_id")]
        public long ForwardFromMessageId { get; set; }
        /// <summary>
        /// Optional. For forwarded messages that were originally sent in channels or by an anonymous chat administrator, signature of the message sender if present
        /// </summary>
        [JsonPropertyName("forward_signature")]
        public string ForwardSignature { get; set; }
        /// <summary>
        /// Optional. Sender&apos;s name for messages forwarded from users who disallow adding a link to their account in forwarded messages
        /// </summary>
        [JsonPropertyName("forward_sender_name")]
        public string ForwardSenderName { get; set; }
        /// <summary>
        /// Optional. For forwarded messages, date the original message was sent in Unix time
        /// </summary>
        [JsonPropertyName("forward_date")]
        public long ForwardDate { get; set; }
        /// <summary>
        /// Optional. True, if the message is sent to a forum topic
        /// </summary>
        [JsonPropertyName("is_topic_message")]
        public bool IsTopicMessage { get; set; }
        /// <summary>
        /// Optional. True, if the message is a channel post that was automatically forwarded to the connected discussion group
        /// </summary>
        [JsonPropertyName("is_automatic_forward")]
        public bool IsAutomaticForward { get; set; }
        /// <summary>
        /// Optional. For replies, the original message. Note that the Message object in this field will not contain further reply_to_message fields even if it itself is a reply.
        /// </summary>
        [JsonPropertyName("reply_to_message")]
        public Message ReplyToMessage { get; set; }
        /// <summary>
        /// Optional. Bot through which the message was sent
        /// </summary>
        [JsonPropertyName("via_bot")]
        public User ViaBot { get; set; }
        /// <summary>
        /// Optional. Date the message was last edited in Unix time
        /// </summary>
        [JsonPropertyName("edit_date")]
        public long EditDate { get; set; }
        /// <summary>
        /// Optional. True, if the message can&apos;t be forwarded
        /// </summary>
        [JsonPropertyName("has_protected_content")]
        public bool HasProtectedContent { get; set; }
        /// <summary>
        /// Optional. The unique identifier of a media message group this message belongs to
        /// </summary>
        [JsonPropertyName("media_group_id")]
        public string MediaGroupId { get; set; }
        /// <summary>
        /// Optional. Signature of the post author for messages in channels, or the custom title of an anonymous group administrator
        /// </summary>
        [JsonPropertyName("author_signature")]
        public string AuthorSignature { get; set; }
        /// <summary>
        /// Optional. For text messages, the actual UTF-8 text of the message
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
        /// <summary>
        /// Optional. For text messages, special entities like usernames, URLs, bot commands, etc. that appear in the text
        /// </summary>
        [JsonPropertyName("entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> Entities { get; set; }
        /// <summary>
        /// Optional. Message is an animation, information about the animation. For backward compatibility, when this field is set, the document field will also be set
        /// </summary>
        [JsonPropertyName("animation")]
        public Animation Animation { get; set; }
        /// <summary>
        /// Optional. Message is an audio file, information about the file
        /// </summary>
        [JsonPropertyName("audio")]
        public Audio Audio { get; set; }
        /// <summary>
        /// Optional. Message is a general file, information about the file
        /// </summary>
        [JsonPropertyName("document")]
        public Document Document { get; set; }
        /// <summary>
        /// Optional. Message is a photo, available sizes of the photo
        /// </summary>
        [JsonPropertyName("photo")]
        public System.Collections.Generic.IEnumerable<PhotoSize> Photo { get; set; }
        /// <summary>
        /// Optional. Message is a sticker, information about the sticker
        /// </summary>
        [JsonPropertyName("sticker")]
        public Sticker Sticker { get; set; }
        /// <summary>
        /// Optional. Message is a forwarded story
        /// </summary>
        [JsonPropertyName("story")]
        public Story Story { get; set; }
        /// <summary>
        /// Optional. Message is a video, information about the video
        /// </summary>
        [JsonPropertyName("video")]
        public Video Video { get; set; }
        /// <summary>
        /// Optional. Message is a video note, information about the video message
        /// </summary>
        [JsonPropertyName("video_note")]
        public VideoNote VideoNote { get; set; }
        /// <summary>
        /// Optional. Message is a voice message, information about the file
        /// </summary>
        [JsonPropertyName("voice")]
        public Voice Voice { get; set; }
        /// <summary>
        /// Optional. Caption for the animation, audio, document, photo, video or voice
        /// </summary>
        [JsonPropertyName("caption")]
        public string Caption { get; set; }
        /// <summary>
        /// Optional. For messages with a caption, special entities like usernames, URLs, bot commands, etc. that appear in the caption
        /// </summary>
        [JsonPropertyName("caption_entities")]
        public System.Collections.Generic.IEnumerable<MessageEntity> CaptionEntities { get; set; }
        /// <summary>
        /// Optional. True, if the message media is covered by a spoiler animation
        /// </summary>
        [JsonPropertyName("has_media_spoiler")]
        public bool HasMediaSpoiler { get; set; }
        /// <summary>
        /// Optional. Message is a shared contact, information about the contact
        /// </summary>
        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }
        /// <summary>
        /// Optional. Message is a dice with random value
        /// </summary>
        [JsonPropertyName("dice")]
        public Dice Dice { get; set; }
        /// <summary>
        /// Optional. Message is a game, information about the game. More about games »
        /// </summary>
        [JsonPropertyName("game")]
        public Game Game { get; set; }
        /// <summary>
        /// Optional. Message is a native poll, information about the poll
        /// </summary>
        [JsonPropertyName("poll")]
        public Poll Poll { get; set; }
        /// <summary>
        /// Optional. Message is a venue, information about the venue. For backward compatibility, when this field is set, the location field will also be set
        /// </summary>
        [JsonPropertyName("venue")]
        public Venue Venue { get; set; }
        /// <summary>
        /// Optional. Message is a shared location, information about the location
        /// </summary>
        [JsonPropertyName("location")]
        public Location Location { get; set; }
        /// <summary>
        /// Optional. New members that were added to the group or supergroup and information about them (the bot itself may be one of these members)
        /// </summary>
        [JsonPropertyName("new_chat_members")]
        public System.Collections.Generic.IEnumerable<User> NewChatMembers { get; set; }
        /// <summary>
        /// Optional. A member was removed from the group, information about them (this member may be the bot itself)
        /// </summary>
        [JsonPropertyName("left_chat_member")]
        public User LeftChatMember { get; set; }
        /// <summary>
        /// Optional. A chat title was changed to this value
        /// </summary>
        [JsonPropertyName("new_chat_title")]
        public string NewChatTitle { get; set; }
        /// <summary>
        /// Optional. A chat photo was change to this value
        /// </summary>
        [JsonPropertyName("new_chat_photo")]
        public System.Collections.Generic.IEnumerable<PhotoSize> NewChatPhoto { get; set; }
        /// <summary>
        /// Optional. Service message: the chat photo was deleted
        /// </summary>
        [JsonPropertyName("delete_chat_photo")]
        public bool DeleteChatPhoto { get; set; }
        /// <summary>
        /// Optional. Service message: the group has been created
        /// </summary>
        [JsonPropertyName("group_chat_created")]
        public bool GroupChatCreated { get; set; }
        /// <summary>
        /// Optional. Service message: the supergroup has been created. This field can&apos;t be received in a message coming through updates, because bot can&apos;t be a member of a supergroup when it is created. It can only be found in reply_to_message if someone replies to a very first message in a directly created supergroup.
        /// </summary>
        [JsonPropertyName("supergroup_chat_created")]
        public bool SupergroupChatCreated { get; set; }
        /// <summary>
        /// Optional. Service message: the channel has been created. This field can&apos;t be received in a message coming through updates, because bot can&apos;t be a member of a channel when it is created. It can only be found in reply_to_message if someone replies to a very first message in a channel.
        /// </summary>
        [JsonPropertyName("channel_chat_created")]
        public bool ChannelChatCreated { get; set; }
        /// <summary>
        /// Optional. Service message: auto-delete timer settings changed in the chat
        /// </summary>
        [JsonPropertyName("message_auto_delete_timer_changed")]
        public MessageAutoDeleteTimerChanged MessageAutoDeleteTimerChanged { get; set; }
        /// <summary>
        /// Optional. The group has been migrated to a supergroup with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
        /// </summary>
        [JsonPropertyName("migrate_to_chat_id")]
        public long MigrateToChatId { get; set; }
        /// <summary>
        /// Optional. The supergroup has been migrated from a group with the specified identifier. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
        /// </summary>
        [JsonPropertyName("migrate_from_chat_id")]
        public long MigrateFromChatId { get; set; }
        /// <summary>
        /// Optional. Specified message was pinned. Note that the Message object in this field will not contain further reply_to_message fields even if it is itself a reply.
        /// </summary>
        [JsonPropertyName("pinned_message")]
        public Message PinnedMessage { get; set; }
        /// <summary>
        /// Optional. Message is an invoice for a payment, information about the invoice. More about payments »
        /// </summary>
        [JsonPropertyName("invoice")]
        public Invoice Invoice { get; set; }
        /// <summary>
        /// Optional. Message is a service message about a successful payment, information about the payment. More about payments »
        /// </summary>
        [JsonPropertyName("successful_payment")]
        public SuccessfulPayment SuccessfulPayment { get; set; }
        /// <summary>
        /// Optional. Service message: a user was shared with the bot
        /// </summary>
        [JsonPropertyName("user_shared")]
        public UserShared UserShared { get; set; }
        /// <summary>
        /// Optional. Service message: a chat was shared with the bot
        /// </summary>
        [JsonPropertyName("chat_shared")]
        public ChatShared ChatShared { get; set; }
        /// <summary>
        /// Optional. The domain name of the website on which the user has logged in. More about Telegram Login »
        /// </summary>
        [JsonPropertyName("connected_website")]
        public string ConnectedWebsite { get; set; }
        /// <summary>
        /// Optional. Service message: the user allowed the bot added to the attachment menu to write messages
        /// </summary>
        [JsonPropertyName("write_access_allowed")]
        public WriteAccessAllowed WriteAccessAllowed { get; set; }
        /// <summary>
        /// Optional. Telegram Passport data
        /// </summary>
        [JsonPropertyName("passport_data")]
        public PassportData PassportData { get; set; }
        /// <summary>
        /// Optional. Service message. A user in the chat triggered another user&apos;s proximity alert while sharing Live Location.
        /// </summary>
        [JsonPropertyName("proximity_alert_triggered")]
        public ProximityAlertTriggered ProximityAlertTriggered { get; set; }
        /// <summary>
        /// Optional. Service message: forum topic created
        /// </summary>
        [JsonPropertyName("forum_topic_created")]
        public ForumTopicCreated ForumTopicCreated { get; set; }
        /// <summary>
        /// Optional. Service message: forum topic edited
        /// </summary>
        [JsonPropertyName("forum_topic_edited")]
        public ForumTopicEdited ForumTopicEdited { get; set; }
        /// <summary>
        /// Optional. Service message: forum topic closed
        /// </summary>
        [JsonPropertyName("forum_topic_closed")]
        public ForumTopicClosed ForumTopicClosed { get; set; }
        /// <summary>
        /// Optional. Service message: forum topic reopened
        /// </summary>
        [JsonPropertyName("forum_topic_reopened")]
        public ForumTopicReopened ForumTopicReopened { get; set; }
        /// <summary>
        /// Optional. Service message: the &apos;General&apos; forum topic hidden
        /// </summary>
        [JsonPropertyName("general_forum_topic_hidden")]
        public GeneralForumTopicHidden GeneralForumTopicHidden { get; set; }
        /// <summary>
        /// Optional. Service message: the &apos;General&apos; forum topic unhidden
        /// </summary>
        [JsonPropertyName("general_forum_topic_unhidden")]
        public GeneralForumTopicUnhidden GeneralForumTopicUnhidden { get; set; }
        /// <summary>
        /// Optional. Service message: video chat scheduled
        /// </summary>
        [JsonPropertyName("video_chat_scheduled")]
        public VideoChatScheduled VideoChatScheduled { get; set; }
        /// <summary>
        /// Optional. Service message: video chat started
        /// </summary>
        [JsonPropertyName("video_chat_started")]
        public VideoChatStarted VideoChatStarted { get; set; }
        /// <summary>
        /// Optional. Service message: video chat ended
        /// </summary>
        [JsonPropertyName("video_chat_ended")]
        public VideoChatEnded VideoChatEnded { get; set; }
        /// <summary>
        /// Optional. Service message: new participants invited to a video chat
        /// </summary>
        [JsonPropertyName("video_chat_participants_invited")]
        public VideoChatParticipantsInvited VideoChatParticipantsInvited { get; set; }
        /// <summary>
        /// Optional. Service message: data sent by a Web App
        /// </summary>
        [JsonPropertyName("web_app_data")]
        public WebAppData WebAppData { get; set; }
        /// <summary>
        /// Optional. Inline keyboard attached to the message. login_url buttons are represented as ordinary url buttons.
        /// </summary>
        [JsonPropertyName("reply_markup")]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
    }
}