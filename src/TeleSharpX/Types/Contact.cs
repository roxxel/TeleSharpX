//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class Contact 
    {
        /// <summary>
        /// Contact&apos;s phone number
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Contact&apos;s first name
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }
        /// <summary>
        /// Optional. Contact&apos;s last name
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }
        /// <summary>
        /// Optional. Contact&apos;s user identifier in Telegram. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type are safe for storing this identifier.
        /// </summary>
        [JsonPropertyName("user_id")]
        public long UserId { get; set; }
        /// <summary>
        /// Optional. Additional data about the contact in the form of a vCard
        /// </summary>
        [JsonPropertyName("vcard")]
        public string Vcard { get; set; }
    }
}