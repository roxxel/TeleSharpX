// AUTO-GENERATED
using System;
using System.Threading.Tasks;
using TeleSharpX.Types;
using TeleSharpX;
    

public static class SetPassportDataErrors
{
    /// <summary>
    /// Informs a user that some of the Telegram Passport elements they provided contains errors. The user will not be able to re-submit their Passport to you until the errors are fixed (the contents of the field for which you returned the error must change). Returns True on success.
    ///</summary>
    public static async Task<bool> SetPassportDataErrorsAsync(this TelegramClient cl, long userId, System.Collections.Generic.IEnumerable<PassportElementError> errors)
    {
        var api = cl._apiClient;
        var body = new {
			user_id = userId,
			errors = errors
		};
        var resp = await api.Send<bool>("setPassportDataErrors", System.Net.Http.HttpMethod.Post, body);
        if (resp.Ok)
        {
            return resp.Result;
        }
        throw new Exception(resp.Description);
    }
}
