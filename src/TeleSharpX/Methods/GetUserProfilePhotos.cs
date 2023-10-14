// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetUserProfilePhotos
{
    /// <summary>
    /// Use this method to get a list of profile pictures for a user. Returns a UserProfilePhotos object.
    ///</summary>
    public static async Task<UserProfilePhotos> GetUserProfilePhotosAsync(this TelegramClient cl, long userId, long? offset = null, long? limit = null)
    {
        var api = cl._apiClient;
        var body = new {
            user_id = userId,
            offset = offset,
            limit = limit
        };
        var resp = await api.Send<UserProfilePhotos>("getUserProfilePhotos", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
