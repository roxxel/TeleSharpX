namespace TeleSharpX
{
    public class TelegramConfiguration
    {
        public string Token { get; set; }
    }
    public class TelegramClient
    {
        private readonly TelegramConfiguration _configuration;

        internal ApiClient _apiClient;
        public TelegramClient(TelegramConfiguration configuration)
        {
            _configuration = configuration;
            _apiClient = new ApiClient(configuration.Token);
        }
    }
}