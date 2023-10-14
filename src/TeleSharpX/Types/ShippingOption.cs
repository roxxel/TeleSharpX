//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class ShippingOption 
	{
		/// <summary>
		/// Shipping option identifier
		/// </summary>
		[JsonPropertyName("id")]
		public string Id { get; set; }
		/// <summary>
		/// Option title
		/// </summary>
		[JsonPropertyName("title")]
		public string Title { get; set; }
		/// <summary>
		/// List of price portions
		/// </summary>
		[JsonPropertyName("prices")]
		public System.Collections.Generic.IEnumerable<LabeledPrice> Prices { get; set; }
	}
}