using System.Text.Json;
using TeleSharpX;
using TeleSharpX.Types;
using File = System.IO.File;


var cfg = JsonSerializer.Deserialize<Config>(File.ReadAllText("config.json"));
var client = new TelegramClient(new()
{
    Token = cfg.BotToken
});

client.OnMessage += async (sender, message) =>
{
    Console.WriteLine(message.From.FirstName + " " + message.Text);
    var msg = await client.SendPhotoAsync(
        message.From.Id, 
        InputFile.FromUrl("https://variety.com/wp-content/uploads/2021/07/Rick-Astley-Never-Gonna-Give-You-Up.png?w=1024"));
    Console.WriteLine(msg.Photo.ToList()[0].FileId);
};

await client.StartPolling();
class Config
{
    public string BotToken { get; set; }
}