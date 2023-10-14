//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class InlineKeyboardButton 
	{
		/// <summary>
		/// Label text on the button
		/// </summary>
		[JsonPropertyName("text")]
		public string Text { get; set; }
		/// <summary>
		/// Optional. HTTP or tg:// URL to be opened when the button is pressed. Links tg://user?id=&lt;user_id&gt; can be used to mention a user by their ID without using a username, if this is allowed by their privacy settings.
		/// </summary>
		[JsonPropertyName("url")]
		public string Url { get; set; }
		/// <summary>
		/// Optional. Data to be sent in a callback query to the bot when button is pressed, 1-64 bytes
		/// </summary>
		[JsonPropertyName("callback_data")]
		public string CallbackData { get; set; }
		/// <summary>
		/// Optional. Description of the Web App that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method answerWebAppQuery. Available only in private chats between a user and the bot.
		/// </summary>
		[JsonPropertyName("web_app")]
		public WebAppInfo WebApp { get; set; }
		/// <summary>
		/// Optional. An HTTPS URL used to automatically authorize the user. Can be used as a replacement for the Telegram Login Widget.
		/// </summary>
		[JsonPropertyName("login_url")]
		public LoginUrl LoginUrl { get; set; }
		/// <summary>
		/// Optional. If set, pressing the button will prompt the user to select one of their chats, open that chat and insert the bot&apos;s username and the specified inline query in the input field. May be empty, in which case just the bot&apos;s username will be inserted.
		/// </summary>
		[JsonPropertyName("switch_inline_query")]
		public string SwitchInlineQuery { get; set; }
		/// <summary>
		/// Optional. If set, pressing the button will insert the bot&apos;s username and the specified inline query in the current chat&apos;s input field. May be empty, in which case only the bot&apos;s username will be inserted.
		/// 
		/// This offers a quick way for the user to open your bot in inline mode in the same chat - good for selecting something from multiple options.
		/// </summary>
		[JsonPropertyName("switch_inline_query_current_chat")]
		public string SwitchInlineQueryCurrentChat { get; set; }
		/// <summary>
		/// Optional. If set, pressing the button will prompt the user to select one of their chats of the specified type, open that chat and insert the bot&apos;s username and the specified inline query in the input field
		/// </summary>
		[JsonPropertyName("switch_inline_query_chosen_chat")]
		public SwitchInlineQueryChosenChat SwitchInlineQueryChosenChat { get; set; }
		/// <summary>
		/// Optional. Description of the game that will be launched when the user presses the button.
		/// 
		/// NOTE: This type of button must always be the first button in the first row.
		/// </summary>
		[JsonPropertyName("callback_game")]
		public CallbackGame CallbackGame { get; set; }
		/// <summary>
		/// Optional. Specify True, to send a Pay button.
		/// 
		/// NOTE: This type of button must always be the first button in the first row and can only be used in invoice messages.
		/// </summary>
		[JsonPropertyName("pay")]
		public bool Pay { get; set; }
	}
}