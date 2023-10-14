//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
using System;

namespace TeleSharpX.Types
{
    public enum ChatMemberStatus
    {
        Creator,
        Administrator,
        Member,
        Restricted,
        Kicked
    }
    public class ChatMember
    {
        [JsonPropertyName("status")]
        internal string StringStatus { get; set; }

        public ChatMemberStatus Status => Enum.Parse<ChatMemberStatus>(StringStatus, true);
    }
}
