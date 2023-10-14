//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class ShippingQuery 
	{
		/// <summary>
		/// Unique query identifier
		/// </summary>
		[JsonPropertyName("id")]
		public string Id { get; set; }
		/// <summary>
		/// User who sent the query
		/// </summary>
		[JsonPropertyName("from")]
		public User From { get; set; }
		/// <summary>
		/// Bot specified invoice payload
		/// </summary>
		[JsonPropertyName("invoice_payload")]
		public string InvoicePayload { get; set; }
		/// <summary>
		/// User specified shipping address
		/// </summary>
		[JsonPropertyName("shipping_address")]
		public ShippingAddress ShippingAddress { get; set; }
	}
}