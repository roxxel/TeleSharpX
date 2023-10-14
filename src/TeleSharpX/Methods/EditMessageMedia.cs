// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class EditMessageMedia
{
    /// <summary>
    /// Use this method to edit animation, audio, document, photo, or video messages. If a message is part of a message album, then it can be edited only to an audio for audio albums, only to a document for document albums and to a photo or a video otherwise. When an inline message is edited, a new file can&apos;t be uploaded; use a previously uploaded file via its file_id or specify a URL. On success, if the edited message is not an inline message, the edited Message is returned, otherwise True is returned.
    ///</summary>
    public static async Task<Message> EditMessageMediaAsync(this TelegramClient cl, InputMedia media, long? chatId = null, long? messageId = null, string? inlineMessageId = null, ReplyMarkup? replyMarkup = null)
    {
        var api = cl._apiClient;
        var body = new {
            media = media,
            chat_id = chatId,
            message_id = messageId,
            inline_message_id = inlineMessageId,
            reply_markup = replyMarkup
        };
        var resp = await api.Send<Message>("editMessageMedia", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
