//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class GameHighScore 
	{
		/// <summary>
		/// Position in high score table for the game
		/// </summary>
		[JsonPropertyName("position")]
		public long Position { get; set; }
		/// <summary>
		/// User
		/// </summary>
		[JsonPropertyName("user")]
		public User User { get; set; }
		/// <summary>
		/// Score
		/// </summary>
		[JsonPropertyName("score")]
		public long Score { get; set; }
	}
}