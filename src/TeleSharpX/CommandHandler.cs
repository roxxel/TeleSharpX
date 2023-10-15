namespace TeleSharpX
{
    public class CommandHandler
    {
        private readonly TelegramClient _client;

        internal CommandHandler(TelegramClient client)
        {
            _client = client;
        }
    }
}