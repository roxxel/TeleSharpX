using TeleSharpX.Types;

namespace TeleSharpX.Commands
{
    public class CommandContext
    {
        public TelegramClient Client { get; internal set; }
        public Message Message { get; internal set; }
    }
}