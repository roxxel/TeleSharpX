// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetChatMember
{
    /// <summary>
    /// Use this method to get information about a member of a chat. The method is only guaranteed to work for other users if the bot is an administrator in the chat. Returns a ChatMember object on success.
    ///</summary>
    public static async Task<ChatMember> GetChatMemberAsync(this TelegramClient cl, long chatId, long userId)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            user_id = userId
        };
        var resp = await api.Send<ChatMember>("getChatMember", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
