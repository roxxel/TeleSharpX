using System;
using System.Threading.Tasks;
using TeleSharpX.Commands;
using TeleSharpX.Types;

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
        private readonly Polling _poller;
        private readonly CommandHandler _commandHandler;

        public TelegramClient(TelegramConfiguration configuration)
        {
            _configuration = configuration;
            _apiClient = new ApiClient(configuration.Token);
            _poller = new Polling(_apiClient);
            _poller.NewUpdate += PollerOnNewUpdate;
            _commandHandler = new CommandHandler(this);
        }

        public void Command(string command, Action<CommandContext> handler)
        {
            _commandHandler.Add(command, handler);
        }
        
        private void PollerOnNewUpdate(object sender, Update e)
        {
            if (e.ChatJoinRequest != null) OnChatJoinRequest?.Invoke(this, e.ChatJoinRequest);
            if (e.Message != null)
            {
                if (!_commandHandler.TryHandle(e.Message))
                    OnMessage?.Invoke(this, e.Message);
            } 
            if (e.PreCheckoutQuery != null) OnPreCheckoutQuery?.Invoke(this, e.PreCheckoutQuery);
            if (e.EditedMessage != null) OnEditedMessage?.Invoke(this, e.EditedMessage);
            if (e.ChannelPost != null) OnChannelPost?.Invoke(this, e.ChannelPost);
            if (e.EditedChannelPost != null) OnEditedChannelPost?.Invoke(this, e.EditedChannelPost);
            if (e.InlineQuery != null) OnInlineQuery?.Invoke(this, e.InlineQuery);
            if (e.ChosenInlineResult != null) OnChosenInlineResult?.Invoke(this, e.ChosenInlineResult);
            if (e.ShippingQuery != null) OnShippingQuery?.Invoke(this, e.ShippingQuery);
            if (e.Poll != null) OnPoll?.Invoke(this, e.Poll);
            if (e.PollAnswer != null) OnPollAnswer?.Invoke(this, e.PollAnswer);
            if (e.MyChatMember != null) OnBotChatMemberUpdated?.Invoke(this, e.MyChatMember);
            if (e.ChatMember != null) OnChatMemberUpdated?.Invoke(this, e.ChatMember);
            if (e.ChatJoinRequest != null) OnChatJoinRequest?.Invoke(this, e.ChatJoinRequest);
        }

        /// <summary>
        /// New incoming message of any kind - text, photo, sticker, etc.
        /// </summary>
        public event EventHandler<Message> OnMessage;
        /// <summary>
        /// New version of a message that is known to the bot and was edited
        /// </summary>
        public event EventHandler<Message> OnEditedMessage;
        /// <summary>
        /// New incoming channel post of any kind - text, photo, sticker, etc.
        /// </summary>
        public event EventHandler<Message> OnChannelPost;
        /// <summary>
        /// New version of a channel post that is known to the bot and was edited
        ///</summary>
        public event EventHandler<Message> OnEditedChannelPost;
        /// <summary>
        /// New incoming inline query
        /// </summary>
        public event EventHandler<InlineQuery> OnInlineQuery;
        /// <summary>
        /// The result of an inline query that was chosen by a user and sent to their chat partner. Please see our documentation on the feedback collecting for details on how to enable these updates for your bot.
        /// </summary>
        public event EventHandler<ChosenInlineResult> OnChosenInlineResult;
        /// <summary>
        /// New incoming callback query
        /// </summary>
        public event EventHandler<CallbackQuery> OnCallbackQuery;
        /// <summary>
        /// New incoming shipping query. Only for invoices with flexible price
        /// </summary>
        public event EventHandler<ShippingQuery> OnShippingQuery;
        /// <summary>
        /// New incoming pre-checkout query. Contains full information about checkout
        /// </summary>
        public event EventHandler<PreCheckoutQuery> OnPreCheckoutQuery;
        /// <summary>
        /// New poll state. Bots receive only updates about stopped polls and polls, which are sent by the bot
        /// </summary>
        public event EventHandler<Poll> OnPoll;
        /// <summary>
        /// A user changed their answer in a non-anonymous poll. Bots receive new votes only in polls that were sent by the bot itself.
        /// </summary>
        public event EventHandler<PollAnswer> OnPollAnswer;
        /// <summary>
        /// The bot&apos;s chat member status was updated in a chat. For private chats, this update is received only when the bot is blocked or unblocked by the user.
        /// </summary>
        public event EventHandler<ChatMemberUpdated> OnBotChatMemberUpdated;
        /// <summary>
        /// A chat member&apos;s status was updated in a chat. The bot must be an administrator in the chat and must explicitly specify “chat_member” in the list of allowed_updates to receive these updates.
        /// </summary>
        public event EventHandler<ChatMemberUpdated> OnChatMemberUpdated;
        /// <summary>
        /// A request to join the chat has been sent. The bot must have the can_invite_users administrator right in the chat to receive these updates.
        /// </summary>
        public event EventHandler<ChatJoinRequest> OnChatJoinRequest;
        
        public async Task StartPolling()
        {
            await _poller.StartPolling();
        }
    }
}