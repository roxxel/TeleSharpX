using System.Linq;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using TeleSharpX.Types;

namespace TeleSharpX
{
    internal class Polling
    {
        private readonly ApiClient _client;

        private long lastUpdateId = 0;
        private Task _task;
        private CancellationTokenSource _cts;
        internal event EventHandler<Update> NewUpdate;
        
        public Polling(ApiClient client)
        {
            _client = client;
        }

        internal async Task StartPolling()
        {
            if (_cts != null)
            {
                _cts.Cancel();
            }
            _cts = new CancellationTokenSource();
            _task = Task.Run(async () =>
            {
                while (!_cts.IsCancellationRequested)
                {
                    try
                    {

                        var getUpdatesResp =
                            await _client.Send<Update[]>(
                                $"getUpdates?timeout=25{(lastUpdateId != 0 ? $"&offset={lastUpdateId}" : "")}", HttpMethod.Get,
                                null);
                        var updates = getUpdatesResp.Result;
                        foreach (var update in updates)
                        {
                            NewUpdate?.Invoke(this, update);
                        }

                        if (updates.Length > 0)
                        {
                            lastUpdateId = getUpdatesResp.Result.Last().UpdateId + 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    await Task.Delay(1000);
                }
            });
            await Task.Delay(-1);
        }

        internal void StopPolling()
        {
            _cts.Cancel();
        }
    }
}