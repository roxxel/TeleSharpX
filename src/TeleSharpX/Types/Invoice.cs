//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class Invoice 
	{
		/// <summary>
		/// Product name
		/// </summary>
		[JsonPropertyName("title")]
		public string Title { get; set; }
		/// <summary>
		/// Product description
		/// </summary>
		[JsonPropertyName("description")]
		public string Description { get; set; }
		/// <summary>
		/// Unique bot deep-linking parameter that can be used to generate this invoice
		/// </summary>
		[JsonPropertyName("start_parameter")]
		public string StartParameter { get; set; }
		/// <summary>
		/// Three-letter ISO 4217 currency code
		/// </summary>
		[JsonPropertyName("currency")]
		public string Currency { get; set; }
		/// <summary>
		/// Total price in the smallest units of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
		/// </summary>
		[JsonPropertyName("total_amount")]
		public long TotalAmount { get; set; }
	}
}