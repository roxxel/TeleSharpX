using System.Text.Json;
using TeleSharpX;



var cfg = JsonSerializer.Deserialize<Config>(File.ReadAllText("config.json"));
var client = new TelegramClient(new()
{
    Token = cfg.BotToken
});

client.OnMessage += (sender, message) =>
{
    Console.WriteLine(message.From.FirstName + " " + message.Text);
};

await client.StartPolling();
class Config
{
    public string BotToken { get; set; }
}