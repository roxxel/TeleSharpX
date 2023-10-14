//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class WebhookInfo 
	{
		/// <summary>
		/// Webhook URL, may be empty if webhook is not set up
		/// </summary>
		[JsonPropertyName("url")]
		public string Url { get; set; }
		/// <summary>
		/// True, if a custom certificate was provided for webhook certificate checks
		/// </summary>
		[JsonPropertyName("has_custom_certificate")]
		public bool HasCustomCertificate { get; set; }
		/// <summary>
		/// Number of updates awaiting delivery
		/// </summary>
		[JsonPropertyName("pending_update_count")]
		public long PendingUpdateCount { get; set; }
		/// <summary>
		/// Optional. Currently used webhook IP address
		/// </summary>
		[JsonPropertyName("ip_address")]
		public string IpAddress { get; set; }
		/// <summary>
		/// Optional. Unix time for the most recent error that happened when trying to deliver an update via webhook
		/// </summary>
		[JsonPropertyName("last_error_date")]
		public long LastErrorDate { get; set; }
		/// <summary>
		/// Optional. Error message in human-readable format for the most recent error that happened when trying to deliver an update via webhook
		/// </summary>
		[JsonPropertyName("last_error_message")]
		public string LastErrorMessage { get; set; }
		/// <summary>
		/// Optional. Unix time of the most recent error that happened when trying to synchronize available updates with Telegram datacenters
		/// </summary>
		[JsonPropertyName("last_synchronization_error_date")]
		public long LastSynchronizationErrorDate { get; set; }
		/// <summary>
		/// Optional. The maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery
		/// </summary>
		[JsonPropertyName("max_connections")]
		public long MaxConnections { get; set; }
		/// <summary>
		/// Optional. A list of update types the bot is subscribed to. Defaults to all update types except chat_member
		/// </summary>
		[JsonPropertyName("allowed_updates")]
		public string[] AllowedUpdates { get; set; }
	}
}