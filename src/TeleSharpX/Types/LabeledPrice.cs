//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class LabeledPrice 
	{
		/// <summary>
		/// Portion label
		/// </summary>
		[JsonPropertyName("label")]
		public string Label { get; set; }
		/// <summary>
		/// Price of the product in the smallest units of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
		/// </summary>
		[JsonPropertyName("amount")]
		public long Amount { get; set; }
	}
}