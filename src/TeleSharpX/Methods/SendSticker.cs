// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SendSticker
{
    /// <summary>
    /// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
    ///</summary>
    public static async Task<Message> SendStickerAsync(this TelegramClient cl, long chatId, InputFile sticker, long? messageThreadId = null, string? emoji = null, bool? disableNotification = null, bool? protectContent = null, long? replyToMessageId = null, bool? allowSendingWithoutReply = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            chat_id = chatId,
            sticker = sticker,
            message_thread_id = messageThreadId,
            emoji = emoji,
            disable_notification = disableNotification,
            protect_content = protectContent,
            reply_to_message_id = replyToMessageId,
            allow_sending_without_reply = allowSendingWithoutReply,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("sendSticker", System.Net.Http.HttpMethod.Post, body);
       
        return resp.Result;
        
    }
}
