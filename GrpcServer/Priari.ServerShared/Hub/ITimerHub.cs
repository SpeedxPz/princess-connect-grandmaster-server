using System;
using System.Collections.Generic;
using System.Text;
using MagicOnion;
using System.Threading.Tasks;

namespace Priari.ServerShared
{
    public interface ITimerHub : IStreamingHub<ITimerHub, ITimerHubReceiver>
    {
        Task SetAsync(TimeSpan interval);
    }

    public interface ITimerHubReceiver
    {
        void OnTick(string message);
    }
}
