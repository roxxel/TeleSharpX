//AUTO-GENERATED; PLEASE DO NOT EDIT BY HAND
using TeleSharpX.Types;
using System.Text.Json.Serialization;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace TeleSharpX.Types
{
	public class InputSticker 
	{
		/// <summary>
		/// The added sticker. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, upload a new one using multipart/form-data, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. Animated and video stickers can&apos;t be uploaded via HTTP URL. More information on Sending Files »
		/// </summary>
		[JsonPropertyName("sticker")]
		public InputFile Sticker { get; set; }
		/// <summary>
		/// List of 1-20 emoji associated with the sticker
		/// </summary>
		[JsonPropertyName("emoji_list")]
		public System.Collections.Generic.IEnumerable<string> EmojiList { get; set; }
		/// <summary>
		/// Optional. Position where the mask should be placed on faces. For “mask” stickers only.
		/// </summary>
		[JsonPropertyName("mask_position")]
		public MaskPosition MaskPosition { get; set; }
		/// <summary>
		/// Optional. List of 0-20 search keywords for the sticker with total length of up to 64 characters. For “regular” and “custom_emoji” stickers only.
		/// </summary>
		[JsonPropertyName("keywords")]
		public System.Collections.Generic.IEnumerable<string> Keywords { get; set; }
	}
}