using dotenv.net;
using Newtonsoft.Json.Linq;
using TeleSharpX;
using TeleSharpX.Types;

DotEnv.Load();

var env = DotEnv.Read();
var token = env["BOT_TOKEN"];
var tenorKey = env["TENOR_KEY"];
var client = new TelegramClient(new()
{
    Token = token
});

client.OnInlineQuery += async (s, q) =>
{
    if (string.IsNullOrEmpty(q.Query)) return;
    using var httpClient = new HttpClient();
    var str = await httpClient.GetStringAsync(
        $"https://tenor.googleapis.com/v2/search?q={q.Query}&key={tenorKey}&client_key=my_test_app&limit=20");
    var json = JObject.Parse(str);
    dynamic results = json["results"];
    var list = new List<InlineQueryResult>();
    foreach (var result in results)
    {
        list.Add(new InlineQueryResultGif()
        {
            Id = Guid.NewGuid().ToString(),
            ThumbnailUrl = result["media_formats"]["tinygif"]["url"],
            GifUrl = result["media_formats"]["gif"]["url"]
        });
    }
    await client.AnswerInlineQueryAsync(q.Id, list);

};
await client.StartPolling();