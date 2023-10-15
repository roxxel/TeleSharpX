//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
    public class PassportData 
    {
        /// <summary>
        /// Array with information about documents and other Telegram Passport elements that was shared with the bot
        /// </summary>
        [JsonProperty("data")]
        public System.Collections.Generic.IEnumerable<EncryptedPassportElement> Data { get; set; }
        /// <summary>
        /// Encrypted credentials required to decrypt the data
        /// </summary>
        [JsonProperty("credentials")]
        public EncryptedCredentials Credentials { get; set; }
    }
}