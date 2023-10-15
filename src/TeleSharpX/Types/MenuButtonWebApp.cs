//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using Newtonsoft.Json;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class MenuButtonWebApp : MenuButton
	{
		/// <summary>
		/// Type of the button, must be web_app
		/// </summary>
		[JsonProperty("type")]
		public string Type => "web_app";
		/// <summary>
		/// Text on the button
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }
		/// <summary>
		/// Description of the Web App that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method answerWebAppQuery.
		/// </summary>
		[JsonProperty("web_app")]
		public WebAppInfo WebApp { get; set; }
	}
}