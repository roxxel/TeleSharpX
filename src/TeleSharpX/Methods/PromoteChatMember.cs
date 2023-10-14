// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class PromoteChatMember
{
    /// <summary>
    /// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass False for all boolean parameters to demote a user. Returns True on success.
    ///</summary>
    public static async Task<bool> PromoteChatMemberAsync(this TelegramClient cl, long chatId, long userId, bool? isAnonymous = null, bool? canManageChat = null, bool? canPostMessages = null, bool? canEditMessages = null, bool? canDeleteMessages = null, bool? canManageVideoChats = null, bool? canRestrictMembers = null, bool? canPromoteMembers = null, bool? canChangeInfo = null, bool? canInviteUsers = null, bool? canPinMessages = null, bool? canManageTopics = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            user_id = userId,
            is_anonymous = isAnonymous,
            can_manage_chat = canManageChat,
            can_post_messages = canPostMessages,
            can_edit_messages = canEditMessages,
            can_delete_messages = canDeleteMessages,
            can_manage_video_chats = canManageVideoChats,
            can_restrict_members = canRestrictMembers,
            can_promote_members = canPromoteMembers,
            can_change_info = canChangeInfo,
            can_invite_users = canInviteUsers,
            can_pin_messages = canPinMessages,
            can_manage_topics = canManageTopics
        };
        var resp = await api.Send<bool>("promoteChatMember", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
