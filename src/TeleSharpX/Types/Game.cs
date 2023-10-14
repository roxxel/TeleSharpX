//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class Game 
	{
		/// <summary>
		/// Title of the game
		/// </summary>
		[JsonPropertyName("title")]
		public string Title { get; set; }
		/// <summary>
		/// Description of the game
		/// </summary>
		[JsonPropertyName("description")]
		public string Description { get; set; }
		/// <summary>
		/// Photo that will be displayed in the game message in chats.
		/// </summary>
		[JsonPropertyName("photo")]
		public PhotoSize[] Photo { get; set; }
		/// <summary>
		/// Optional. Brief description of the game or high scores included in the game message. Can be automatically edited to include current high scores for the game when the bot calls setGameScore, or manually edited using editMessageText. 0-4096 characters.
		/// </summary>
		[JsonPropertyName("text")]
		public string Text { get; set; }
		/// <summary>
		/// Optional. Special entities that appear in text, such as usernames, URLs, bot commands, etc.
		/// </summary>
		[JsonPropertyName("text_entities")]
		public MessageEntity[] TextEntities { get; set; }
		/// <summary>
		/// Optional. Animation that will be displayed in the game message in chats. Upload via BotFather
		/// </summary>
		[JsonPropertyName("animation")]
		public Animation Animation { get; set; }
	}
}