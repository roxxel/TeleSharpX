//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class EncryptedCredentials 
    {
        /// <summary>
        /// Base64-encoded encrypted JSON-serialized data with unique user&apos;s payload, data hashes and secrets required for EncryptedPassportElement decryption and authentication
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }
        /// <summary>
        /// Base64-encoded data hash for data authentication
        /// </summary>
        [JsonProperty("hash")]
        public string Hash { get; set; }
        /// <summary>
        /// Base64-encoded secret, encrypted with the bot&apos;s public RSA key, required for data decryption
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}