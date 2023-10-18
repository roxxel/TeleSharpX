using System;
using System.Collections.Generic;
using System.Linq;
using TeleSharpX.Commands;
using TeleSharpX.Types;

namespace TeleSharpX
{
    public class CommandHandler
    {
        private readonly TelegramClient _client;
        private readonly Dictionary<string, Action<CommandContext>> _commands;

        internal CommandHandler(TelegramClient client)
        {
            _client = client;
            _commands = new Dictionary<string, Action<CommandContext>>();
        }


        public void Add(string command, Action<CommandContext> handler)
        {
            _commands[command] = handler;
        }

        public bool TryHandle(Message msg)
        {
            var commandKey = _commands.Keys.FirstOrDefault(x => msg.Text.StartsWith($"/{x}"));
            if (commandKey == null)
                return false;
            var handler = _commands[commandKey];
            handler(new CommandContext()
            {
                Client = _client,
                Message = msg
            });
            return true;
        }
    }
}