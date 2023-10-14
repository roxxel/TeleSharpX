//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class InputContactMessageContent 
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
        /// Optional. Additional data about the contact in the form of a vCard, 0-2048 bytes
        /// </summary>
        [JsonPropertyName("vcard")]
        public string Vcard { get; set; }
    }
}