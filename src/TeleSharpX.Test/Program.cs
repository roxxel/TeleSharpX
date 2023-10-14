using System.Text.Json;
using TeleSharpX;



var cfg = JsonSerializer.Deserialize<Config>(File.ReadAllText("config.json"));
var client = new TelegramClient(new()
{
    Token = cfg.BotToken
});

var me = await client.SendMessageAsync(774616838,"test");

class Config
{
    public string BotToken { get; set; }
}