//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class MessageEntity 
	{
		/// <summary>
		/// Type of the entity. Currently, can be “mention” (@username), “hashtag” (#hashtag), “cashtag” ($USD), “bot_command” (/start@jobs_bot), “url” (https://telegram.org), “email” (do-not-reply@telegram.org), “phone_number” (+1-212-555-0123), “bold” (bold text), “italic” (italic text), “underline” (underlined text), “strikethrough” (strikethrough text), “spoiler” (spoiler message), “code” (monowidth string), “pre” (monowidth block), “text_link” (for clickable text URLs), “text_mention” (for users without usernames), “custom_emoji” (for inline custom emoji stickers)
		/// </summary>
		[JsonPropertyName("type")]
		public string Type { get; set; }
		/// <summary>
		/// Offset in UTF-16 code units to the start of the entity
		/// </summary>
		[JsonPropertyName("offset")]
		public long Offset { get; set; }
		/// <summary>
		/// Length of the entity in UTF-16 code units
		/// </summary>
		[JsonPropertyName("length")]
		public long Length { get; set; }
		/// <summary>
		/// Optional. For “text_link” only, URL that will be opened after user taps on the text
		/// </summary>
		[JsonPropertyName("url")]
		public string Url { get; set; }
		/// <summary>
		/// Optional. For “text_mention” only, the mentioned user
		/// </summary>
		[JsonPropertyName("user")]
		public User User { get; set; }
		/// <summary>
		/// Optional. For “pre” only, the programming language of the entity text
		/// </summary>
		[JsonPropertyName("language")]
		public string Language { get; set; }
		/// <summary>
		/// Optional. For “custom_emoji” only, unique identifier of the custom emoji. Use getCustomEmojiStickers to get full information about the sticker
		/// </summary>
		[JsonPropertyName("custom_emoji_id")]
		public string CustomEmojiId { get; set; }
	}
}