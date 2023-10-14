// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetMyDefaultAdministratorRights
{
    /// <summary>
    /// Use this method to change the default administrator rights requested by the bot when it&apos;s added as an administrator to groups or channels. These rights will be suggested to users, but they are free to modify the list before adding the bot. Returns True on success.
    ///</summary>
    public static async Task<bool> SetMyDefaultAdministratorRightsAsync(this TelegramClient cl, ChatAdministratorRights? rights = null, bool? forChannels = null)
    {
        var api = cl._apiClient;
        var body = new {
            rights = rights,
            for_channels = forChannels
        };
        var resp = await api.Send<bool>("setMyDefaultAdministratorRights", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
