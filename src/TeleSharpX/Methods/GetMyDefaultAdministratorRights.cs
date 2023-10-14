// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class GetMyDefaultAdministratorRights
{
    /// <summary>
    /// Use this method to get the current default administrator rights of the bot. Returns ChatAdministratorRights on success.
    ///</summary>
    public static async Task<ChatAdministratorRights> GetMyDefaultAdministratorRightsAsync(this TelegramClient cl, bool? forChannels = null)
    {
        var api = cl._apiClient;
        var body = new {
			for_channels = forChannels
		};
        var resp = await api.Send<ChatAdministratorRights>("getMyDefaultAdministratorRights", System.Net.Http.HttpMethod.Get, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
