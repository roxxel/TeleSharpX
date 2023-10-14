//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class EncryptedPassportElement 
    {
        /// <summary>
        /// Element type. One of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”, “phone_number”, “email”.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
        /// <summary>
        /// Optional. Base64-encoded encrypted Telegram Passport element data provided by the user, available for “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport” and “address” types. Can be decrypted and verified using the accompanying EncryptedCredentials.
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }
        /// <summary>
        /// Optional. User&apos;s verified phone number, available only for “phone_number” type
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Optional. User&apos;s verified email address, available only for “email” type
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }
        /// <summary>
        /// Optional. Array of encrypted files with documents provided by the user, available for “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration” and “temporary_registration” types. Files can be decrypted and verified using the accompanying EncryptedCredentials.
        /// </summary>
        [JsonPropertyName("files")]
        public System.Collections.Generic.IEnumerable<PassportFile> Files { get; set; }
        /// <summary>
        /// Optional. Encrypted file with the front side of the document, provided by the user. Available for “passport”, “driver_license”, “identity_card” and “internal_passport”. The file can be decrypted and verified using the accompanying EncryptedCredentials.
        /// </summary>
        [JsonPropertyName("front_side")]
        public PassportFile FrontSide { get; set; }
        /// <summary>
        /// Optional. Encrypted file with the reverse side of the document, provided by the user. Available for “driver_license” and “identity_card”. The file can be decrypted and verified using the accompanying EncryptedCredentials.
        /// </summary>
        [JsonPropertyName("reverse_side")]
        public PassportFile ReverseSide { get; set; }
        /// <summary>
        /// Optional. Encrypted file with the selfie of the user holding a document, provided by the user; available for “passport”, “driver_license”, “identity_card” and “internal_passport”. The file can be decrypted and verified using the accompanying EncryptedCredentials.
        /// </summary>
        [JsonPropertyName("selfie")]
        public PassportFile Selfie { get; set; }
        /// <summary>
        /// Optional. Array of encrypted files with translated versions of documents provided by the user. Available if requested for “passport”, “driver_license”, “identity_card”, “internal_passport”, “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration” and “temporary_registration” types. Files can be decrypted and verified using the accompanying EncryptedCredentials.
        /// </summary>
        [JsonPropertyName("translation")]
        public System.Collections.Generic.IEnumerable<PassportFile> Translation { get; set; }
        /// <summary>
        /// Base64-encoded element hash for using in PassportElementErrorUnspecified
        /// </summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }
    }
}